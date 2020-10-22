using System;

namespace MusikButik
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ändrar titeln på konsolen till något passande
            Console.Title = "Hans Johnnys Musik och Film Butik";
            // Välkommnar användaren till butiken och informerar om utbudet
            Console.WriteLine("Välkommen till Hans-Johnnys butik!");
            Console.WriteLine("Här har vi 25 unika filmer och 25 unika album");
            Console.WriteLine("Och bäst av allt. Varje produkt kostar endast 100 kr!");

            // While loop för att köra menyn
            bool menuRun = true;
            while (menuRun == true)
            {
                // Meny text
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Meny");
                Console.WriteLine("------");
                Console.WriteLine("1) Skriv ut filmer");
                Console.WriteLine("2) Skriv ut album");
                Console.WriteLine("3) Skriv ut låtar i specifikt album");
                Console.WriteLine("4) Skriv ut all låtar");
                Console.WriteLine("5) Skriv ut adresser");
                Console.WriteLine("6) Rensa konsolen");
                Console.WriteLine("0) Avsluta program");

                // Anropar metod för användarinmatning och lagrar resultatet i en int variabel
                int input = GetUserInput(0, 6);
                // Anropar metod för att köra menyn och lagrar resultatet i bool variabeln som styr om menyn ska avslutas eller inte. 
                menuRun = Menu(input, menuRun);
            }

            Console.WriteLine("Välkommen åter");
        }
        // Metod för användarinmatning
        public static int GetUserInput(int min, int max)
        {
            int output = -1;
            bool acceptedInput = false;
            while (acceptedInput == false)
            {
                // Variabel för användar inmatning
                int input = -1;
                // Variabel för att kolla så att inmatningen är korrekt innan loopen anropar nästa steg
                // Try-catch för att ta in användar inmatning utan att programmet kraschar ifall det skulle gå snett
                try
                {
                    // Tar in användar inmatningen
                    string menuInput = Console.ReadLine();
                    // Trimmar fram och bak för att det inte ska bli fel om användaren råkat få med ett mellanslag
                    menuInput.Trim();
                    // försöker konvertera användar inmatningen till en integer
                    input = Convert.ToInt32(menuInput);
                }
                // Informerar användaren om att det blivit fel och ber den att mata in ett värde mellan min och max
                catch
                {
                    Console.WriteLine($"Felaktig inmatning. Mata in {min}-{max}");
                }

                // Kollar att det inmatade värdet är mellan parametrarna
                if (input >= min && input <= max)
                {
                    output = input;
                    acceptedInput = true;
                }
                else
                    acceptedInput = false;
            }

            // returnerar det inmatade värdet efter det har gått igenom felhanteringen
            return output;
        }
        // Metod för att köra menyn
        public static bool Menu(int input, bool menuRun)
        {
            // Använder inmatningen i en switch case sats för att köra koden för den funktion användaren valt
            switch (input)
            {
                case 1:
                    // Kallar på print movies metoden och för med listan med filmer
                    Movie.Print(Movie.GetMovies());
                    break;
                case 2:
                    // Kallar på print albums metoden och för med listan med album
                    Album.Print(Album.GetAlbums());
                    break;
                case 3:
                    {
                        // Kallar på metod för att få ut vilket album användaren vill kolla på
                        // Resultatet av metoden lagras i en variabel
                        int browse = Album.PrintSongsSpecificAlbum(Album.GetAlbums());
                        // Anropar metod som skriver ut låtarna i specifikt album
                        PrintSongs(browse);
                    }
                    break;
                case 4:
                    // For loop som går genom alla album och skriver ut låtarna
                    for (int i = 0; i < Album.GetAlbums().Count; i++)
                    {
                        // Anropar metod som skriver ut låtarna i specifikt album
                        PrintSongs(i);
                    }
                    break;
                case 5:
                    // Kallar på metod för att skriva ut adresser
                    Butik.PrintAdress();
                    break;
                case 6:
                    // Rensar upp i konsolen 
                    Console.Clear();
                    break;
                case 0:
                    // Sätter bool variabeln till false och därmed avslutar loopen som kör menyn
                    menuRun = false;
                    break;
                default:
                    // Fångar upp värden som avviker från valen som finns
                    Console.WriteLine("Felaktig inmatning. Mata in 0-6");
                    break;
            }
            return menuRun;
        }

        public static void PrintSongs(int i)
        {
            Console.WriteLine();
            // Skriver ut namnet på albumet
            Console.WriteLine(Album.GetAlbums()[i].name);
            // Skriver ut en linje under namnet på albumet som är lika långt som namnet
            Console.WriteLine("".PadRight(Album.GetAlbums()[i].name.Length, '-'));
            // Anropar metod som skriver ut låtarna på albumet
            Album.GetAlbums()[i].PrintSongs();
        }
    }
}
