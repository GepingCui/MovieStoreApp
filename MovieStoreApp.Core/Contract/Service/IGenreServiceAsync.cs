﻿using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Service
{
    public interface IGenreServiceAsync
    {
        Task<IEnumerable<MovieResponseModel>> GetAllByGenre(int Id);

        Task<string> GetGenreName(int Id);
    }
}
