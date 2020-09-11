using System;
using System.Collections.Generic;
using System.Text;

namespace MusikButik
{
    class BackupInventory
    {
        //string[] musicAlbums = new string[25];
        public string[] albumName = new string[25] { "I disagree", "TIM", "Dreamers", "Doom Days", "Väntar på en ängel", "Är", "÷(Deluxe)", "The Butterfly Effect", "CALM", "Night & Day (Day Edition - Extra Tracks", "IRL", "Prequelle", "RAMMSTEIN", "Gone Now", "Evolve", "Morgna Sulele", "What If Nothing", "COWBOY BEBOP Tank! The! best!", "You Are OK", "Pray For The Wicked", "AM", "Seal The Deal & Let's Boogie (Deluxe)", "Affirmation", "OMG What's Happening", "Svart, vitt och allt därimellan"};
        public string[] artist = new string[25] { "Poppy", "Avicii", "JUNG", "Bastille", "Oskar Linnros", "Snook", "Ed Sheeran", "Vargas & Lagola", "5 Seconds of Summer", "The Vamps", "HUMAN", "Ghost", "Rammstein", "Bleachers", "Imgine Dragons", "Morgan Sulele", "WALK THE MOON", "SEATBELTS", "The Maine", "Panic! At The Disco", "Arctic Monkeys", "Volbeat", "Savage Garden", "Ava Max", "Daniel Adams-Ray" };
        public byte[] albumRating = new byte[25] { 9, 10, 8, 9, 8, 7, 9, 6, 8, 7, 9, 8, 8, 7, 8, 6, 10, 8, 8, 9, 8, 8, 7, 7, 8 };
        public int[] albumreleaseDate = new int[25] { 2020, 2019, 2020, 2019, 2017, 2006, 2017, 2019, 2020, 2018, 2018, 2018, 2019, 2017, 2017, 2016, 2017, 2004, 2019, 2018, 2013, 2016, 1999, 2020, 2010 };
        public int[] albumLength = new int[25] { 45, 38, 33, 79, 39, 41, 59, 31, 43, 41, 38, 41, 46, 40, 43, 23, 55, 50, 44, 34, 41, 66, 53, 21, 38 };
        public int[] numberOfSongs = new int[25] { 14, 12, 10, 22, 12, 12, 16, 11, 13, 12, 11, 10, 11, 12, 12, 7, 13, 12, 10, 11, 12, 17, 12, 7, 10 };
        public int[] albumPrice = new int[25] { 100, 199, 100, 200, 100, 100, 100, 100, 100, 100 ,100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
        public Songs[] songs = new Songs[2];
        public void MusicAlbums()
        {
            
        }
        public void Movies()
        {
            string[] movieName = new string[25];
            string[] director = new string[25];
            byte[] movieRating = new byte[25];
            string[] movieReleaseDate = new string[25];
            int[] moviePrice = new int[25];
        }
    }
}
