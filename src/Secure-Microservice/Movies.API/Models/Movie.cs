namespace Movies.API.Models;

public class Movie
{
    // It means that the Title and Genre properties cannot be null, and the
    // compiler will not generate any warnings or errors if these properties are
    // accessed without being checked for null. In other words, it tells the
    // compiler to assume that the properties always have a value and to skip null checks.

    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public string Owner { get; set; } = null!;
}
