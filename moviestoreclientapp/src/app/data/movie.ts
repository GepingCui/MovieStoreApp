import { DecimalPipe } from "@angular/common";

export interface Movie{
    id:number,
    title:string,
    overview:string,
    tagline:string,
    imdbUrl:string,
    tmdbUrl:string,
    posterUrl:string,
    backdropUrl:string,
    originalLanguage:string,
    runTime:number

}