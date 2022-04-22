using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
namespace MovieStoreApp.Infrastructure.Service
{
    public class MovieCastService : IMovieCastService
    {
        IMovieCastRepositoryAsync movieCastRepository;
        public MovieCastService(IMovieCastRepositoryAsync _movie)
        {
            movieCastRepository = _movie;
        }
        public async Task<IEnumerable<MovieCastModel>> GetAllByMovieId(int id)
        {
            var result = await movieCastRepository.GetAllByMovieIdAsync(id);
            List<MovieCastModel> lstModel = new List<MovieCastModel>();
            foreach (var entity in result)
            {
                MovieCastModel model = new MovieCastModel();
                model.CastId = entity.CastId;
                model.Id = entity.Id;
                model.Cast = new CastModel()
                {
                    Id = entity.Cast.Id,
                    Gender = entity.Cast.Gender,
                    Name = entity.Cast.Name,
                    ProfilePath = entity.Cast.ProfilePath,
                    TmdbUrl = entity.Cast.TmdbUrl
                };
                lstModel.Add(model);
            }
            return lstModel;
        }


        public async Task<IEnumerable<MovieCastModel>> GetAllByCastId(int id)
        {
            var result = await movieCastRepository.GetAllByCastIdAsync(id);
            List<MovieCastModel> lstModel = new List<MovieCastModel>();
            foreach (var entity in result)
            {
                MovieCastModel model = new MovieCastModel();

                model.MovieId = entity.MovieId;
                model.Id = entity.Id;
                model.Movie = new MovieResponseModel()
                {
                    Id=entity.Movie.Id,
                    Title= entity.Movie.Title,
                    Overview = entity.Movie.Overview,
                    Tagline = entity.Movie.Tagline,
                    Budget = entity.Movie.Budget,
                    Revenue = entity.Movie.Revenue,
                    ImdbUrl = entity.Movie.ImdbUrl,
                    TmdbUrl = entity.Movie.TmdbUrl,
                    PosterUrl = entity.Movie.PosterUrl,
                    BackdropUrl = entity.Movie.BackdropUrl,
                    OriginalLanguage = entity.Movie.OriginalLanguage,
                    ReleaseDate = entity.Movie.ReleaseDate,
                    Runtime = entity.Movie.Runtime,
                    Price = entity.Movie.Price
                };

                lstModel.Add(model);
            }
            return lstModel;
        }
    }
}
