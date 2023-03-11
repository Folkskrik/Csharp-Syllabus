using System;

class Movie
{
    private string _title;
    private string _studio;
    public string Rating;

    public Movie(string title, string studio, string rating)
    {
        _title = title;
        _studio = studio;
        Rating = rating;
    }

    public Movie(string title, string studio) : this(title, studio, "PG")
    {
    }

    public static Movie[] GetPG(Movie[] movies)
    {
        List<Movie> pgMovies = new List<Movie>();
        foreach (Movie movie in movies)
        {
            if (movie.Rating == "PG")
            {
                pgMovies.Add(movie);
            }
        }
        return pgMovies.ToArray();
    }

    public override string ToString() 
    {
        return "Title: " + _title + ", Studio: " + _studio + ", Rating: " + Rating;
    }
}