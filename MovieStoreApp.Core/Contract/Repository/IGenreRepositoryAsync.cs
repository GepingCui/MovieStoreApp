using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;
namespace MovieStoreApp.Core.Contract.Repository
{
    public interface IGenreRepositoryAsync : IRepositoryAsync<Genre>
    {
        Task<IEnumerable<Movie>> GetAllByGenreAsync(int GenreId);

        Task<Genre> GetGenreName(int GenreId);
    }
}