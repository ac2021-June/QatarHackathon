using AngularWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QatarHackathon.Models;

namespace QatarHackathon.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NotocRecordController : Controller
    {
        private readonly HttpClient _client;

        public NotocRecordController(HttpClient client) => _client = client;

        [HttpGet]
        public async Task<ActionResult<NOTOCRecord[]>> Get()
        {
            //Waybill


            var notocrecords = new List<NOTOCRecord>();
            // 1st record
            //Dry Ice
            List<string> dataList=new List<string>();

            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/12bb0475-2508-4721-8ea2-0b37ea6260a0");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/5c8eda67-5c80-4519-bf52-debef331777f");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/d6bf3bd6-4ffb-416b-9d86-0dd8e2f98487");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/1663b411-e794-45ef-adc1-cd3939b3195d");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/3d5340dd-cb9b-4248-94fb-91c1bb1107a4");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/33ee51e8-d0ea-44dd-b060-48847dc4d5d1");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/4783b0dc-4e99-444d-b8c0-0ca08775bb16");
            NOTOCRecord dryiceRecord = await GetNOTOCRecord(dataList);
            notocrecords.Add(dryiceRecord);
            dataList.Clear();

            ////RadioActives
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/12bb0475-2508-4721-8ea2-0b37ea6260a0");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/fa2d6736-fbe3-4c8b-b817-3e011a77ce84");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/b4828fd2-4ab1-405e-bc19-4b880a53bab6");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/1663b411-e794-45ef-adc1-cd3939b3195d");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/3d5340dd-cb9b-4248-94fb-91c1bb1107a4");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/e37d35ec-41f9-439f-9a29-414c6936c11f");
            dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/113b2e7a-302a-476f-b0c3-bbd3c4dd840e");
            NOTOCRecord radioActivesRecords = await GetNOTOCRecord(dataList);
            notocrecords.Add(radioActivesRecords);

            string jsonString   = "[{\"itemNumber\": 0,\"uldNumber\": \"PAG09127R7\",\"properShippingName\": \"BENZYLIODIDE\",\"originStation\": null,\"offloadStation\": \"YUL\",\"finalDestination\": \"YUL\",\"airWaybillNumber\": \"014-37652873\",\"hazardClassificationId\": \"6.1\",\"unNumber\": \"UN 2653\",\"additionalHazardClassificationId\": \"\",\"minimumQuantityPerShipment\": 0,\"transportIndexNumericdpback\": 0.3, \"unitOfMeasure\": null, \"numberOfPackages\": 0, \"packagingDangerLevelCode\": \"II\",\"dgRaTypeCode\": null,\"cargoAircraftOnly\": false,\"cargoIMPCode\": null, \"locationOnAircraft\": \"24\",\"temperatureRequirement\": null,\"stateExemption\": null,\"remarks\": null,\"loadingPersonnelSignature\": null,\"captainSignature\": null },{\"itemNumber\": 0,\"uldNumber\": \"PAG09127R7\",\"properShippingName\": \"DIETHYLBENZENE\",\"originStation\": null,\"offloadStation\": \"YUL\",        \"finalDestination\": \"YUL\",\"airWaybillNumber\": \"014-37652873\",\"hazardClassificationId\": \"3\",\"unNumber\": \"UN 2049\",        \"additionalHazardClassificationId\": \"\",\"minimumQuantityPerShipment\": 0,\"transportIndexNumericdpback\": 5,\"unitOfMeasure\": null,        \"numberOfPackages\": 0,\"packagingDangerLevelCode\": \"III\",\"dgRaTypeCode\": null,\"cargoAircraftOnly\": false,        \"cargoIMPCode\": null,\"locationOnAircraft\": \"24\",\"temperatureRequirement\": null,\"stateExemption\": null,        \"remarks\": null,\"loadingPersonnelSignature\": null,\"captainSignature\": null}]";
            notocrecords.AddRange( JsonConvert.DeserializeObject<List<NOTOCRecord>>(jsonString));
            dataList.Clear();


            //////RadioActives 2
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/984e1ded-46a2-4bed-91b6-ca2a9939e12d");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/3d0117bb-f557-4b5a-9115-9fdf7b997113");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/d6303b2f-22d2-41f6-82c0-3fe5a0b3da82");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/1663b411-e794-45ef-adc1-cd3939b3195d");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/3d5340dd-cb9b-4248-94fb-91c1bb1107a4");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/e37d35ec-41f9-439f-9a29-414c6936c11f");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/f0dc147a-340a-4f9c-b00e-04861fb204dc");
            //NOTOCRecord radioActivesRecords = await GetNOTOCRecord(dataList);
            //notocrecords.Add(radioActivesRecords);

            //dataList.Clear();
            
            ////3

            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/984e1ded-46a2-4bed-91b6-ca2a9939e12d");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/c4db5369-f58f-419e-bb08-519ad9eec61b");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/a2476e32-9d7d-4d18-9d04-db1ef85879e0");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/1663b411-e794-45ef-adc1-cd3939b3195d");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/3d5340dd-cb9b-4248-94fb-91c1bb1107a4");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/e37d35ec-41f9-439f-9a29-414c6936c11f");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/113b2e7a-302a-476f-b0c3-bbd3c4dd840e");
            //radioActivesRecords = await GetNOTOCRecord(dataList);
            //notocrecords.Add(radioActivesRecords);

            dataList.Clear();

            

            //Live Animal
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/12bb0475-2508-4721-8ea2-0b37ea6260a0\r\n");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/5c8eda67-5c80-4519-bf52-debef331777f\r\n");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/d6bf3bd6-4ffb-416b-9d86-0dd8e2f98487\r\n");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/1663b411-e794-45ef-adc1-cd3939b3195d\r\n");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/3d5340dd-cb9b-4248-94fb-91c1bb1107a4\r\n");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/33ee51e8-d0ea-44dd-b060-48847dc4d5d1\r\n");
            //dataList.Add("https://iatahackathon-cargo.aircanada.com/logistics-objects/cddd08b3-7559-4f31-937e-7c62f453630b\r\n");
            //NOTOCRecord liveanimals = await GetNOTOCRecord(dataList);
            //notocrecords.Add(liveanimals);

            //dataList.Clear();

            if (notocrecords != null)
                return Ok(notocrecords);
            else
                return BadRequest("Unable to retrieve data.");           

        }

        private async Task<NOTOCRecord> GetNOTOCRecord(List<string> clientAddresses)
        {
            NOTOCRecord record = new NOTOCRecord();
            //Final destination
            var response = await _client.GetAsync(clientAddresses[0]);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<TransportLegs>(content);
                record.OffloadStation = data.ArrivalLocation;
                record.FinalDestination = data.ArrivalLocation;
                record.OriginStation = data.DepartureLocation;

                //ProductDG
                response = await _client.GetAsync(clientAddresses[1]);
                if (response.IsSuccessStatusCode)
                {
                    content = await response.Content.ReadAsStringAsync();
                    var productDg = JsonConvert.DeserializeObject<ProductDg>(content);
                    record.ProperShippingName = productDg.ProperShippingName.ToUpper();
                    record.UnNumber = productDg.UnNumber;
                    record.HazardClassificationId = productDg.HazardClassificationId;
                    record.AdditionalHazardClassificationId = productDg.AdditionalHazardClassificationId;
                    record.PackagingDangerLevelCode = productDg.PackagingDangerLevelCode;

                    //DgDeclaration
                    response = await _client.GetAsync(clientAddresses[2]);
                    if (response.IsSuccessStatusCode)
                    {
                        content = await response.Content.ReadAsStringAsync();
                        var declarationDG = JsonConvert.DeserializeObject<DgDeclaration>(content);
                        record.CargoAircraftOnly = declarationDG.AircraftLimitationInformation == "PASSENGER AND CARGO AIRCRAFT" ? false : true;


                        //Loading
                        response = await _client.GetAsync(clientAddresses[3]);
                        if (response.IsSuccessStatusCode)
                        {
                            content = await response.Content.ReadAsStringAsync();
                            var loading = JsonConvert.DeserializeObject<Loading>(content);
                            record.LocationOnAircraft = loading.LoadingPositionIdentifier;

                            //ULD
                            response = await _client.GetAsync(clientAddresses[4]);
                            if (response.IsSuccessStatusCode)
                            {
                                content = await response.Content.ReadAsStringAsync();
                                var uld = JsonConvert.DeserializeObject<ULD>(content);
                                record.ULDNumber = uld.UldSerialNumber;


                                //WayBill
                                response = await _client.GetAsync(clientAddresses[5]);
                                if (response.IsSuccessStatusCode)
                                {
                                    content = await response.Content.ReadAsStringAsync();
                                    var waybilldata = JsonConvert.DeserializeObject<Waybill>(content);
                                    record.AirWaybillNumber = waybilldata.WaybillPrefix + "-" + waybilldata.WaybillNumber;

                                    //DgProductRadioactive
                                    response = await _client.GetAsync(clientAddresses[6]);
                                    if (response.IsSuccessStatusCode)
                                    {
                                        content = await response.Content.ReadAsStringAsync();
                                        var dgProductRadioactive = JsonConvert.DeserializeObject<DgProductRadioactive>(content);
                                        record.TransportIndexNumericdpback = dgProductRadioactive.TransportIndexNumeric.Value;
                                        return record;
                                    }
                                }                                
                            }
                        }
                    }

                }

            }

            return null;
        }

    }
}
