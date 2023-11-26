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
  public iataonerecords: IATAOneRecord[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<IATAOneRecord[]>(baseUrl + 'iataonerecord').subscribe(result => {
      this.iataonerecords = result;
    }, error => console.error(error));
  }
}

 interface HttpsOnerecordIataOrgNsApiHasDataOwner {
  "id": string;
  "type": string;
  "httpsonerecordiataorgnscargoname": string;
}

 interface IATAOneRecord {
  "id": string;
  "type": string;
  "httpsonerecordiataorgnsapihasDataOwner": HttpsOnerecordIataOrgNsApiHasDataOwner;
  "httpsonerecordiataorgnsapihasServerEndpoint": string;
  "httpsonerecordiataorgnsapihasSupportedContentType": string[];
  "httpsonerecordiataorgnsapihasSupportedLanguage": string;
  "httpsonerecordiataorgnsapihasSupportedLogisticsObjectType": string[];
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
