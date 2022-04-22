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
    public class GenreServiceAsync : IGenreServiceAsync
    {
        IGenreRepositoryAsync GRepository;
        public GenreServiceAsync(IGenreRepositoryAsync _genre)
        {
            GRepository = _genre;
        }


        public async Task<string> GetGenreName(int Id)
        {
            var result=await GRepository.GetGenreName(Id);
            return result.Name;
        }

        public async Task<IEnumerable<MovieResponseModel>> GetAllByGenre(int Id)
        {
            var result = await GRepository.GetAllByGenreAsync(Id);
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


      
            




