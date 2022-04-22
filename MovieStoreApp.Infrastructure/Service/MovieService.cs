using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
using MovieStoreApp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
