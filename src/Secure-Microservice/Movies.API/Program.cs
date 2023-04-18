using Microsoft.EntityFrameworkCore;
using Movies.API.Data;
using Movies.API.Seed;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MoviesContext>(options =>
    options.UseInMemoryDatabase("MoviesDb"));

var app = builder.Build();

// =========== Seed Database ============

SeedDatabase(app);

static void SeedDatabase(IHost host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;
    var moviesContext = services.GetRequiredService<MoviesContext>();
    MoviesContextSeed.SeedData(moviesContext);
}

// ======================================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
