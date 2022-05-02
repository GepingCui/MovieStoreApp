import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MovieListComponent } from './movie-list/movie-list.component';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { MovieDetailComponent } from './movie-detail/movie-detail.component';
import { MovieRoutingModule } from './movie-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    MovieListComponent,
    AddMovieComponent,
    MovieDetailComponent
  ],
  imports: [
    CommonModule,
    MovieRoutingModule,
    FormsModule
  ]
})
export class MovieModule { }
