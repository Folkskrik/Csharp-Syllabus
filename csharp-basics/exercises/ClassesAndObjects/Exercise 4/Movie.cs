class Movie
{
    public string title;
    public string studio;
    public string rating;

    public Movie(string title, string studio, string rating)
    {
        this.title = title;
        this.studio = studio;
        this.rating = rating;
    }

    public Movie(string title, string studio) : this(title, studio, "PG")
    {
    }

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