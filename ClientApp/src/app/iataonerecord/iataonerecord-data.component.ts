//import { Component, Inject } from '@angular/core';
//import { HttpClient } from '@angular/common/http';
//import {
//  CdkDragDrop,
//  CdkDrag,
//  CdkDropList,
//  CdkDropListGroup,
//  moveItemInArray,
//  transferArrayItem,
//} from '@angular/cdk/drag-drop';


import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-iataonerecord-data',
  templateUrl: './iataonerecord-data.component.html',
  styleUrls: ['./iataonerecord-data.component.css'],

 /* styleUrls: ['./dragndrop-data.component.css'],*/

})
export class IATAOneRecordDataComponent {
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


//export class DragndropDataComponent {
//  todo = ['Get to work', 'Pick up groceries', 'Go home', 'Fall asleep'];

//  done = ['Get up', 'Brush teeth', 'Take a shower', 'Check e-mail', 'Walk dog'];

//  drop(event: CdkDragDrop<string[]>) {
//    if (event.previousContainer === event.container) {
//      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
//    } else {
//      transferArrayItem(
//        event.previousContainer.data,
//        event.container.data,
//        event.previousIndex,
//        event.currentIndex,
//      );
//    }
//  }
//}
