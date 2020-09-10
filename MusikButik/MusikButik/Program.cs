using System;

namespace MusikButik
{
    class Program
    {
        static void Main(string[] args)
        {
            Butik myButik = new Butik();
            Inventory[] movies = new Inventory[25];
            Music[] albums = new Music[25];

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

            Console.WriteLine();
            Console.WriteLine("Filmer");
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine($"{movies[i].name} {movies[i].creator}  {movies[i].rating}  {movies[i].releaseDate}  {movies[i].duration}  {movies[i].price}");
            }
            /*
        public byte[] albumRating = new byte[25] { 9, 10, 8, 9, 8, 7, 9, 6, 8, 7, 9, 8, 8, 7, 8, 6, 10, 8, 8, 9, 8, 8, 7, 7, 8 };
        public int[] albumreleaseDate = new int[25] { 2020, 2019, 2020, 2019, 2017, 2006, 2017, 2019, 2020, 2018, 2018, 2018, 2019, 2017, 2017, 2016, 2017, 2004, 2019, 2018, 2013, 2016, 1999, 2020, 2010 };
        public int[] albumLength = new int[25] {    //23, 55, 50, 44, 34, 41, 66, 53, 21, 38 };
        public int[] numberOfSongs = new int[25] { 14, 12, 10, 11, 12, 12, 16, 11, 13, 12, 11, 10, 11, 12, 12, 7, 13, 12, 10, 11, 12, 17, 12, 7, 10 };
        public int[] albumPrice = new int[25] { 100, 199, 100, 200, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        */
            albums[0] = new Music("I disagree", "Poppy", 0f, 2020, "45min", 100, 14);
            albums[1] = new Music("TIM", "Avicii", 0f, 2019, "38min", 100, 12);
            albums[2] = new Music("Dreamers", "JUNG", 0f, 2020, "33min", 100, 10);
            albums[3] = new Music("Doom Days", "Bastille", 0f, 2019, "40min", 100, 11);
            albums[4] = new Music("Väntar på en ängel", "Oskar Linnros", 0f, 2017, "39min", 100, 12);
            albums[5] = new Music("Är", "Snook", 0f, 2006, "41min", 100, 12);
            albums[6] = new Music("÷(Deluxe)", "Ed Sheeran", 0f, 2019, "59min", 100, 16);
            albums[7] = new Music("The Butterfly Effect", "Vargas & Lagola", 0f, 2019, "31min", 100, 11);
            albums[8] = new Music("CALM", "5 Seconds of Summer", 0f, 2019, "43min", 100, 13);
            albums[9] = new Music("Night & Day (Day Edition - Extra Tracks", "The Vamps", 0f, 2019, "41min", 100, 12);
            albums[10] = new Music("IRL", "HUMAN", 0f, 2019, "38min", 100, 11);
            albums[11] = new Music("Prequelle", "Ghost", 0f, 2019, "41min", 100, 10);
            albums[12] = new Music("RAMMSTEIN", "Rammstein", 0f, 2019, "46min", 100, 11);
            albums[13] = new Music("Gone Now", "Bleachers", 0f, 2019, "40min", 100, 12);
            albums[14] = new Music("Evolve", "Imgine Dragons", 0f, 2019, "43min", 100, 12);
            albums[15] = new Music("Morgna Sulele", "Morgna Sulele", 0f, 2019, "23min", 100, 7);
            albums[16] = new Music("What If Nothing", "WALK THE MOON", 0f, 2019, "55min", 100, 13);
            albums[17] = new Music("COWBOY BEBOP Tank! The! best!", "SEATBELTS", 0f, 2019, "50min", 100, 12);
            albums[18] = new Music("You Are OK", "The Maine", 0f, 2019, "44min", 100, 10);
            albums[19] = new Music("Pray For The Wicked", "Panic! At The Disco", 0f, 2019, "34min", 100, 11);
            albums[20] = new Music("AM", "Arctic Monkeys", 0f, 2019, "41min", 100, 12);
            albums[21] = new Music("Seal The Deal & Let's Boogie (Deluxe)", "Volbeat", 0f, 2019, "1h 6min", 100, 17);
            albums[22] = new Music("Affirmation", "Savage Garden", 0f, 2019, "53min", 100, 12);
            albums[23] = new Music("OMG What's Happening", "Ava Max", 0f, 2019, "21min", 100, 7);
            albums[24] = new Music("Svart, vitt och allt därimellan", "Daniel Adams-Ray", 0f, 2019, "38min", 100, 10);

            Console.WriteLine();
            Console.WriteLine("Album");
            for (int i = 0; i < albums.Length; i++)
            {
                Console.WriteLine($"{albums[i].name} {albums[i].creator} {albums[i].rating} {albums[i].releaseDate} {albums[i].duration} {albums[i].price} {albums[i].numberOfSongs}");
            }
        }
    }
}
