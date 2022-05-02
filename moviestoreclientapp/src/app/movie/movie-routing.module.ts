import { NgModule } from "@angular/core";
import{RouterModule,Routes} from '@angular/router';
import { MovieDetailComponent } from "./movie-detail/movie-detail.component";
import { MovieListComponent } from "./movie-list/movie-list.component";
import { AddMovieComponent } from "./add-movie/add-movie.component";

const routes: Routes=[

      {path:'list',component:MovieListComponent},

      {path:'add',component:AddMovieComponent},

      {path:'detail/:id',component:MovieDetailComponent}
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports:[RouterModule]
})

export class MovieRoutingModule{

}