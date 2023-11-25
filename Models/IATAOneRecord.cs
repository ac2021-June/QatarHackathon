using Newtonsoft.Json;

namespace AngularWebsite.Models
{
    
        public class HttpsOnerecordIataOrgNsApiHasDataOwner
        {
            [JsonProperty("@id")]
            public string id { get; set; }

            [JsonProperty("@type")]
            public string type { get; set; }

            [JsonProperty("https://onerecord.iata.org/ns/cargo#name")]
            public string httpsonerecordiataorgnscargoname { get; set; }
        }

    public class IATAOneRecord
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/api#hasDataOwner")]
        public HttpsOnerecordIataOrgNsApiHasDataOwner httpsonerecordiataorgnsapihasDataOwner { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/api#hasServerEndpoint")]
        public string httpsonerecordiataorgnsapihasServerEndpoint { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/api#hasSupportedContentType")]
        public List<string> httpsonerecordiataorgnsapihasSupportedContentType { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/api#hasSupportedLanguage")]
        public string httpsonerecordiataorgnsapihasSupportedLanguage { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/api#hasSupportedLogisticsObjectType")]
        public List<string> httpsonerecordiataorgnsapihasSupportedLogisticsObjectType { get; set; }
    }    
}
