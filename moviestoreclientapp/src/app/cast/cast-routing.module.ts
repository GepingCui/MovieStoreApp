import { NgModule } from "@angular/core";
import{RouterModule,Routes} from '@angular/router';
import { CastDetailComponent } from "./cast-detail/cast-detail.component";
import { AddCastComponent } from "./add-cast/add-cast.component";
import { ListCastComponent } from "./list-cast/list-cast.component";

const routes: Routes=[
    {path:'add',component:AddCastComponent},

    {path:'list',component:ListCastComponent},
      
    {path:'detail/:id',component:CastDetailComponent}
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports:[RouterModule]
})

export class CastRoutingModule{
    
}