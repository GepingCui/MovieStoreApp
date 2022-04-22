using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;
namespace MovieStoreApp.Infrastructure.Data
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> option):base(option)
        {

        }

        public DbSet<Cast> Cast { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }

        public DbSet<User> Users { get;set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
