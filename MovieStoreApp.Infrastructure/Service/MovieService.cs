using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;
using MovieStoreApp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MovieStoreApp.Infrastructure.Service
{
    public class MovieServiceAsync : IMovieServiceAsync
    {
        IMovieRepositoryAsync movieRepository;
        public MovieServiceAsync(IMovieRepositoryAsync _m)
        {
           movieRepository = _m;
        }

        public async Task<MovieResponseModel> GetByIdAsync(int id)
        {
            MovieResponseModel model = new MovieResponseModel();
            var movie =await movieRepository.GetAsync(id);
            if (movie != null)
            {
                model.Id = movie.Id;
                model.Overview = movie.Overview;
                model.ImdbUrl = movie.ImdbUrl;
                model.OriginalLanguage = movie.OriginalLanguage;
                model.Tagline = movie.Tagline;
                model.PosterUrl = movie.PosterUrl;
                model.Price = movie.Price;
                model.ReleaseDate = movie.ReleaseDate;
                model.Revenue = movie.Revenue;
                model.Runtime = movie.Runtime;
                model.TmdbUrl = movie.TmdbUrl;
                model.Title = movie.Title;
                model.Budget = movie.Budget;
                
            }
            return model;
        }
        public async Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync()
        {
            var result =await movieRepository.GetTop10RevenueMoviesAsync();
            List<MovieResponseModel> lstMovieResponse = new List<MovieResponseModel>();
            foreach (var movie in result)
            {
                MovieResponseModel model = new MovieResponseModel();
                model.Id = movie.Id;
                model.Overview = movie.Overview;
                model.ImdbUrl = movie.ImdbUrl;
                model.OriginalLanguage = movie.OriginalLanguage;
                model.Tagline = movie.Tagline;
                model.PosterUrl = movie.PosterUrl;
                model.Price=    movie.Price;
                model.ReleaseDate = movie.ReleaseDate;
                model.Revenue = movie.Revenue;
                model.Runtime = movie.Runtime;
                model.TmdbUrl = movie.TmdbUrl;
                model.Title= movie.Title;
                model.Budget= movie.Budget;
                lstMovieResponse.Add(model);
            }
            return lstMovieResponse;
        }

        public async Task<IEnumerable<MovieResponseModel>> GetTop3LatestMoviesAsync()
        {
            var result = await movieRepository.GetTop3LatestMoviesAsync();
            List<MovieResponseModel> lstMovieResponse = new List<MovieResponseModel>();
            foreach (var movie in result)
            {
                MovieResponseModel model = new MovieResponseModel();
                model.Id = movie.Id;
                model.Overview = movie.Overview;
                model.ImdbUrl = movie.ImdbUrl;
                model.OriginalLanguage = movie.OriginalLanguage;
                model.Tagline = movie.Tagline;
                model.PosterUrl = movie.PosterUrl;
                model.Price = movie.Price;
                model.ReleaseDate = movie.ReleaseDate;
                model.Revenue = movie.Revenue;
                model.Runtime = movie.Runtime;
                model.TmdbUrl = movie.TmdbUrl;
                model.Title = movie.Title;
                model.Budget = movie.Budget;
                lstMovieResponse.Add(model);
            }
            return lstMovieResponse;
        }


        public async Task<int> AddMovieAsync(MovieResponseModel model)
        {
            Movie c = new Movie();
            c.Title = model.Title;
            c.Overview = model.Overview;
            c.Tagline = model.Tagline;
            c.Budget = model.Budget;
            c.Revenue = model.Revenue;
            c.ImdbUrl = model.ImdbUrl;
            c.TmdbUrl = model.TmdbUrl;
            c.PosterUrl = model.PosterUrl;
            c.BackdropUrl = model.BackdropUrl;
            c.OriginalLanguage = model.OriginalLanguage;
            c.ReleaseDate = model.ReleaseDate;
            c.Runtime = model.Runtime;
            c.Price = model.Price;

            return await movieRepository.InsertAsync(c);
        }

        public async Task<int> DeleteMovieAsync(int Id)
        {
            return await movieRepository.DeleteAsync(Id);

        }

        public async Task<int> UpdateMovieAsync(MovieResponseModel model)
        {
            Movie c = new Movie();
            c.Title = model.Title;
            c.Overview = model.Overview;
            c.Tagline = model.Tagline;
            c.Budget = model.Budget;
            c.Revenue = model.Revenue;
            c.ImdbUrl = model.ImdbUrl;
            c.TmdbUrl = model.TmdbUrl;
            c.PosterUrl = model.PosterUrl;
            c.BackdropUrl = model.BackdropUrl;
            c.OriginalLanguage = model.OriginalLanguage;
            c.ReleaseDate = model.ReleaseDate;
            c.Runtime = model.Runtime;
            c.Price = model.Price;

            await movieRepository.DeleteAsync(model.Id);
            return await movieRepository.InsertAsync(c);
        }
    }
}
