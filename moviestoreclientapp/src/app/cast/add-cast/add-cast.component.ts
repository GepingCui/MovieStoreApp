import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Cast } from 'src/app/data/cast';
import { CastService } from '../cast.service';

@Component({
  selector: 'app-add-cast',
  templateUrl: './add-cast.component.html',
  styleUrls: ['./add-cast.component.css'],
  providers:[CastService]
})
export class AddCastComponent implements OnInit {

  castValue:Cast={
    id:0,
    gender:1,
    name:'',
    profilePath:'',
    tmdbUrl:''
  }

  constructor(private castService:CastService) { }

  ngOnInit(): void {
  }

  addCast(castForm:NgForm){
    this.castValue.id=0;
    this.castValue.gender=castForm.value.gender
    this.castValue.name=castForm.value.name
    this.castValue.tmdbUrl=castForm.value.tmdbUrl
    this.castValue.profilePath=castForm.value.profilePath
    this.castService.addCast(this.castValue).subscribe((res)=>{
      alert("Cast has been added")
    },err=>{
      console.log(err)
    });
  }

  resetForm(castForm:NgForm){
    castForm.reset();
  }

}
