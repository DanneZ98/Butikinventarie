using System;
using System.Collections.Generic;

namespace MusikButik
{
    class Movies
    {
        // Variabler för presentation av filmerna
        public string name;
        public string creator;
        public float rating;
        public int releaseDate;
        public string duration;
        public int price;
        // Konstruktor
        public Movies(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price)
        {
            name = _name;
            creator = _creator;
            rating = _rating;
            releaseDate = _releaseDate;
            duration = _duration;
            price = _price;
        }
        // Metod som skriver ut alla filmer i listan som skickas med när man kallar på metoden
        public static void Print(List<Movies> list)
        {
            // Variabler
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
            Console.WriteLine($"{movieName.PadRight(50, ' ')} {movieDirector.PadRight(30, ' ')} {movieRating}   {movieRelease}↓  {movieDuration.PadRight(10, ' ')} {moviePrice}");
            list.Sort(new MoviesComparer());
            // Foreach loop for att skriva ut varje film i listan
            foreach (var movie in list)
            {
                Console.WriteLine($"{movie.name.PadRight(50, ' ')} {movie.creator.PadRight(30, ' ')} {movie.rating}      {movie.releaseDate}      {movie.duration.PadRight(10, ' ')} {movie.price}");
            }
        }
    }
}
