using System;

namespace MusikButik
{
    public static class Butik
    {
        // Klass fält för addresserna. 
        static string faktureringsAdress = "Faktuerings gatan 5";
        static string besöksAdress = "Strandvägen 10";

        // Metod för att skriva ut adresserna
        static public void PrintAdress()
        {
            Console.WriteLine("Fakurerings Adress: " + faktureringsAdress);
            Console.WriteLine("Besöks Adress: " + besöksAdress);
        }
    }
}
