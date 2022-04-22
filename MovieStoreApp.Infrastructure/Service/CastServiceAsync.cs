using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MovieStoreApp.Infrastructure.Service
{
    public class CastServiceAsync:ICastServiceAsync
    {
        ICastRepositoryAsync castRepositoryAsync;
        public CastServiceAsync(ICastRepositoryAsync _castRepositoryAsync)
        {
            castRepositoryAsync = _castRepositoryAsync;
        }

        public async Task<int> AddCastAsync(CastModel model)
        {
            Cast c = new Cast();
            c.Name = model.Name;
            c.TmdbUrl = model.TmdbUrl;
            c.ProfilePath=model.ProfilePath;
            c.Gender=model.Gender;
          return await  castRepositoryAsync.InsertAsync(c);
        }

        public async Task<int> DeleteCastAsync(CastModel model)
        {
            return await castRepositoryAsync.DeleteAsync(model.Id);

        }

        public async Task<int> UpdateCastAsync(CastModel model)
        {
            Cast c = new Cast();
            c.Name = model.Name;
            c.TmdbUrl = model.TmdbUrl;
            c.ProfilePath = model.ProfilePath;
            c.Gender = model.Gender;
            await castRepositoryAsync.DeleteAsync(model.Id);
            return await castRepositoryAsync.InsertAsync(c);
        }

        public async Task<IEnumerable<CastModel>> GetAllCastAsync()
        {
            var result = await castRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                List<CastModel> list = new List<CastModel>();
                foreach (var item in result)
                {
                    CastModel model = new CastModel();
                    model.Id= item.Id;
                    model.Name  = item.Name;
                    model.TmdbUrl= item.TmdbUrl;
                    model.ProfilePath= item.ProfilePath;
                    model.Gender= item.Gender;
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public async Task<CastModel> GetCastAsync(int id)
        {
            var item = await castRepositoryAsync.GetAsync(id);
            if (item != null)
            {
                CastModel model = new CastModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.TmdbUrl = item.TmdbUrl;
                model.ProfilePath = item.ProfilePath;
                model.Gender = item.Gender;
                return model;
            }
            return null;
        }
    }
}
