import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Subject} from 'rxjs';
import { Observable} from 'rxjs'
@Injectable({
  providedIn: 'root'
})
export class CarServiceService {
SearchResult
LoginUser1;
  constructor(private http : HttpClient) { }
  getCarUserById(ZoomCarId){
    return this.http.get(`http://localhost:55560/api/User/${ZoomCarId}`);
         }
  getCarUsers(){
    return this.http.get('http://localhost:55560/api/ZoomCarUser');
        }
  getOrderById(OrderId){
    return this.http.get(`http://localhost:55560/api/Order/${OrderId}`);
        }
  getOrders(){
    return this.http.get('http://localhost:55560/api/Order');
     }
  getCarById(CarId){
    return this.http.get(`http://localhost:55560/api/CarPlace/${CarId}`);
       }
  getCars(){
    return this.http.get('http://localhost:55560/api/CarPlace');
         }
  
         SearchByCompanyName(Cname){
           this.http.get(`http://localhost:55560/api/Search/${Cname}`);
         }
    //      postOrders(Order){
    // this.http.post('http://localhost:55560/api/Order',Order).subscribe(res => {
    // console.log(res)
    // })
    // }
    postCarUsers(ZoomCarUser){
      this.http.post('http://localhost:55560/api/ZoomCarUser',ZoomCarUser).subscribe(res => {
      console.log(res)
      })
      }
    postOrder(OrderDetails){
      this.http.post('http://localhost:55560/api/Order',OrderDetails).subscribe(res => {
        console.log(res)
        })
    }

    putZoomCarUser(ZoomCar) {
      this.http.put(`http://localhost:55560/api/ZoomCarUser/${ZoomCar.id}`, ZoomCar).subscribe(res => {
      console.log(res)
      })
      }
      putCarDetails(CarStatus){
        this.http.put(`http://localhost:55560/api/CarPlace/${CarStatus.id}`,CarStatus);
      }
      deleteOrderby(OrderId){
        this.http.delete(`http://localhost:55560/api/Order/${OrderId}`).subscribe(
          res => {
            console.log(res)
                })
      }
      SearchByCompany(CompanyName){
        return this.http.get(`http://localhost:55560/api/CarPlace`);
          }
    
      }
     
     

