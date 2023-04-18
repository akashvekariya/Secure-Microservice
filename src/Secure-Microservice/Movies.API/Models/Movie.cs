namespace Movies.API.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public string Rating { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public string ImageUrl { get; set; } = null!;
    public string Owner { get; set; } = null!;
}
