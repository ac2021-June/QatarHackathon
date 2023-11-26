namespace QatarHackathon.Models
{
    public class NOTOCRecord
    {
        public int ItemNumber { get; set; }
        public string ULDNumber { get; set; }

        public string ProperShippingName { get; set; }
        public string OriginStation { get; set; }
        public string OffloadStation { get; set; }
        public string FinalDestination { get; set; }
        public string AirWaybillNumber { get; set; }
        public string HazardClassificationId { get; set; }
        public string UnNumber { get; set; }
        public string AdditionalHazardClassificationId { get; set; }
        public int MinimumQuantityPerShipment { get; set; }
        public double TransportIndexNumericdpback { get; set; }
        public string UnitOfMeasure { get; set; }
        public int NumberOfPackages { get; set; }
        public string PackagingDangerLevelCode { get; set; }
        public string DgRaTypeCode { get; set; }
        public bool CargoAircraftOnly { get; set; }
        public string CargoIMPCode { get; set; }
        public string LocationOnAircraft { get; set; }
        public string TemperatureRequirement { get; set; }
        public string StateExemption { get; set; }
        public string Remarks { get; set; }
        public string LoadingPersonnelSignature { get; set; }
        public string CaptainSignature { get; set; }
    }
}
