import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Movie } from 'src/app/data/movie';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.css'],
  providers:[MovieService]
})
export class AddMovieComponent implements OnInit {

  movieValue:Movie={
    id:0,
    title:'',
    overview:'',
    tagline:'',
    imdbUrl:'',
    tmdbUrl:'',
    posterUrl:'',
    backdropUrl:'',
    originalLanguage:'',
    runTime:0
  }

  constructor(private movieService:MovieService) { }

  ngOnInit(): void {
  }

  addMovie(movieForm:NgForm){
    this.movieValue.id=0;
    this.movieValue.overview=movieForm.value.Overview
    this.movieValue.imdbUrl=movieForm.value.ImdbUrl
    this.movieValue.originalLanguage=movieForm.value.OriginalLanguage
    this.movieValue.tagline=movieForm.value.Tagline
    this.movieValue.posterUrl=movieForm.value.PosterUrl
    this.movieValue.runTime=movieForm.value.Runtime
    this.movieValue.tmdbUrl=movieForm.value.TmdbUrl
    this.movieValue.title=movieForm.value.Title
    this.movieValue.backdropUrl=movieForm.value.BackdropUrl

    this.movieService.addMovie(this.movieValue).subscribe((res)=>{
      alert("Movie has been added")
    },err=>{
      console.log(err)
    });
  }

  resetForm(movieForm:NgForm){
    movieForm.reset();
  }

}
