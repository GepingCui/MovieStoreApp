import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Genre } from 'src/app/data/genre';
import { GenreService } from '../genre.service';

@Component({
  selector: 'app-add-genre',
  templateUrl: './add-genre.component.html',
  styleUrls: ['./add-genre.component.css'],
  providers:[GenreService]
})
export class AddGenreComponent implements OnInit {

  genreName:string=''

  genreValue:Genre={
    id:0,
    name:'',
  }

  constructor(private genreService:GenreService) { }

  ngOnInit(): void {
  }

  saveGenre(genreForm: NgForm){
    console.log(genreForm.value)
  }

  addGenre(genreForm:NgForm){
    this.genreValue.id=0;
    this.genreValue.name=genreForm.value.name
    this.genreService.addGenre(this.genreValue).subscribe((res)=>{
      alert("Genre has been added")
    },err=>{
      console.log(err)
    });
  }

  resetForm(genreForm:NgForm){
    genreForm.reset();
  }


}
