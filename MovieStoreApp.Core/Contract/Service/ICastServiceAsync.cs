using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Service
{
    public interface ICastServiceAsync
    {
        Task<int> AddCastAsync(CastModel model);
        Task<int> DeleteCastAsync(int Id);
        Task<int> UpdateCastAsync(CastModel model);

        Task<IEnumerable<CastModel>> GetAllCastAsync();
        Task<CastModel> GetCastAsync(int id);
    }
}
