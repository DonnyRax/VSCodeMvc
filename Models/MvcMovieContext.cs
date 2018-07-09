using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }

        public DbSet<MvcMovie.Models.Actor> Actor { get; set; }
    }
}