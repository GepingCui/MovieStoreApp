import { Component, OnInit } from '@angular/core';
import { CastService } from '../cast.service';
import { Cast } from 'src/app/data/cast';

@Component({
  selector: 'app-list-cast',
  templateUrl: './list-cast.component.html',
  styleUrls: ['./list-cast.component.css'],
  providers:[CastService]
})
export class ListCastComponent implements OnInit {

  casts:Cast[]=[]

  constructor(private castService:CastService) { 
    this.showCastList()
  }

  ngOnInit(): void {
  }

  showCastList(){
    this.castService.getCast().subscribe((res)=>{
      this.casts=res;
    });
  }

}
