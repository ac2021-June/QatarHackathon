using Newtonsoft.Json;

namespace QatarHackathon.Models
{
    public class DgDeclaration
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#aircraftLimitationInformation")]
        public string AircraftLimitationInformation { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#complianceDeclarationText")]
        public string ComplianceDeclarationText { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#exclusiveUseIndicator")]
        public string ExclusiveUseIndicator { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#handlingInformation")]
        public string HandlingInformation { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#shipperDeclarationText")]
        public string ShipperDeclarationText { get; set; }
    }


}
