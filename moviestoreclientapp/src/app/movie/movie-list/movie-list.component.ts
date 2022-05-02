import { Component, OnInit } from '@angular/core';
import { MovieService } from '../movie.service';
import { Movie } from 'src/app/data/movie';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css'],
  providers:[MovieService]
})
export class MovieListComponent implements OnInit {

  movies:Movie[]=[]

  constructor(private movieService:MovieService) { 
    this.showMovieList()
  }

  ngOnInit(): void {
  }

  showMovieList(){
    this.movieService.getMovie().subscribe((res)=>{
      this.movies=res;
    });

}
}
