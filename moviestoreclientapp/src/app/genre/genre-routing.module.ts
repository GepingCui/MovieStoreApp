import { NgModule } from "@angular/core";
import{Router,RouterModule,Routes} from '@angular/router';
import { GenreListComponent } from "./genre-list/genre-list.component";
import { AddGenreComponent } from "./add-genre/add-genre.component";

const routes: Routes=[

    {path:'add',component:AddGenreComponent},

    {path:'list',component:GenreListComponent}
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports:[RouterModule]
})

export class GenreRoutingModule{
    
}