using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Contract.Repository;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>,ICastRepositoryAsync
    {
        public CastRepositoryAsync(MovieContext _db) : base(_db)
        {
        }
    }
}
