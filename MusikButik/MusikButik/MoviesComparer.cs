using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MusikButik
{
    class MoviesComparer : IComparer<Movies>
    {
        public int Compare([AllowNull] Movies x, [AllowNull] Movies y)
        {
            //Enkelt sätt att använda underliggande egenskap
            //return x.ProductName.CompareTo(y.ProductName);

            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            if (x.releaseDate > y.releaseDate) return -1;
            if (x.releaseDate < y.releaseDate) return 1;

            return 0;
        }
    }
}
