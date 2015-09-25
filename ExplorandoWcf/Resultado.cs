using System.Runtime.Serialization;

namespace ExplorandoWcf
{
    [DataContract]
    public class Resultado<T>
    {
        [DataMember]
        public T Valor { get; set; }

        [DataMember]
        public string Mensagem { get; set; }
    }
}