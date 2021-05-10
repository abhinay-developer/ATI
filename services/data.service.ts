import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  baseURL:string="https://localhost:44373/api/";

  constructor(private http:HttpClient) {


   }

   /***GET ALL STUDENTS */
   public getAllStudents(){
  //  return this.http.get(this.baseURL+'GetAllStudents');
     return this.http.get(this.baseURL+'GetAllStudents');

   }

  }
