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


        public async Task<int> AddGenreAsync(GenreModel model)
        {
            Genre c = new Genre();
            c.Name = model.Name;
            return await GRepository.InsertAsync(c);
        }

        public async Task<int> DeleteGenreAsync(int Id)
        {
            return await GRepository.DeleteAsync(Id);

        }

        public async Task<int> UpdateGenreAsync(GenreModel model)
        {
            Genre c = new Genre();
            c.Name = model.Name;

            await GRepository.DeleteAsync(model.Id);
            return await GRepository.InsertAsync(c);
        }


    }
}


      
            




