using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MusikButik
{
    class AlbumComparer : IComparer<Albums>
    {
        // Jämför rating med varandra och sorterar listan efter högsta ratingen
        public int Compare([AllowNull] Albums x, [AllowNull] Albums y)
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
