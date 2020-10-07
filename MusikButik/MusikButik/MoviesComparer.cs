using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MusikButik
{
    class MoviesComparer : IComparer<Movies>
    {
        // Jämför releaseDate med varandra och sorterar listan efter senaste releasen
        public int Compare([AllowNull] Movies x, [AllowNull] Movies y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            if (x.releaseDate > y.releaseDate) return -1;
            if (x.releaseDate < y.releaseDate) return 1;

            return 0;
        }
    }
}
