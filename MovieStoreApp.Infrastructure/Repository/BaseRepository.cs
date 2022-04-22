using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        MovieContext db;
        public BaseRepositoryAsync(MovieContext _db)
        {
            db = _db;
        }
        public async Task<int> DeleteAsync(int id)
        {
            var entity = await db.Set<T>().FindAsync(id); // db.Set<T>().Where(x=>x.Id==id).FirstOrDefault();
            if (entity != null)
            {

                db.Set<T>().Remove(entity);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public async Task<T> GetAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }

        public async Task<int> InsertAsync(T entity)
        {
            await db.Set<T>().AddAsync(entity);
             db.SaveChanges();//commit
            return 1;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            db.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await db.SaveChangesAsync();
            return 1;
        }
    }
}
