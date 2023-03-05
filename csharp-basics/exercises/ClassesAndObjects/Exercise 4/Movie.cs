class Movie
{
    public string title;
    public string studio;
    public string rating;

    // Constructor 1
    public Movie(string title, string studio, string rating)
    {
        this.title = title;
        this.studio = studio;
        this.rating = rating;
    }

    // Constructor 2
    public Movie(string title, string studio) : this(title, studio, "PG")
    {
    }

    // Method GetPG
    public static Movie[] GetPG(Movie[] movies)
    {
        List<Movie> pgMovies = new List<Movie>();
        foreach (Movie movie in movies)
        {
            if (movie.rating == "PG")
            {
                pgMovies.Add(movie);
            }
        }
        return pgMovies.ToArray();
    }
}