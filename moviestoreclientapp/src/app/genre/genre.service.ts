import { Injectable } from '@angular/core';
import {HttpClient}from '@angular/common/http'
import{Movie} from '../data/movie'
import{map}from 'rxjs/operators'
import { Genre } from '../data/genre';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private http:HttpClient) { 
    
  }

  addGenre(genre:Genre){
    return this.http.post<any>("https://localhost:44375/api/genre/add",genre).pipe(map ((res:any)=> {return res;} ));
  }
  getGenre(){
    return this.http.get<Genre[]>("https://localhost:44375/api/genre")
  }
}
