import { Component, OnInit } from '@angular/core';
import { CarServiceService } from '../car-service.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-cars',
  templateUrl: './cars.component.html',
  styleUrls: ['./cars.component.css']
})
export class CarsComponent implements OnInit {
  SearchCar     
  constructor(private api:CarServiceService,
    private route:Router) {
      this.SearchCar=this.api.SearchResult
     }

  ngOnInit() {
  }
 
 
}
