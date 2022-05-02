import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddGenreComponent } from './genre/add-genre/add-genre.component';
import { GenreListComponent } from './genre/genre-list/genre-list.component';
import { ListCastComponent } from './cast/list-cast/list-cast.component';
import { AddCastComponent } from './cast/add-cast/add-cast.component';
import { MovieListComponent } from './movie/movie-list/movie-list.component';
import { AddMovieComponent } from './movie/add-movie/add-movie.component';
import { MovieDetailComponent } from './movie/movie-detail/movie-detail.component';
import { CastDetailComponent } from './cast/cast-detail/cast-detail.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { MovieRoutingModule} from './movie/movie-routing.module';
import { CastRoutingModule} from './cast/cast-routing.module';
import { GenreRoutingModule } from './genre/genre-routing.module';
import { AdminRouteGuard } from './guards/admin-route.guard';


const routes: Routes = [
  
    {path:'movie',
    canActivate: [AdminRouteGuard],
    loadChildren:()=>import('./movie/movie.module').then(m=>m.MovieModule)},
    
    {path:'cast',loadChildren:()=>import('./cast/cast.module').then(m=>m.CastModule)},

    {path:'genre',loadChildren:()=>import('./genre/genre.module').then(m=>m.GenreModule)},
      
      {
        path:'',
        redirectTo:'movie/list',
        pathMatch:'full'
      },
      {
        path:'home',
        redirectTo:'movie/list',
        pathMatch:'full'
      },
      {
        path:'index',
        redirectTo:'movie/list',
        pathMatch:'full'
      },
      {
        path:'**',
        component:PageNotFoundComponent
      }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
