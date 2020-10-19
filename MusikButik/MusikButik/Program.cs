using System;

namespace MusikButik
{
    class Program
    {
        static void Main(string[] args)
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
                // Anropar metod som skriver ut meny text
                MenuOptions();

                // Variabel för användar inmatning
                int input = 0;
                // Variabel för att kolla så att inmatningen är korrekt innan loopen anropar nästa steg
                bool isInputCorrect;
                // Try-catch för att ta in användar inmatning utan att programmet kraschar ifall det skulle gå snett
                try
                {
                    // Tar in användar inmatningen
                    string menuInput = Console.ReadLine();
                    // Trimmar fram och bak för att det inte ska bli fel om användaren råkat få med ett mellanslag
                    menuInput.Trim();
                    // försöker konvertera användar inmatningen till en integer
                    input = Convert.ToInt32(menuInput);
                    isInputCorrect = true;
                }
                // Informerar användaren om att det blivit fel och ber den att mata in ett värde mellan 0 och 6
                catch
                {
                    Console.WriteLine("Felaktig inmatning. Mata in 0-6");
                    isInputCorrect = false;
                }
                // Anropar metod för meny om det inmatade värdet är okej
                if (isInputCorrect == true)
                    // Sätter menuRun till bool värdet som metoden returnerar för att kontrollera om användaren vill avsluta programmet
                    menuRun = Menu(input, menuRun);
            }

            Console.WriteLine("Välkommen åter");
        }

        public static void MenuOptions()
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
        }

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
                        // Variabeln används för att skriva ut låtar på valt album
                        Album.GetAlbums()[browse].PrintSongs();
                    }
                    break;
                case 4:
                    // For loop som går genom alla album och skriver ut låtarna
                    for (int i = 0; i < Album.GetAlbums().Count; i++)
                    {
                        Console.WriteLine();
                        // Skriver ut namnet på albumet
                        Console.WriteLine(Album.GetAlbums()[i].name);
                        // Skriver ut en linje under namnet på albumet som är lika långt som namnet
                        Console.WriteLine("".PadRight(Album.GetAlbums()[i].name.Length, '-'));
                        // Anropar metod som skriver ut låtarna på albumet
                        Album.GetAlbums()[i].PrintSongs();
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
    }
}
