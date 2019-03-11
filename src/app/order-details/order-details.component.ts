import { Component, OnInit } from '@angular/core';
import { CarServiceService } from '../car-service.service';
import{ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-order-details',
  templateUrl: './order-details.component.html',
  styleUrls: ['./order-details.component.css']
})
export class OrderDetailsComponent implements OnInit {
 OrderDetails1;
 OrderItem
 orderid
  constructor(private api:CarServiceService, private _route:Router) { }

  ngOnInit() {
    this.OrderItem=this.api.getOrders();
    this.orderid=this.OrderItem-1;
    this.OrderItem=this.api.getOrderById(this.orderid);
  }
LogOut(){
  this.api.LoginUser1 ={};
  this._route.navigate([("/login")]);

}
}
