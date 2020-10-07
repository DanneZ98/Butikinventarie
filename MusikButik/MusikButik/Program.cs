using System;
using System.Collections.Generic;

namespace MusikButik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Butik myButik = new Butik();
            bool menuRun = true;
            // Lista med filmer
            #region Movie List
            List<Movies> moviesList = new List<Movies>();
            moviesList.Add(new Movies("Parasite", "Bong Joon Ho", 8.6f, 2019, "2h 12min", 100));
            moviesList.Add(new Movies("Knives Out", "Rian Johnson", 7.9f, 2019, "2h 10min", 100));
            moviesList.Add(new Movies("Joker", "Todd Phillips", 8.5f, 2019, "2h 2min", 100));
            moviesList.Add(new Movies("Avengers: Endgame", "Anthony Russo, Joe Russo", 8.4f, 2019, "3h 1min", 100));
            moviesList.Add(new Movies("Avengers: Infinity War", "Anthony Russo, Joe Russo", 8.4f, 2018, "2h 29min", 100));
            moviesList.Add(new Movies("The Dark Knight", "Christopher Nolan", 9.1f, 2008, "2h 32min", 100));
            moviesList.Add(new Movies("The Dark Knight Rises", "Christopher Nolan", 8.4f, 2012, "2h 44min", 100));
            moviesList.Add(new Movies("Jojo Rabbit", "Taika Waititi", 7.9f, 2019, "1h 48min ", 100));
            moviesList.Add(new Movies("The Prestige", "Christopher Nolan", 8.5f, 2006, "2h 10min ", 100));
            moviesList.Add(new Movies("The Wolf of Wall Street", "Martin Scorsese", 8.2f, 2013, "3h 0min", 100));
            moviesList.Add(new Movies("The Shawshank Redemption", "Frank Darabont", 9.3f, 1994, "2h 22min", 100));
            moviesList.Add(new Movies("Dunkirk", "Christopher Nolan", 7.9f, 2017, "1h 46min", 100));
            moviesList.Add(new Movies("The Lighthouse", "Robert Eggers", 7.5f, 2019, "1h 49min", 100));
            moviesList.Add(new Movies("The Greatest Showman", "Michael Gracey", 7.6f, 2017, "1h 45min", 100));
            moviesList.Add(new Movies("Gods of Egypt", "Alex Proyas", 5.4f, 2016, "2h 7min", 100));
            moviesList.Add(new Movies("The Lord of the Rings: The Fellowship of the Ring", "Peter Jackson", 8.8f, 2001, "2h 58min", 100));
            moviesList.Add(new Movies("The Lord of the Rings: The Two Towers", "Peter Jackson", 8.7f, 2002, "2h 59min", 100));
            moviesList.Add(new Movies("The Lord of the Rings: The Return of the King", "Peter Jackson", 8.9f, 2003, "3h 21min", 100));
            moviesList.Add(new Movies("Fight Club", "David Fincher", 8.8f, 1999, "2h 19min", 100));
            moviesList.Add(new Movies("Forrest Gump", "Robert Zemeckis", 8.8f, 1994, "2h 22min", 100));
            moviesList.Add(new Movies("Inception", "Christopher Nolan", 8.8f, 2010, "2h 28min", 100));
            moviesList.Add(new Movies("Catch Me If You Can", "Steven Spielberg", 8.1f, 2002, "2h 21min", 100));
            moviesList.Add(new Movies("Your Name.", "Makoto Shinkai", 8.4f, 2016, "1h 46min", 100));
            moviesList.Add(new Movies("A Silent Voice: The Movie", "Naoko Yamada", 8.2f, 2016, "2h 10min", 100));
            moviesList.Add(new Movies("Wolf Children", "Mamoru Hosoda", 8.1f, 2012, "1h 57min", 100));
            #endregion
            // Jagged array med låtar
            #region Song Jagged Array
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
            // Lista med album
            #region Album List
            List<Albums> albumsList = new List<Albums>();
            albumsList.Add(new Albums("I disagree", "Poppy", 9.3f, 2020, "45min", 100, 14, jaggedSongArray[0], jaggedFeaturingArray[0], jaggedLengthArray[0]));
            albumsList.Add(new Albums("TIM", "Avicii", 9.9f, 2019, "38min", 100, 12, jaggedSongArray[1], jaggedFeaturingArray[1], jaggedLengthArray[1]));
            albumsList.Add(new Albums("Dreamers", "JUNG", 7.7f, 2020, "33min", 100, 10, jaggedSongArray[2], jaggedFeaturingArray[2], jaggedLengthArray[2]));
            albumsList.Add(new Albums("Doom Days", "Bastille", 7.4f, 2019, "40min", 100, 11, jaggedSongArray[3], jaggedFeaturingArray[3], jaggedLengthArray[3]));
            albumsList.Add(new Albums("Väntar på en ängel", "Oskar Linnros", 6.9f, 2017, "39min", 100, 12, jaggedSongArray[4], jaggedFeaturingArray[4], jaggedLengthArray[4]));
            albumsList.Add(new Albums("Är", "Snook", 6.3f, 2006, "41min", 100, 12, jaggedSongArray[5], jaggedFeaturingArray[5], jaggedLengthArray[5]));
            albumsList.Add(new Albums("÷(Deluxe)", "Ed Sheeran", 7.6f, 2019, "59min", 100, 16, jaggedSongArray[6], jaggedFeaturingArray[6], jaggedLengthArray[6]));
            albumsList.Add(new Albums("The Butterfly Effect", "Vargas & Lagola", 5.5f, 2019, "31min", 100, 11, jaggedSongArray[7], jaggedFeaturingArray[7], jaggedLengthArray[7]));
            albumsList.Add(new Albums("CALM", "5 Seconds of Summer", 7.4f, 2019, "43min", 100, 13, jaggedSongArray[8], jaggedFeaturingArray[8], jaggedLengthArray[8]));
            albumsList.Add(new Albums("Night & Day (Day Edition - Extra Tracks)", "The Vamps", 7.2f, 2019, "41min", 100, 12, jaggedSongArray[9], jaggedFeaturingArray[9], jaggedLengthArray[9]));
            albumsList.Add(new Albums("IRL", "HUMAN", 8.2f, 2019, "38min", 100, 11, jaggedSongArray[10], jaggedFeaturingArray[10], jaggedLengthArray[10]));
            albumsList.Add(new Albums("Prequelle", "Ghost", 7.5f, 2019, "41min", 100, 10, jaggedSongArray[11], jaggedFeaturingArray[11], jaggedLengthArray[11]));
            albumsList.Add(new Albums("RAMMSTEIN", "Rammstein", 6.4f, 2019, "46min", 100, 11, jaggedSongArray[12], jaggedFeaturingArray[12], jaggedLengthArray[12]));
            albumsList.Add(new Albums("Gone Now", "Bleachers", 5.8f, 2019, "40min", 100, 12, jaggedSongArray[13], jaggedFeaturingArray[13], jaggedLengthArray[13]));
            albumsList.Add(new Albums("Evolve", "Imgine Dragons", 7.5f, 2019, "43min", 100, 12, jaggedSongArray[14], jaggedFeaturingArray[14], jaggedLengthArray[14]));
            albumsList.Add(new Albums("Morgan Sulele", "Morgan Sulele", 4.7f, 2019, "23min", 100, 7, jaggedSongArray[15], jaggedFeaturingArray[15], jaggedLengthArray[15]));
            albumsList.Add(new Albums("What If Nothing", "WALK THE MOON", 8.9f, 2019, "55min", 100, 13, jaggedSongArray[16], jaggedFeaturingArray[16], jaggedLengthArray[16]));
            albumsList.Add(new Albums("COWBOY BEBOP Tank! The! best!", "SEATBELTS", 4.2f, 2019, "50min", 100, 12, jaggedSongArray[17], jaggedFeaturingArray[17], jaggedLengthArray[17]));
            albumsList.Add(new Albums("You Are OK", "The Maine", 7.1f, 2019, "44min", 100, 10, jaggedSongArray[18], jaggedFeaturingArray[18], jaggedLengthArray[18]));
            albumsList.Add(new Albums("Pray For The Wicked", "Panic! At The Disco", 7.7f, 2019, "34min", 100, 11, jaggedSongArray[19], jaggedFeaturingArray[19], jaggedLengthArray[19]));
            albumsList.Add(new Albums("AM", "Arctic Monkeys", 6.3f, 2019, "41min", 100, 12, jaggedSongArray[20], jaggedFeaturingArray[20], jaggedLengthArray[20]));
            albumsList.Add(new Albums("Seal The Deal & Let's Boogie (Deluxe)", "Volbeat", 8.4f, 2019, "1h 6min", 100, 17, jaggedSongArray[21], jaggedFeaturingArray[21], jaggedLengthArray[21]));
            albumsList.Add(new Albums("Affirmation", "Savage Garden", 5.8f, 2019, "53min", 100, 12, jaggedSongArray[22], jaggedFeaturingArray[22], jaggedLengthArray[22]));
            albumsList.Add(new Albums("OMG What's Happening", "Ava Max", 6.6f, 2019, "21min", 100, 7, jaggedSongArray[23], jaggedFeaturingArray[23], jaggedLengthArray[23]));
            albumsList.Add(new Albums("Svart, vitt och allt därimellan", "Daniel Adams-Ray", 7.8f, 2019, "38min", 100, 10, jaggedSongArray[24], jaggedFeaturingArray[24], jaggedLengthArray[24]));
            #endregion
            
            // Välkommnar användaren till butiken och informerar om utbudet
            Console.WriteLine("Välkommen till Hans-Johnnys butik!");
            Console.WriteLine("Här har vi 25 unika filmer och 25 unika album");
            Console.WriteLine("Och bäst av allt. Varje produkt kostar endast 100 kr!");

            // While loop for att köra menyn
            while(menuRun == true)
            {
                // Meny text
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Meny");
                Console.WriteLine("0) Skriv ut filmer");
                Console.WriteLine("1) Skriv ut album");
                Console.WriteLine("2) Skriv ut låtar i specifikt album");
                Console.WriteLine("3) Skriv ut all låtar");
                Console.WriteLine("4) Skriv ut adresser");
                Console.WriteLine("5) Rensa konsolen");
                Console.WriteLine("6) Avsluta program");
                // Variabel för användar inmatning
                int input = 0;
                // Try-catch för att ta in användar inmatning utan att programmet kraschar ifall det skulle gå snett
                try
                {
                    // Tar in användar inmatningen
                    string menuInput = Console.ReadLine();
                    // Trimmar fram och bak för att det inte ska bli fel om användaren råkat få med ett mallanslag
                    menuInput.Trim();
                    // försöker konvertera användar inmatningen till en integer
                    input = Convert.ToInt32(menuInput);
                }
                // Informerar användaren om att det blivit fel och ber den att mata in ett värde mellan 0 och 6
                catch
                {
                    Console.WriteLine("Felaktig inmatning. Mata in 0-6");
                }
                // Använder inmatningen i en switch case sats för att köra koden för den funktion användaren valt
                switch (input)
                {
                    case 0:
                        // Kallar på print movies metoden och för med listan med filmer
                        Movies.Print(moviesList);
                        break;
                    case 1:
                        // Kallar på print albums metoden och för med listan med album
                        Albums.Print(albumsList);
                        break;
                    case 2:
                        {
                            // Kallar på metod för att få ut vilket album användaren vill kolla på
                            // Resultatet av metoden lagras i en variabel
                            int browse = Albums.PrintSongsSpecificAlbum(albumsList);
                            // Variabeln används för att skriva ut låtar på valt album
                            albumsList[browse].PrintSongs();
                        }
                        break;
                    case 3:
                        // For loop som går genom alla album och skriver ut låtarna
                        for (int i = 0; i < albumsList.Count; i++)
                        {
                            Console.WriteLine();
                            Console.WriteLine(albumsList[i].name);
                            albumsList[i].PrintSongs();
                        }
                        break;
                    case 4:
                        // Kallar på metod för att skriva ut adresser
                        myButik.PrintAdress();
                        break;
                    case 5:
                        // Rensar upp i konsolen 
                        Console.Clear();
                        break;
                    case 6:
                        // Sätter bool variabeln till false och därmed avslutar loopen som kör menyn
                        menuRun = false;
                        break;
                    default:
                        // fångar upp värden som avviker från valen som finns
                        Console.WriteLine("Felaktig inmatning. Mata in 0-6");
                        break;
                }

            }
            Console.WriteLine("Välkommen åter");
        }
    }
}
