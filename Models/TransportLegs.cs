using Newtonsoft.Json;

namespace QatarHackathon.Models
{
    public class TransportLegs
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#arrivalLocation")]
        public string ArrivalLocation { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#departureLocation")]
        public string DepartureLocation { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#legNumber")]
        public LegNumber LegNumber { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#transportIdentifier")]
        public string TransportIdentifier { get; set; }
    }

    public class LegNumber
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@value")]
        public int Value { get; set; }
    }

}
