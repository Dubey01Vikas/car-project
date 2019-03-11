import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from './home/home.component';
import {LoginComponent} from './login/login.component';
import { SignupComponent } from './signup/signup.component';
import {BookingComponent} from './booking/booking.component';
 import {CarDetailsComponent} from './car-details/car-details.component';
 import {FacilityComponent} from './facility/facility.component';
 import {CarsComponent} from './cars/cars.component';
 import {NotFoundComponent} from './not-found/not-found.component';
import { OrderDetailsComponent } from './order-details/order-details.component';
const routes: Routes = [
  {path:'home', component: HomeComponent},
   {path:'', redirectTo: '/home', pathMatch: 'full'},
   {path:'login',component:LoginComponent},
   {path:'signup',component :SignupComponent},
   {path:'booking/:id',component :BookingComponent},
   {path:'car',component : CarDetailsComponent},
   {path:'facility',component :FacilityComponent},
   {path:'hero',component:CarsComponent},
   {path:'order',component:OrderDetailsComponent},
   {path:'**',component:NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
