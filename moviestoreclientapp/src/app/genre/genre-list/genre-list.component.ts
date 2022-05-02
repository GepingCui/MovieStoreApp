import { Component, OnInit } from '@angular/core';
import { GenreService } from '../genre.service';
import { Genre } from 'src/app/data/genre';

@Component({
  selector: 'app-genre-list',
  templateUrl: './genre-list.component.html',
  styleUrls: ['./genre-list.component.css'],
  providers:[GenreService]
})
export class GenreListComponent implements OnInit {

  genres:Genre[]=[]

  constructor(private genreService:GenreService) { 
    this.showGenreList()
  }

  ngOnInit(): void {
  }

  showGenreList(){
    this.genreService.getGenre().subscribe((res)=>{
      this.genres=res;
    });

}
}
