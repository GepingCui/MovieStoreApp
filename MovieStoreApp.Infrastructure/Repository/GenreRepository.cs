using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class GenreRepositoryAsync : BaseRepositoryAsync<Genre>, IGenreRepositoryAsync
    {
        MovieContext context;
        public GenreRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }
        public async Task<IEnumerable<Movie>> GetAllByGenreAsync(int Id)
        {
            return await context.Movie.Where(x => (((x.Runtime) % 20) + 1) == Id).Take(10).ToListAsync();
        }

        public async Task<Genre> GetGenreName(int Id)
        {
            return await context.Genre.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }
    }
}

