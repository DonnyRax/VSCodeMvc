using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MvcMovie.Models
{
public class MvcMovieContextDbFactory : IDesignTimeDbContextFactory<MvcMovieContext>
    {
        MvcMovieContext IDesignTimeDbContextFactory<MvcMovieContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MvcMovieContext>();
            optionsBuilder.UseSqlite("Data Source=MvcMovie.db");

            return new MvcMovieContext(optionsBuilder.Options);
        }
    }
}