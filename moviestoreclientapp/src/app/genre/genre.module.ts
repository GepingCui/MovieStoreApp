import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GenreListComponent } from './genre-list/genre-list.component';
import { AddGenreComponent } from './add-genre/add-genre.component';
import { GenreRoutingModule } from './genre-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    GenreListComponent,
    AddGenreComponent
  ],
  imports: [
    CommonModule,
    GenreRoutingModule,
    FormsModule
  ]
})
export class GenreModule { }
