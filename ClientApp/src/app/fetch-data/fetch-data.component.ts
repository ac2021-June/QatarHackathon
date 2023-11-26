import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
    styleUrls: ['./fetch-data.component.css'],

})
export class FetchDataComponent {
  public notocrecords: NOTOCRecord[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<NOTOCRecord[]>(baseUrl + 'notocrecord').subscribe(result => {
      this.notocrecords = result;
    }, error => console.error(error));
  }
}


interface NOTOCRecord {
  "itemNumber": number;
  "uldNumber": string;
  "properShippingName": string;
  "originStation": string;
  "offloadStation": string;
  "finalDestination": string;
  "airWaybillNumber": string;
  "hazardClassificationId": string;
  "unNumber": string;
  "additionalHazardClassificationId": string;
  "minimumQuantityPerShipment": number;
  "transportIndexNumericdpback": number;
  "unitOfMeasure": string;
  "numberOfPackages": number;
  "packagingDangerLevelCode": string;
  "dgRaTypeCode": string;
  "cargoAircraftOnly": boolean;
  "cargoIMPCode": string;
  "locationOnAircraft": string;
  "temperatureRequirement": string;
  "stateExemption": string;
  "remarks": string;
  "loadingPersonnelSignature": string;
  "captainSignature": string;
}

