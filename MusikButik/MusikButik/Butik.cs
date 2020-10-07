using System;

namespace MusikButik
{
    class Butik
    {
        // Klass fält för addresserna. 
        public string faktureringsAdress = "Faktuerings gatan 5";
        public string besöksAdress = "Strandvägen 10";

        // Metod för att skriva ut adresserna
        public void PrintAdress()
        {
            Console.WriteLine("Fakurerings Adress: " + faktureringsAdress);
            Console.WriteLine("Besöks Adress: " + besöksAdress);
        }
    }
}
