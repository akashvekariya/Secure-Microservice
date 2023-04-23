using Microsoft.EntityFrameworkCore;
using Movies.Client.Models;

namespace Movies.Client.Data;

public class MoviesContext : DbContext
{
    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options) { }

    public DbSet<Movie> Movie { get; set; } = default!;
}
