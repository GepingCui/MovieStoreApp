using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Service
{
    public interface IMovieCastService
    {
        Task<IEnumerable<MovieCastModel>> GetAllByMovieId(int id);

        Task<IEnumerable<MovieCastModel>> GetAllByCastId(int id);

    }
}
