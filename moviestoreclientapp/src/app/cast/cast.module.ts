import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddCastComponent } from './add-cast/add-cast.component';
import { ListCastComponent } from './list-cast/list-cast.component';
import { CastDetailComponent } from './cast-detail/cast-detail.component';
import { CastRoutingModule } from './cast-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    AddCastComponent,
    ListCastComponent,
    CastDetailComponent,
  ],
  imports: [
    CommonModule,
    CastRoutingModule,
    FormsModule
  ]
})
export class CastModule { }
