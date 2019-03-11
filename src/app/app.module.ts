import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule,ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { SignupComponent } from './signup/signup.component';
import { LoginComponent } from './login/login.component';
import {HttpClientModule} from '@angular/common/http';
import {NgForm} from '@angular/forms';
import { CarDetailsComponent } from './car-details/car-details.component';
import { OrderDetailsFComponent } from './order-details-f/order-details-f.component';
import { BookingComponent } from './booking/booking.component';
import { CarsComponent } from './cars/cars.component';
import { OrderDetailsComponent } from './order-details/order-details.component';
import { FacilityComponent } from './facility/facility.component';
import { NotFoundComponent } from './not-found/not-found.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SignupComponent,
    LoginComponent,
    CarDetailsComponent,
    OrderDetailsFComponent,
    BookingComponent,
    CarsComponent,
    OrderDetailsComponent,
    FacilityComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
