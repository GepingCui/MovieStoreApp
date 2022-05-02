using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Models;
namespace MovieStoreApp.Core.Contract.Service
{
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync();
        Task<IEnumerable<MovieResponseModel>> GetTop3LatestMoviesAsync();
        Task<MovieResponseModel> GetByIdAsync(int id);

        Task<int> AddMovieAsync(MovieResponseModel model);
        Task<int> DeleteMovieAsync(int Id);
        Task<int> UpdateMovieAsync(MovieResponseModel model);
    }
}
