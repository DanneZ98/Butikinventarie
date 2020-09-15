using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MusikButik
{
    class Songs : IComparable
    {
        public string songName;
        public string songLength;
        public string featArtists;

        public Songs(string _songName, string _songLength)
        {
            songName = _songName;
            songLength = _songLength;
            featArtists = null;
        }

        public Songs(string _songName, string _songLength, string _featArtists)
        {
            songName = _songName;
            songLength = _songLength;
            featArtists = _featArtists;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void PrintSongs()
        {
            if (featArtists == null)
                Console.WriteLine($"Title: {songName} Length: {songLength}");
            else
                Console.WriteLine($"Title: {songName} featuring {featArtists} Length: {songLength}");
        }
    }
}
