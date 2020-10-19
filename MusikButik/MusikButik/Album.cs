using System;
using System.Collections.Generic;

namespace MusikButik
{
    // Klass för album som ärver från filmklassen
    // Använder sig av fälten i filmklassen
    class Album : Movie
    {
        // Klass fält för album
        public byte numberOfSongs;
        string[] songName;
        string[] songFeat;
        string[] songLength;

        // Konstruktor 
        public Album(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price, byte _numberOfSongs, string[] _songName, string[] _songFeat, string[] _songLength) : base(_name, _creator, _rating, _releaseDate, _duration, _price)
        {
            name = _name;
            creator = _creator;
            rating = _rating;
            releaseDate = _releaseDate;
            duration = _duration;
            price = _price;
            numberOfSongs = _numberOfSongs;
            songName = _songName;
            songFeat = _songFeat;
            songLength = _songLength;
        }
        // Metod för att skriva ut alla låtar i ett album
        public void PrintSongs()
        {
            // For loop som går genom alla låtar i ett album
            for (int i = 0; i < songName.Length; i++)
            {
                // If else sats som kollar om låten har en featuring artist eller inte
                if (songFeat[i] == null)
                {
                    // Skriver ut låtnamn och längd på låten
                    Console.WriteLine($"{songName[i].PadRight(100)} {songLength[i]}");
                }
                else
                {
                    // Skriver ut låtnamn, featuring artist och längd på låten
                    Console.Write($"{songName[i].PadRight(50)}");
                    Console.Write($"featuring {songFeat[i].PadRight(41)}");
                    Console.Write($"{songLength[i]}\n");
                }
            }
        }
        // Metod som tar in en lista av typen album
        public static void Print(List<Album> list)
        {
            // Variabler till att presentera innehållet i Albums
            string albumName = "Title";
            string albumRating = "Rating";
            string albumRelease = "Release";
            string albumDuration = "Duration";
            string albumPrice = "Price";
            string albumNrSongs = "Number of Songs";
            string albumArtist = "Artist";

            // Sorterar listan efter rating
            list.Sort(new AlbumComparer());
            Console.WriteLine();
            Console.WriteLine("Albums");
            Console.WriteLine("-------");
            // Paddar strängarna så att det är symmetriskt när det skrivs ut
            Console.WriteLine($"{albumName.PadRight(40)} {albumArtist.PadRight(20)} {albumRating}↓  {albumRelease}   {albumDuration.PadRight(10)} {albumPrice}    {albumNrSongs}");
            // Foreach loop för att skriva ut alla album i listan med album och skriver ut värdena
            foreach (var album in list)
            {
                Console.WriteLine($"{album.name.PadRight(40)} {album.creator.PadRight(20)} {album.rating}      {album.releaseDate}      {album.duration.PadRight(10)} {album.price}      {album.numberOfSongs}");
            }
        }
        // Metod som väljer ett album att skriva ut låtar till
        // Returnerar en int och för med en lista i anropet
        public static int PrintSongsSpecificAlbum(List<Album> albumsList)
        {
            // Integer för vilket album som användaren väljer
            int albumToBrowse = 0;
            // Bool variabel för while loppen
            bool inputCheck = false;
            Console.WriteLine();
            Console.WriteLine("Vilket album vill du kolla på?");
            // Skriver ut alla album med en for loop
            for (int i = 0; i < albumsList.Count; i++)
            {
                Console.WriteLine($"{i}: {albumsList[i].name}");
            }
            // While loop som fortsätter programmet och låter användaren välja om ifall den skriver fel
            while (inputCheck == false)
            {
                // Lagrar användar inmatningen i en sträng variabel och trimmar den
                string inputAlbumToBrowseCheck = Console.ReadLine();
                inputAlbumToBrowseCheck.Trim();
                // try-catch sats för 
                try
                {
                    // att konvertera inmatningen till en int
                    albumToBrowse = Convert.ToInt32(inputAlbumToBrowseCheck);
                    // If sats för att kontrollera att värdet är mellan 0 och 24
                    if (albumToBrowse > -1 && albumToBrowse < 25)
                        // Avslutar while loopen ifall värdet är okej
                        inputCheck = true;
                    else
                        // Informerar användaren att inmatningen är inkorrekt och ber den att mata in ett värde mellan 0 och 24
                        Console.WriteLine("Felaktig inmatning. Mata in 0-24");
                }
                catch
                {
                    // Informerar användaren att inmatningen är inkorrekt och ber den att mata in ett värde mellan 0 och 24
                    Console.WriteLine("Felaktig inmatning. Mata in 0-24");
                }
            }
            // returnerar ett int värde mellan 0 och 24
            return albumToBrowse;
        }

        public static List<Album> GetAlbums()
        {
            // Lista med alla låtar
            #region Song info
            string[][] jaggedSongArray = new string[25][];
            string[][] jaggedLengthArray = new string[25][];
            string[][] jaggedFeaturingArray = new string[25][];

            jaggedSongArray[0] = new string[10] { "Concrete", "I Disagree", "BLOODMONEY", "Anything Like Me", "Fill The Crown", "Nothing I Need", "Sit / Stay", "Bite Your Teeth", "Sick Of The Sun", "Don't Go Outside" };
            jaggedSongArray[1] = new string[12] { "Peace Of Mind", "Heaven", "SOS", "Tough Love", "Bad Reputation", "Ain't A Thing", "Hold The Line", "Freak", "Excuse Me Mr Sir", "Heart Upon My Sleeve", "Never Leave me", "Fades Away" };
            jaggedSongArray[2] = new string[10] { "Follow Your Heart", "Falling Free", "Let Him Go", "i love you, i love you", "Giants", "Call Me Up", "These Days", "Marathon Man", "Brave", "Dreamers" };
            jaggedSongArray[3] = new string[11] { "Quarter Past Midnight", "Bad Decisions", "The Waves", "Divide", "Million Pieces", "Doom Days", "Nocturnal Creatures", "4AM", "Another Place", "Those Nights", "Joy" };
            jaggedSongArray[4] = new string[12] { "Väntar på en Ängel", "GåApaGå", "ÖverAllt", "Bäst", "Född att slåss", "Psalm för skolgårdar", "GeGeGeGe", "Wifi", "Fri Interlude", "Fri", "Oavsett", "Ängladamm" };
            jaggedSongArray[5] = new string[12] { "Är", "Kommer ifrån", "Snook, svett & tårar", "Inga Problem", "Hiphop", "Blunda", "Jag gör min grej", "Ammunition", "7 timmar", "Bejbi", "Längst fram i taxin", "Älskling jag är hemma nu" };
            jaggedSongArray[6] = new string[16] { "Eraser", "Castle on the Hill", "Dive", "Shape of You", "Perfect", "Galway Girl", "Happier", "New Man", "Hearts Don't Break Around Here", "What Do I Know?", "How Would You Feel (Paean)", "Supermarket Flowers", "Barcelona", "Bibia Be Ye Ye", "Nancy Mulligan", "Save Myself" };
            jaggedSongArray[7] = new string[11] { "One Eternal Being", "Darkest Before Dawn", "Since 99", "Hurts To Be Hurt", "Nothing Changes", "Forgot To Be Your Lover", "Prisoners", "Back To You", "Somebody That Understands Me", "Pick It Up", "Freedom Dividend" };
            jaggedSongArray[8] = new string[13] { "Red Desert", "No Shame", "Old Me", "Easier", "Teeth", "Wildflower", "Best Years", "Not In The Same Way", "Lover Of Mine", "Thin White Lies", "Lonely Heart", "High", "Kill My Time" };
            jaggedSongArray[9] = new string[12] { "If I Was Your Man", "Kiss", "Sometimes", "Black And Blue", "Naked", "Shivers", "My Life", "Juicy Fruit", "Sometimes It Rains In LA", "On Your Mind", "Stumble Home", "Tequila" };
            jaggedSongArray[10] = new string[11] { "IRL", "LIGHTS", "HIGHER", "LOVE LETTER", "TRACKSUIT BOY", "TOMORROW", "BEING", "GHOST", "ROBOT", "GHETTO", "I'D RATHER LIVE" };
            jaggedSongArray[11] = new string[10] { "Ashes", "Rats", "Faith", "See The Light", "Miasma", "Dance Macabre", "Pro Memoria", "Witch Image", "Helvetesfonster", "Life Eternal" };
            jaggedSongArray[12] = new string[11] { "DEUTSCHLAND", "RADIO", "ZEIG DICH", "AUSLÄNDER", "SEX", "PUPPE", "WAS ICH LIEBE", "DIAMANT", "WEIT WEG", "TATTOO", "HALLOMANN" };
            jaggedSongArray[13] = new string[12] { "Dream Of Mickey Mantle", "Goodmorning", "Hate That You Know Me", "Don't Take The Money", "Everybody Lost Somebody", "All My Heroes", "Let's Get Married", "Goodbye", "I Miss Those Days", "Nothing Is U", "I'm Ready To Move On/Mickey Mantle Reprise", "Foreign Girls" };
            jaggedSongArray[14] = new string[12] { "Next To Me", "I Don't Know Why", "Whatever It Takes", "Believer", "Walking The Wire", "Rise Up", "I'll Make It Up To You", "Yesterday", "Mouth Of The River", "Thunder", "Start Over", "Dancing In The Dark" };
            jaggedSongArray[15] = new string[7] { "Helgedigg", "Bare min", "Din sang", "Jeg vil heller ha deg", "Min kabin", "Lakenet", "Lakenet - Beachbraaten Remix" };
            jaggedSongArray[16] = new string[13] { "Press Restart", "Headphones", "One Foot", "Surrender", "All I Want", "All Night", "Kamikaze", "Tiger Teeth", "Sound Of Awakening", "Feels Good To Be High", "Can't Sleep (Wolves)", "In My Mind", "Lost In The Wild" };
            jaggedSongArray[17] = new string[12] { "Tank! - TV stretch", "What Planet Is This.", "Cosmic Dare (Pretty With A Pistol)", "Diamonds", "Don't Bother None - TV Edit", "Piano Black", "Mushroom Hunting", "No Reply", "Blue", "Einstein Groovin'", "Pearls", "Gotta Knock A Little Harder" };
            jaggedSongArray[18] = new string[10] { "Slip the Noose", "My Best Habit", "Numb Without You", "I Feel It All Over", "Heaven, We're Already There", "Forevermore", "Tears Wont Cry (ShinjU)", "One Sunset", "Broken Parts", "Flowers on the Grave" };
            jaggedSongArray[19] = new string[11] { "(Fuck A)Silver Lining", "Say Amen (Saturday Night)", "Hey Look Ma, I Made It", "High Hopes", "Roaring 20s", "Dancing's Not a Crime", "One of the Drunks", "The Overpass", "King of the Clouds", "Old Fashioned", "Dying in LA" };
            jaggedSongArray[20] = new string[12] { "Do I Wanna Know?", "R U Mine?", "One For The Road", "Arabella", "I Want It All", "No.1 Party Anthem", "Mad Sounds", "Fireside", "Why'd You Only Call Me When You're High?", "Snap Out Of It", "Knee Socks", "I Wanna be Yours" };
            jaggedSongArray[21] = new string[17] { "The Devil's Bleeding Crown", "Marie Laveau", "For Evigt", "The Gates Of Babylon", "Let It Burn", "Black Rose", "Rebound", "Mary Jane Kelly", "Goodbye Forever", "Seal The Deal", "Battleship Chains", "You Will Know", "The Loa's Crossroad", "Slaytan", "The Bliss", "Black Rose", "The Devils's Bleeding Crown - Live" };
            jaggedSongArray[22] = new string[12] { "Affirmation", "Hold Me", "I Knew I Loved You", "The Best Thing", "Crash And Burn", "Chained to You", "The Animal Song", "The Lover After Me", "Two Beds And A Coffee Machine", "You Can Still Be Free", "Gunning Down Romance", "I Don't Know Anymore" };
            jaggedSongArray[23] = new string[7] { "OMG What's Happening", "Who's Laughing Now", "Kings & Queens", "Salt", "Torn", "So Am I", "Sweet But Psycho" };
            jaggedSongArray[24] = new string[10] { "Svart", "Voyeuren", "Gubben i lådan", "Lilla lady", "Förlåt att jag aldrig sagt förlåt", "Dum av dig", "Himlen luktar plast", "Gryningspyromanen", "Medan vi faller", "Vitt" };

            jaggedFeaturingArray[0] = new string[10] { null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[1] = new string[12] { "Vargas & Lagola", null, "Aloe Blacc", "Agnes, Vargas & Lagola", "Joe Janiak", "Bonn", "A R I Z O N A", "Bonn", "Vargas & Lagola", "Imagine Dragons", "Joe Janiak", "Noonie Bao" };
            jaggedFeaturingArray[2] = new string[10] { null, null, "Clara Mae", null, null, null, null, null, null, null };
            jaggedFeaturingArray[3] = new string[11] { null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[4] = new string[12] { null, null, "Cherrie", null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[5] = new string[12] { null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[6] = new string[16] { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[7] = new string[11] { null, null, null, null, null, null, null, "Ghostface Killah", "Ludwig Goransson", null, null };
            jaggedFeaturingArray[8] = new string[13] { null, null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[9] = new string[12] { null, null, null, null, null, null, "New Hope Club", "Silentó", null, null, "Lindsay Ell", null };
            jaggedFeaturingArray[10] = new string[11] { null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[11] = new string[10] { null, null, null, null, null, null, null, null, null, null, };
            jaggedFeaturingArray[12] = new string[11] { null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[13] = new string[12] { null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[14] = new string[12] { null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[15] = new string[7] { null, null, null, "Innertier", null, null, "Beachbraaten" };
            jaggedFeaturingArray[16] = new string[13] { null, null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[17] = new string[12] { null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[18] = new string[10] { null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[19] = new string[11] { null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[20] = new string[12] { null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[21] = new string[17] { null, null, "Johan Olsen", null, null, "Danko Jones", null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[22] = new string[12] { null, null, null, null, null, null, null, null, null, null, null, null };
            jaggedFeaturingArray[23] = new string[7] { null, null, null, null, null, null, null };
            jaggedFeaturingArray[24] = new string[10] { null, null, null, null, null, null, null, null, null, null };

            jaggedLengthArray[0] = new string[10] { "3:20", "3:13", "3:03", "3:20", "3:32", "2:50", "3:54", "2:43", "3:12", "6:06" };
            jaggedLengthArray[1] = new string[12] { "3:00", "4:37", "2:37", "3:11", "3:25", "3:04", "2:52", "2:59", "3:08", "4:14", "2:52", "2:59" };
            jaggedLengthArray[2] = new string[10] { "4:01", "2:41", "3:35", "4:08", "3:49", "2:44", "3:40", "1:26", "3:42", "3:19" };
            jaggedLengthArray[3] = new string[11] { "3:19", "3:10", "4:01", "3:52", "4:12", "2:18", "3:52", "4:08", "3:32", "4:30", "3:13" };
            jaggedLengthArray[4] = new string[12] { "4:30", "2:24", "3:26", "3:45", "3:15", "2:53", "3:38", "3:20", "0:31", "4:03", "4:00", "3:27" };
            jaggedLengthArray[5] = new string[12] { "0:25", "4:07", "3:45", "3:07", "1:28", "3:10", "5:48", "4:04", "2:49", "3:28", "3:39", "5:27" };
            jaggedLengthArray[6] = new string[16] { "3:47", "4:21", "3:58", "3:54", "4:23", "2:51", "3:28", "3:09", "4:08", "3:57", "4:41", "3:41", "3:11", "2:57", "3:00", "4:07" };
            jaggedLengthArray[7] = new string[11] { "1:33", "4:42", "3:31", "3:38", "0:35", "3:24", "0:16", "3:41", "5:00", "4:00", "1:25" };
            jaggedLengthArray[8] = new string[13] { "3:50", "3:13", "3:07", "2:38", "3:26", "3:41", "3:10", "3:41", "3:27", "3:03", "3:24", "2:58", "3:55" };
            jaggedLengthArray[9] = new string[12] { "3:31", "3:20", "3:39", "3:17", "3:37", "3:03", "3:26", "3:50", "3:21", "3:33", "3:32", "3:06" };
            jaggedLengthArray[10] = new string[11] { "1:23", "3:36", "3:46", "3:55", "3:23", "3:24", "3:32", "3:48", "3:53", "4:11", "3:21" };
            jaggedLengthArray[11] = new string[10] { "1:21", "4:22", "4:30", "4:05", "5:18", "3:40", "5:39", "3:30", "5:56", "3:27" };
            jaggedLengthArray[12] = new string[11] { "5:22", "4:37", "4:16", "3:52", "3:57", "4:34", "4:29", "2:34", "4:21", "4:12", "4:12" };
            jaggedLengthArray[13] = new string[12] { "3:10", "3:13", "3:06", "3:36", "3:55", "3:04", "3:06", "2:57", "3:38", "2:32", "4:24", "4:02" };
            jaggedLengthArray[14] = new string[12] { "3:50", "3:10", "3:21", "3:24", "3:53", "3:52", "4:23", "3:25", "3:42", "3:07", "3:06", "3:54" };
            jaggedLengthArray[15] = new string[7] { "3:35", "3:02", "3:22", "3:08", "3:37", "3:30", "2:56" };
            jaggedLengthArray[16] = new string[13] { "4:20", "3:07", "4:21", "5:04", "4:16", "3:43", "3:17", "5:23", "6:16", "4:21", "3:46", "3:57", "3:56" };
            jaggedLengthArray[17] = new string[12] { "3:27", "2:45", "4:09", "4:02", "2:56", "2:48", "3:20", "6:00", "5:04", "6:20", "4:45", "5:20" };
            jaggedLengthArray[18] = new string[10] { "4:04", "3:55", "3:33", "4:01", "4:40", "2:52", "4:12", "3:33", "4:21", "9:23" };
            jaggedLengthArray[19] = new string[11] { "2:49", "3:09", "2:50", "3:11", "3:07", "3:39", "3:19", "2:58", "2:41", "2:47", "3:49" };
            jaggedLengthArray[20] = new string[12] { "4:32", "3:22", "3:26", "3:27", "3:05", "4:03", "3:35", "3:01", "2:41", "3:13", "4:18", "3:04" };
            jaggedLengthArray[21] = new string[17] { "3:59", "3:14", "4:43", "4:34", "3:39", "3:55", "2:29", "5:40", "4:31", "4:09", "3:22", "4:32", "4:22", "0:59", "4:43", "3:58", "4:05" };
            jaggedLengthArray[22] = new string[12] { "4:56", "4:50", "4:10", "4:19", "4:41", "4:08", "4:38", "4:50", "3:26", "4:18", "5.33", "3:50" };
            jaggedLengthArray[23] = new string[7] { "3:00", "3:00", "2:42", "3:00", "3:18", "3:03", "3:07" };
            jaggedLengthArray[24] = new string[10] { "5:00", "3:13", "3:50", "3:45", "2:34", "3:45", "3:28", "4:26", "3:41", "4:41" };
            #endregion
            // Lista med alla album
            List<Album> albumsList = new List<Album>
            {
            new Album("I disagree", "Poppy", 9.3f, 2020, "45min", 100, 14, jaggedSongArray[0], jaggedFeaturingArray[0], jaggedLengthArray[0]),
            new Album("TIM", "Avicii", 9.9f, 2019, "38min", 100, 12, jaggedSongArray[1], jaggedFeaturingArray[1], jaggedLengthArray[1]),
            new Album("Dreamers", "JUNG", 7.7f, 2020, "33min", 100, 10, jaggedSongArray[2], jaggedFeaturingArray[2], jaggedLengthArray[2]),
            new Album("Doom Days", "Bastille", 7.4f, 2019, "40min", 100, 11, jaggedSongArray[3], jaggedFeaturingArray[3], jaggedLengthArray[3]),
            new Album("Väntar på en ängel", "Oskar Linnros", 6.9f, 2017, "39min", 100, 12, jaggedSongArray[4], jaggedFeaturingArray[4], jaggedLengthArray[4]),
            new Album("Är", "Snook", 6.3f, 2006, "41min", 100, 12, jaggedSongArray[5], jaggedFeaturingArray[5], jaggedLengthArray[5]),
            new Album("÷(Deluxe)", "Ed Sheeran", 7.6f, 2019, "59min", 100, 16, jaggedSongArray[6], jaggedFeaturingArray[6], jaggedLengthArray[6]),
            new Album("The Butterfly Effect", "Vargas & Lagola", 5.5f, 2019, "31min", 100, 11, jaggedSongArray[7], jaggedFeaturingArray[7], jaggedLengthArray[7]),
            new Album("CALM", "5 Seconds of Summer", 7.4f, 2019, "43min", 100, 13, jaggedSongArray[8], jaggedFeaturingArray[8], jaggedLengthArray[8]),
            new Album("Night & Day (Day Edition - Extra Tracks)", "The Vamps", 7.2f, 2019, "41min", 100, 12, jaggedSongArray[9], jaggedFeaturingArray[9], jaggedLengthArray[9]),
            new Album("IRL", "HUMAN", 8.2f, 2019, "38min", 100, 11, jaggedSongArray[10], jaggedFeaturingArray[10], jaggedLengthArray[10]),
            new Album("Prequelle", "Ghost", 7.5f, 2019, "41min", 100, 10, jaggedSongArray[11], jaggedFeaturingArray[11], jaggedLengthArray[11]),
            new Album("RAMMSTEIN", "Rammstein", 6.4f, 2019, "46min", 100, 11, jaggedSongArray[12], jaggedFeaturingArray[12], jaggedLengthArray[12]),
            new Album("Gone Now", "Bleachers", 5.8f, 2019, "40min", 100, 12, jaggedSongArray[13], jaggedFeaturingArray[13], jaggedLengthArray[13]),
            new Album("Evolve", "Imgine Dragons", 7.5f, 2019, "43min", 100, 12, jaggedSongArray[14], jaggedFeaturingArray[14], jaggedLengthArray[14]),
            new Album("Morgan Sulele", "Morgan Sulele", 4.7f, 2019, "23min", 100, 7, jaggedSongArray[15], jaggedFeaturingArray[15], jaggedLengthArray[15]),
            new Album("What If Nothing", "WALK THE MOON", 8.9f, 2019, "55min", 100, 13, jaggedSongArray[16], jaggedFeaturingArray[16], jaggedLengthArray[16]),
            new Album("COWBOY BEBOP Tank! THE! BEST!", "SEATBELTS", 4.2f, 2019, "50min", 100, 12, jaggedSongArray[17], jaggedFeaturingArray[17], jaggedLengthArray[17]),
            new Album("You Are OK", "The Maine", 7.1f, 2019, "44min", 100, 10, jaggedSongArray[18], jaggedFeaturingArray[18], jaggedLengthArray[18]),
            new Album("Pray For The Wicked", "Panic! At The Disco", 7.7f, 2019, "34min", 100, 11, jaggedSongArray[19], jaggedFeaturingArray[19], jaggedLengthArray[19]),
            new Album("AM", "Arctic Monkeys", 6.3f, 2019, "41min", 100, 12, jaggedSongArray[20], jaggedFeaturingArray[20], jaggedLengthArray[20]),
            new Album("Seal The Deal & Let's Boogie (Deluxe)", "Volbeat", 8.4f, 2019, "1h 6min", 100, 17, jaggedSongArray[21], jaggedFeaturingArray[21], jaggedLengthArray[21]),
            new Album("Affirmation", "Savage Garden", 5.8f, 2019, "53min", 100, 12, jaggedSongArray[22], jaggedFeaturingArray[22], jaggedLengthArray[22]),
            new Album("OMG What's Happening", "Ava Max", 6.6f, 2019, "21min", 100, 7, jaggedSongArray[23], jaggedFeaturingArray[23], jaggedLengthArray[23]),
            new Album("Svart, vitt och allt därimellan", "Daniel Adams-Ray", 7.8f, 2019, "38min", 100, 10, jaggedSongArray[24], jaggedFeaturingArray[24], jaggedLengthArray[24])
            };
        
            return albumsList;
        }
    }
}
