import { Component, OnInit } from '@angular/core';
import { CarServiceService } from '../car-service.service';
import {ActivatedRoute,Router} from '@angular/router';

@Component({
  selector: 'app-order-details-f',
  templateUrl: './order-details-f.component.html',
  styleUrls: ['./order-details-f.component.css']
})
export class OrderDetailsFComponent implements OnInit {
 orders={}
 orderDetails
  constructor(private api:CarServiceService,) {
   }

  ngOnInit() {
       this.api.getOrders().subscribe(res=>{
         this.orderDetails=res;
       });
  }

}
