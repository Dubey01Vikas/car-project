import { Component, OnInit } from '@angular/core';
import { CarServiceService } from '../car-service.service';
import {ActivatedRoute,Router} from '@angular/router';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent implements OnInit {
Name;
CarId;

  constructor(private api: CarServiceService,private _router : Router, private route: ActivatedRoute ) { }

  ngOnInit() {
    this.CarId = this.route.snapshot.params._id;
  }
  Book(){
    let Booking={
      ZoomCarUserId : this.api.LoginUser1.zoomCarUserId,
      CarId :this.CarId,
      Email :this.api.LoginUser1.email
    }
    this.api.postOrder(Booking);
    this._router.navigate(["/order"]);
    
  }

}
