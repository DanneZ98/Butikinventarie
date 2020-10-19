using System;
using System.Collections.Generic;

namespace MusikButik
{
    class Movie
    {
        // Fält
        public string name;
        public string creator;
        public float rating;
        public int releaseDate;
        public string duration;
        public int price;

        // Konstruktor
        public Movie(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price)
        {
            name = _name;
            creator = _creator;
            rating = _rating;
            releaseDate = _releaseDate;
            duration = _duration;
            price = _price;
        }

        // Metod som skriver ut alla filmer i listan som skickas med när man kallar på metoden
        public static void Print(List<Movie> list)
        {
            // Variabler för presentation av filmerna
            string movieName = "Title";
            string movieDirector = "Director";
            string movieRating = "Rating";
            string movieRelease = "Release";
            string movieDuration = "Duration";
            string moviePrice = "Price";

            Console.WriteLine();
            Console.WriteLine("Movies");
            Console.WriteLine("-------");
            // Paddar strängarna så att allting ligger symmetriskt när det skrivs ut på skärmen
            Console.WriteLine($"{movieName.PadRight(50)} {movieDirector.PadRight(30)} {movieRating}   {movieRelease}↓  {movieDuration.PadRight(10)} {moviePrice}");
            list.Sort(new MovieComparer());
            // Foreach loop for att skriva ut varje film i listan
            foreach (var movie in list)
            {
                Console.WriteLine($"{movie.name.PadRight(50)} {movie.creator.PadRight(30)} {movie.rating}      {movie.releaseDate}      {movie.duration.PadRight(10)} {movie.price}");
            }
        }

        public static List<Movie> GetMovies()
        {
            // Lista med filmer
            List<Movie> moviesList = new List<Movie>
            {
                new Movie("Parasite", "Bong Joon Ho", 8.6f, 2019, "2h 12min", 100),
                new Movie("Knives Out", "Rian Johnson", 7.9f, 2019, "2h 10min", 100),
                new Movie("Joker", "Todd Phillips", 8.5f, 2019, "2h 2min", 100),
                new Movie("Avengers: Endgame", "Anthony Russo, Joe Russo", 8.4f, 2019, "3h 1min", 100),
                new Movie("Avengers: Infinity War", "Anthony Russo, Joe Russo", 8.4f, 2018, "2h 29min", 100),
                new Movie("The Dark Knight", "Christopher Nolan", 9.1f, 2008, "2h 32min", 100),
                new Movie("The Dark Knight Rises", "Christopher Nolan", 8.4f, 2012, "2h 44min", 100),
                new Movie("Jojo Rabbit", "Taika Waititi", 7.9f, 2019, "1h 48min ", 100),
                new Movie("The Prestige", "Christopher Nolan", 8.5f, 2006, "2h 10min ", 100),
                new Movie("The Wolf of Wall Street", "Martin Scorsese", 8.2f, 2013, "3h 0min", 100),
                new Movie("The Shawshank Redemption", "Frank Darabont", 9.3f, 1994, "2h 22min", 100),
                new Movie("Dunkirk", "Christopher Nolan", 7.9f, 2017, "1h 46min", 100),
                new Movie("The Lighthouse", "Robert Eggers", 7.5f, 2019, "1h 49min", 100),
                new Movie("The Greatest Showman", "Michael Gracey", 7.6f, 2017, "1h 45min", 100),
                new Movie("Gods of Egypt", "Alex Proyas", 5.4f, 2016, "2h 7min", 100),
                new Movie("The Lord of the Rings: The Fellowship of the Ring", "Peter Jackson", 8.8f, 2001, "2h 58min", 100),
                new Movie("The Lord of the Rings: The Two Towers", "Peter Jackson", 8.7f, 2002, "2h 59min", 100),
                new Movie("The Lord of the Rings: The Return of the King", "Peter Jackson", 8.9f, 2003, "3h 21min", 100),
                new Movie("Fight Club", "David Fincher", 8.8f, 1999, "2h 19min", 100),
                new Movie("Forrest Gump", "Robert Zemeckis", 8.8f, 1994, "2h 22min", 100),
                new Movie("Inception", "Christopher Nolan", 8.8f, 2010, "2h 28min", 100),
                new Movie("Catch Me If You Can", "Steven Spielberg", 8.1f, 2002, "2h 21min", 100),
                new Movie("Your Name.", "Makoto Shinkai", 8.4f, 2016, "1h 46min", 100),
                new Movie("A Silent Voice: The Movie", "Naoko Yamada", 8.2f, 2016, "2h 10min", 100),
                new Movie("Wolf Children", "Mamoru Hosoda", 8.1f, 2012, "1h 57min", 100)
            };

            return moviesList;
        }
    }
}
