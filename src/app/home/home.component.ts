import { Component, OnInit } from '@angular/core';
import { CarServiceService } from '../car-service.service';
import {ActivatedRoute,Router} from '@angular/router';

@Component({
  selector:'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  Name
    Search={}
    SearchDetails
  constructor(private api:CarServiceService,private routed:ActivatedRoute,private _route:Router) { }

  ngOnInit() {
    
      
  }
  ShowCar(companyn){
   this.api.SearchByCompany(companyn).subscribe(res=>{
    this.SearchDetails=res;
    console.log(this.SearchDetails);
      this.api.SearchResult=res;
      this._route.navigateByUrl("/hero");
   });


  }

}
