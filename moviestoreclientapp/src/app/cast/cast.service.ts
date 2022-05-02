import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http'
import{Cast} from '../data/cast'
import{map}from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})
export class CastService {

  constructor(private http:HttpClient) { 
    
  }

  addCast(cast:Cast){
    return this.http.post<any>("https://localhost:44375/api/cast/add",cast).pipe(map ((res:any)=> {return res;} ));
  }

  getCast(){
    return this.http.get<Cast[]>("https://localhost:44375/api/cast")
  }
}
