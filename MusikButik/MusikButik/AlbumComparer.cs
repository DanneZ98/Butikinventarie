using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MusikButik
{
    class AlbumComparer : IComparer<Album>
    {
        // Jämför rating med varandra och sorterar listan efter högsta ratingen
        public int Compare([AllowNull] Album x, [AllowNull] Album y)
        {

            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            if (x.rating > y.rating) return -1;
            if (x.rating < y.rating) return 1;

            return 0;
        }
    }
}
