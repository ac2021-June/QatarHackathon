using Newtonsoft.Json;

namespace QatarHackathon.Models
{
    public class DgProductRadioactive
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#transportIndexNumeric:")]
        public TransportIndexNumeric TransportIndexNumeric { get; set; }
    }

    public class TransportIndexNumeric
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@value")]
        public double Value { get; set; }
    }

}
