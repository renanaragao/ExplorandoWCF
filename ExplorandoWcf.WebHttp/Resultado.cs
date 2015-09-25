using System.Runtime.Serialization;

namespace ExplorandoWcf.WebHttp
{
    [DataContract]
    public class Resultado<T>
    {
        [DataMember, Newtonsoft.Json.JsonProperty]
        public T Valor { get; set; }

        [DataMember, Newtonsoft.Json.JsonProperty]
        public string Mensagem { get; set; }
    }
}