using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace MusikButik
{
    class Butik
    {
        public string faktureringsAdress = "Faktuerings gatan 5";
        public string besöksAdress = "Strandvägen 10";

        public void PrintAdress()
        {
            Console.WriteLine("Fakurerings Adress: " + faktureringsAdress);
            Console.WriteLine("Besöks Adress: " + besöksAdress);
        }
    }
}
