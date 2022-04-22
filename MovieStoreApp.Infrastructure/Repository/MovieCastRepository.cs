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
    public class MovieCastRepositoryAsync : BaseRepositoryAsync<MovieCast>, IMovieCastRepositoryAsync
    {
        MovieContext context;
        public MovieCastRepositoryAsync(MovieContext _db) : base(_db)
        {
            context = _db;
        }
        public async Task<IEnumerable<MovieCast>> GetAllByMovieIdAsync(int movieId)
        {
           return await context.MovieCast.Include("Cast").Where(x => x.MovieId == movieId).ToListAsync();
        }

        public async Task<IEnumerable<MovieCast>> GetAllByCastIdAsync(int castId)
        {
            return await context.MovieCast.Include("Movie").Where(x => x.CastId == castId).ToListAsync();
        }

    }
}
