using System;

class Program
{
    static void Main(string[] args)
    {
        Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG-13");
        Movie movie2 = new Movie("Glass", "Buena Vista International", "PG-13");
        Movie movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");

        Movie[] movies = new Movie[] { movie1, movie2, movie3 };

        Movie[] pgMovies = Movie.GetPG(movies);
        foreach (Movie movie in pgMovies)
        {
            Console.WriteLine(movie);
        }
    }
}