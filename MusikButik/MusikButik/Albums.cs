using System;
using System.Collections.Generic;
using System.Text;

namespace MusikButik
{
    
    class Albums : Movies
    {
        public byte numberOfSongs;
        public Albums(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price, byte _numberOfSongs) : base(_name, _creator, _rating, _releaseDate, _duration, _price)
        {
            name = _name;
            creator = _creator;
            rating = _rating;
            releaseDate = _releaseDate;
            duration = _duration;
            price = _price;
            numberOfSongs = _numberOfSongs;
        }
    }
}
