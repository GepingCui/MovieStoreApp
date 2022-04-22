using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;
namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IMovieRepositoryAsync : IRepositoryAsync<Movie>
    {
        Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync();
        Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync();
    }
}
