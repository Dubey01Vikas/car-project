import { Component, OnInit } from '@angular/core';
import { CarServiceService } from '../car-service.service';
import{ActivatedRoute, Router} from '@angular/router';
import { EmailValidator } from '@angular/forms';
import { Console } from '@angular/core/src/console';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
    })
export class SignupComponent implements OnInit {

  UserId1:1;
  

 
  constructor(private serv :CarServiceService,
    private rout:Router) { }
      
  ngOnInit() {
  }
  Save(mail,pass){ 
    let ZoomCarUser1 ={
     userId:this.UserId1,
     password:pass,
     email:mail

    }
    this.serv.postCarUsers(ZoomCarUser1);
    this.rout.navigate(['/login']);
    
  }

}
