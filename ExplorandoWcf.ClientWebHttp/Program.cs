using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.ServiceModel.Description;
using ExplorandoWcf.WebHttp;
using ExplorandoWcf.WebHttp.DataContractJsonSerializer;
using Newtonsoft.Json;

namespace ExplorandoWcf.ClientWebHttp
{
    class Program
    {
        static void Main(string[] args)
        {

            var baseAddress = new Uri("http://localhost:8954/explorando-wcf-web-http/");

            var selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                var endPoint = selfHost.AddServiceEndpoint(typeof(ICalculator), new WebHttpBinding(), "calculator");

                endPoint.Behaviors.Add(new NewtonsoftJsonBehavior());


                Console.WriteLine(typeof(NewtonsoftJsonContentTypeMapper).AssemblyQualifiedName);

                selfHost.Open();
                Console.WriteLine("Serviço rodando.");
                Console.WriteLine();

                ConsumirServicoGet<double>("calculator/add/2/25");
                ConsumirServicoGet<DateTime>("calculator/date-now/29-10-2015");

                ConsumirServicoPost("calculator/add-days", new Resultado<DateTime> { Valor = DateTime.Now });

                Console.ReadLine();

                selfHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Ocorreu um exceção: {0}", ex.Message);
                selfHost.Abort();
                Console.ReadLine();
            }

        }

        private static async void ConsumirServicoPost<T>(string uri, T objeto)
        {
            Console.WriteLine("Operação: {0}", uri);

            using (var http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://localhost:8954/explorando-wcf-web-http/");
                http.DefaultRequestHeaders.Accept.Clear();
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await http.PostAsJsonAsync(uri, objeto);

                if (!response.IsSuccessStatusCode)
                {

                    Console.WriteLine(response.StatusCode);
                    return;
                }

                var resultado = await response.Content.ReadAsAsync<Resultado<T>>();

                Console.WriteLine("Valor: {0}", resultado.Valor);
            }

        }

        private static async void ConsumirServicoGet<T>(string uri)
        {

            Console.WriteLine("Operação: {0}", uri);

            using (var http = new HttpClient())
            {
                http.BaseAddress = new Uri("http://localhost:8954/explorando-wcf-web-http/");
                http.DefaultRequestHeaders.Accept.Clear();
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await http.GetAsync(uri);

                if (!response.IsSuccessStatusCode)
                {

                    Console.WriteLine(response.StatusCode);
                    return;
                }

                var resultado = await response.Content.ReadAsAsync<Resultado<T>>();

                Console.WriteLine("Valor: {0}", resultado.Valor);
            }

        }
    }
}
