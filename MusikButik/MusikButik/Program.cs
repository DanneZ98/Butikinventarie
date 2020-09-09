using System;

namespace MusikButik
{
    class Program
    {
        static void Main(string[] args)
        {
            Butik myButik = new Butik();
            Inventory[] movies = new Inventory[25];

            Console.WriteLine("Välkommen till Hans-Johnnys butik!");
            Console.WriteLine("Fakurerings Adress: " + myButik.faktureringsAdress);
            Console.WriteLine("Besöks Adress: " + myButik.besöksAdress);
            Console.WriteLine();
            //myInventory.MusicAlbums(); 
            /*
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Album: " + myInventory.albumName[i] + " Artist: " + myInventory.artist[i] + " Album Rating: " + myInventory.albumRating[i]);
                // Console.WriteLine($"Songs: {myAlbum.");
            }
            myAlbum.Songs();
            */

            movies[0] = new Inventory("Parasite", "Bong Joon Ho", 8.6f, 2019, "2h 12min", 100);
            movies[1] = new Inventory("Knives Out", "Rian Johnson", 7.9f, 2019, "2h 10min", 100);
            movies[2] = new Inventory("Joker", "Todd Phillips", 8.5f, 2019, "2h 2min", 100);
            movies[3] = new Inventory("Avengers: Endgame", "Anthony Russo, Joe Russo", 8.4f, 2019, "3h 1min", 100);
            movies[4] = new Inventory("Avengers: Infinity War", "Anthony Russo, Joe Russo", 8.4f, 2018, "2h 29min", 100);
            movies[5] = new Inventory("The Dark Knight", "Christopher Nolan", 9.0f, 2008, "2h 32min", 100);
            movies[6] = new Inventory("The Dark Knight Rises", "Christopher Nolan", 8.4f, 2012, "2h 44min", 100);
            movies[7] = new Inventory("Jojo Rabbit", "Taika Waititi", 7.9f, 2019, "1h 48min ", 100);
            movies[8] = new Inventory("The Prestige", "Christopher Nolan", 8.5f, 2006, "2h 10min ", 100);
            movies[9] = new Inventory("The Wolf of Wall Street", "Martin Scorsese", 8.2f, 2013, "3h 0min", 100);
            movies[10] = new Inventory("The Shawshank Redemption", "Frank Darabont", 9.3f, 1994, "2h 22min", 100);
            movies[11] = new Inventory("Dunkirk", "Christopher Nolan", 7.9f, 2017, "1h 46min", 100);
            movies[12] = new Inventory("The Lighthouse", "Robert Eggers", 7.5f, 2019, "1h 49min", 100);
            movies[13] = new Inventory("The Greatest Showman", "Michael Gracey", 7.6f, 2017, "1h 45min", 100);
            movies[14] = new Inventory("Gods of Egypt", "Alex Proyas", 5.4f, 2016, "2h 7min", 100);
            movies[15] = new Inventory("The Lord of the Rings: The Fellowship of the Ring", "Peter Jackson", 8.8f, 2001, "2h 58min", 100);
            movies[16] = new Inventory("The Lord of the Rings: The Two Towers", "Peter Jackson", 8.7f, 2002, "2h 59min", 100);
            movies[17] = new Inventory("The Lord of the Rings: The Return of the King", "Peter Jackson", 8.9f, 2003, "3h 21min", 100);
            movies[18] = new Inventory("Fight Club", "David Fincher", 8.8f, 1999, "2h 19min", 100);
            movies[19] = new Inventory("Forrest Gump", "Robert Zemeckis", 8.8f, 1994, "2h 22min", 100);
            movies[20] = new Inventory("Inception", "Christopher Nolan", 8.8f, 2010, "2h 28min", 100);
            movies[21] = new Inventory("Catch Me If You Can", "Steven Spielberg", 8.1f, 2002, "2h 21min", 100);
            movies[22] = new Inventory("Your Name.", "Makoto Shinkai", 8.4f, 2016, "1h 46min", 100);
            movies[23] = new Inventory("A Silent Voice: The Movie", "Naoko Yamada", 8.2f, 2016, "2h 10min", 100);
            movies[24] = new Inventory("Wolf Children", "Mamoru Hosoda", 8.1f, 2012, "1h 57min", 100);

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine($"{movies[i].name} {movies[i].creator}  {movies[i].rating}  {movies[i].releaseDate}  {movies[i].duration}  {movies[i].price}");
            }
            
        }
    }
}
