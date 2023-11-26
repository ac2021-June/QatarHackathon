using Newtonsoft.Json;

namespace QatarHackathon.Models
{
    public class ULD
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public List<string> Type { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#uldSerialNumber")]
        public string UldSerialNumber { get; set; }
    }


}
