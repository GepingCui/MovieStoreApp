using Microsoft.EntityFrameworkCore;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Infrastructure.Data;
using MovieStoreApp.Infrastructure.Repository;
using MovieStoreApp.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);


// code below this was written in configureservices method
#region ConfigureServices

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MovieContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MovieStore"));
});

// repository
builder.Services.AddScoped<IMovieRepositoryAsync, MovieRepositoryAsync>();
builder.Services.AddScoped<IMovieCastRepositoryAsync, MovieCastRepositoryAsync>();
builder.Services.AddScoped<ICastRepositoryAsync, CastRepositoryAsync>();
builder.Services.AddScoped<IGenreRepositoryAsync, GenreRepositoryAsync>();

//services
builder.Services.AddScoped<IMovieServiceAsync, MovieServiceAsync>();
builder.Services.AddScoped<IMovieCastService, MovieCastService>();
builder.Services.AddScoped<ICastServiceAsync, CastServiceAsync>();
builder.Services.AddScoped<IGenreServiceAsync, GenreServiceAsync>();
#endregion



// code below this was written in configure method and it will contain middleware
// and environment related code
#region Configure
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
#endregion