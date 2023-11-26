using Newtonsoft.Json;

namespace QatarHackathon.Models
{
    public class Waybill
    {
            [JsonProperty("@id")]
            public string Id { get; set; }

            [JsonProperty("@type")]
            public string Type { get; set; }

            [JsonProperty("https://onerecord.iata.org/ns/cargo#arrivalLocation")]
            public string ArrivalLocation { get; set; }

            [JsonProperty("https://onerecord.iata.org/ns/cargo#destinationLocation")]
            public string DestinationLocation { get; set; }

            [JsonProperty("https://onerecord.iata.org/ns/cargo#waybillNumber")]
            public string WaybillNumber { get; set; }

            [JsonProperty("https://onerecord.iata.org/ns/cargo#waybillPrefix")]
            public string WaybillPrefix { get; set; }

            [JsonProperty("https://onerecord.iata.org/ns/cargo#masterWaybill")]
            public string MasterWaybill { get; set; }
        

    }

}
