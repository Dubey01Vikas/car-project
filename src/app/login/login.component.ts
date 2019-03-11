import { Component, OnInit } from '@angular/core';
// import { NgForm} from '@angular/forms';
import { CarServiceService } from '../car-service.service';
import {ActivatedRoute,Router} from '@angular/router';
import { forEach } from '@angular/router/src/utils/collection';
import { UseExistingWebDriver } from 'protractor/built/driverProviders';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
 users;
 abc=3;
 Status1=false;
  constructor(private api:CarServiceService, private _router :Router) { }

  ngOnInit() {
      
      this.api.getCarUsers().subscribe( res =>{
        this.users=res;
      });
    }
  
  login(email,pass){
    console.log(email);
    console.log(pass);
    this.users.forEach(user => {
      if(user.email==email && user.password==pass)
      {
        this.api.LoginUser1=user;
        this._router.navigate(['/car']);
  
      }else{
        this.Status1=true;
      }
    }) 
  }
}



