import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http'
import{Genre} from '../data/genre'
import{map}from 'rxjs/operators'
import { Movie } from '../data/movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private http:HttpClient) { 
    
  }

  addMovie(movie:Movie){
    return this.http.post<any>("https://localhost:44375/api/movie/add",movie).pipe(map ((res:any)=> {return res;} ));
  }
  getMovie(){
    return this.http.get<Movie[]>("https://localhost:44375/api/movie")
  }
}
