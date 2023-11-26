using Newtonsoft.Json;

namespace QatarHackathon.Models
{
    public class ProductDg
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public List<string> Type { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#additionalHazardClassificationId")]
        public string AdditionalHazardClassificationId { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#dgRadioactiveMaterial")]
        public DgRadioactiveMaterial DgRadioactiveMaterial { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#hazardClassificationId")]
        public string HazardClassificationId { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#packagingDangerLevelCode")]
        public string PackagingDangerLevelCode { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#properShippingName")]
        public string ProperShippingName { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#technicalName")]
        public string TechnicalName { get; set; }

        [JsonProperty("https://onerecord.iata.org/ns/cargo#unNumber")]
        public string UnNumber { get; set; }
    }

    public class DgRadioactiveMaterial
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
    }

}
