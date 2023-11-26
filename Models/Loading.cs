using Newtonsoft.Json;

namespace QatarHackathon.Models
{
        public class LoadedUnits
        {
            public string Id { get; set; }
        }

        public class ServedActivity
        {
            public string Id { get; set; }
        }

    public class Loading
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#loadedUnits")]
        public LoadedUnits LoadedUnits { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#loadingPositionIdentifier")]
        public string LoadingPositionIdentifier { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#servedActivity")]
        public ServedActivity ServedActivity { get; set; }
    }    
}
