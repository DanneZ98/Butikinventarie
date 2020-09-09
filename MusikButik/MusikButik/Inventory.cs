using System;
using System.Collections.Generic;
using System.Text;

namespace MusikButik
{
    class Inventory
    {
        public string name;
        public string creator;
        public float rating;
        public int releaseDate;
        public string duration;
        public int price;
        
        public Inventory(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price)
        {
            name = _name;
            creator = _creator;
            rating = _rating;
            releaseDate = _releaseDate;
            duration = _duration;
            price = _price;
        }
        
    }
}
