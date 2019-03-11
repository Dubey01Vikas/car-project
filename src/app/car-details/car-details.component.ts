import { Component, OnInit } from '@angular/core';
import { CarServiceService } from '../car-service.service';
import {ActivatedRoute,Router} from '@angular/router';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.css']
})
export class CarDetailsComponent implements OnInit {
  private _id:number;
  
  Cars ={}
  CarsDetail;
  constructor(private api: CarServiceService,private _route:ActivatedRoute ,private _router:Router) { }

  ngOnInit() {
    this._id=+this._route.paramMap.subscribe(params=>{this._id=+params.get('id');
     this.api.getCarById(this._id).subscribe(res=>{this.CarsDetail=res;});
                    })
    this.api.getCars().subscribe(res =>{
          this.CarsDetail=res;
           console.log(this.CarsDetail);
           
                 })

    }
    booking(CarPlace){
      this.api.putCarDetails(CarPlace);
      this._router.navigate(['/booking/'+CarPlace.carId]);
      
    }

}
