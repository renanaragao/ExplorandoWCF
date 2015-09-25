using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ExplorandoWcf
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    
    public interface ICalculator
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "add/{n1}/{n2}")]
        Resultado<double> Add(string n1, string n2);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "subtract/{n1}/{n2}")]
        Resultado<double> Subtract(string n1, string n2);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "multiply/{n1}/{n2}")]
        Resultado<double> Multiply(string n1, string n2);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "divide/{n1}/{n2}")]
        Resultado<double> Divide(string n1, string n2);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "search?id={id}")]
        Resultado<int> Search(int id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "date-now?date={date}")]
        Resultado<DateTime> DateNow(DateTime date);
    }
}
