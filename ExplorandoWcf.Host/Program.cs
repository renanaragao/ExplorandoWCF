using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ExplorandoWcf.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando o endereço.
            var baseAddress = new Uri("http://localhost:8000/explorando-wcf/");

            // Crair o Host
            var selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {
                // Criando o EndPoint
                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "calculator");

                // Criando um comportamento indicando que ele pode ser acessado via web
                var smb = new ServiceMetadataBehavior { HttpGetEnabled = true };
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.
                selfHost.Open();
                Console.WriteLine("Serviço rodando.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Ocorreu um exceção: {0}", ex.Message);
                selfHost.Abort();
            }

        }
    }
}
