using System;
using System.Collections.Generic;

namespace MusikButik
{
    // Klass för album som ärver från filmklassen
    // Använder sig av fälten i filmklassen
    class Albums : Movies
    {
        // Klass fält för album
        public byte numberOfSongs;
        string[] songName;
        string[] songFeat;
        string[] songLength;

        // Konstruktor 
        public Albums(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price, byte _numberOfSongs, string[] _songName, string[] _songFeat, string[] _songLength) : base(_name, _creator, _rating, _releaseDate, _duration, _price)
        {
            name = _name;
            creator = _creator;
            rating = _rating;
            releaseDate = _releaseDate;
            duration = _duration;
            price = _price;
            numberOfSongs = _numberOfSongs;
            songName = _songName;
            songFeat = _songFeat;
            songLength = _songLength;
        }
        // Metod för att skriva ut alla låtar i ett album
        public void PrintSongs()
        {
            // For loop som går genom alla låtar i ett album
            for (int i = 0; i < songName.Length; i++)
            {
                // If else sats som kollar om låten har en featuring artist eller inte
                if (songFeat[i] == null)
                {
                    // Skriver ut låtnamn och längd på låten
                    Console.WriteLine($"{songName[i].PadRight(50)} {songLength[i]}");
                }
                else
                {
                    // Skriver ut låtnamn, featuring artist och längd på låten
                    Console.WriteLine($"{songName[i].PadRight(50)} {songLength[i]}      featuring {songFeat[i]}");
                }
            }
        }
        // Metod som tar in en lista av typen album
        public static void Print(List<Albums> list)
        {
            // Variabler till att presentera innehållet i Albums
            string albumName = "Title";
            string albumRating = "Rating";
            string albumRelease = "Release";
            string albumDuration = "Duration";
            string albumPrice = "Price";
            string albumNrSongs = "Number of Songs";
            string albumArtist = "Artist";

            // Sorterar listan efter rating
            list.Sort(new AlbumComparer());
            Console.WriteLine();
            Console.WriteLine("Albums");
            Console.WriteLine("-------");
            // Paddar strängarna så att det är symmetriskt när det skrivs ut
            Console.WriteLine($"{albumName.PadRight(40, ' ')} {albumArtist.PadRight(20, ' ')} {albumRating}↓  {albumRelease}   {albumDuration.PadRight(10, ' ')} {albumPrice}    {albumNrSongs}");
            // Foreach loop för att skriva ut alla album i listan med album och skriver ut värdena
            foreach (var album in list)
            {
                Console.WriteLine($"{album.name.PadRight(40, ' ')} {album.creator.PadRight(20, ' ')} {album.rating}      {album.releaseDate}      {album.duration.PadRight(10, ' ')} {album.price}      {album.numberOfSongs}");
            }
        }
        // Metod som väljer ett album att skriva ut låtar till
        // Returnerar en int och för med en lista
        public static int PrintSongsSpecificAlbum(List<Albums> albumsList)
        {
            // Integer för vilket album som användaren väljer
            int albumToBrowse = 0;
            // Bool variabel för while loppen
            bool inputCheck = false;
            Console.WriteLine();
            Console.WriteLine("Vilket album vill du kolla på?");
            // Skriver ut alla album med en for loop
            for (int i = 0; i < albumsList.Count; i++)
            {
                Console.WriteLine($"{i}: {albumsList[i].name}");
            }
            // While loop som fortsätter programmet och låter användaren välja om ifall den skriver fel
            while (inputCheck == false)
            {
                // Lagrar användar inmatningen i en sträng variabel och trimmar den
                string inputAlbumToBrowseCheck = Console.ReadLine();
                inputAlbumToBrowseCheck.Trim();
                // try-catch sats för 
                try
                {   
                    // att konvertera inmatningen till en int
                    albumToBrowse = Convert.ToInt32(inputAlbumToBrowseCheck);
                    // If sats för att kontrollera att värdet är mellan 0 och 24
                    if (albumToBrowse > -1 && albumToBrowse < 25)
                        // Avslutar while loopen ifall värdet är okej
                        inputCheck = true;
                    else
                        // Informerar användaren att inmatningen är inkorrekt och ber den att mata in ett värde mellan 0 och 24
                        Console.WriteLine("Felaktig inmatning. Mata in 0-24");
                }
                catch
                {
                    // Informerar användaren att inmatningen är inkorrekt och ber den att mata in ett värde mellan 0 och 24
                    Console.WriteLine("Felaktig inmatning. Mata in 0-24");
                }
            }
            // returnerar ett int värde mellan 0 och 24
            return albumToBrowse;
        }
    }
}
