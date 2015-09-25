using System.ServiceModel.Channels;

namespace ExplorandoWcf.WebHttp.DataContractJsonSerializer
{
    public class NewtonsoftJsonContentTypeMapper : WebContentTypeMapper
    {
        public override WebContentFormat GetMessageFormatForContentType(string contentType)
        {
            return WebContentFormat.Raw;
        }
    }
}