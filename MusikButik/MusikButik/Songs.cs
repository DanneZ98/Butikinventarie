using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MusikButik
{
    class Songs
    {
        /*
        public string songName;
        public string songLength;
        public string featArtists;

        public Songs(string _songName, string _songLength)
        {
            songName = _songName;
            songLength = _songLength;
            featArtists = null;
        }
        public Songs(string _songName, string _songLength, string _featArtists)
        {
            songName = _songName;
            songLength = _songLength;
            featArtists = _featArtists;
        }
        */
        /*
        class Songs : Albums
    {
         //Inventory myInventory = new Inventory();
         public string songName;
         public string songLength;
         public string featArtists;

        public Songs(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price, byte _numberOfSongs, string _songName, string _songLength) : base (_name, _creator, _rating, _releaseDate, _duration, _price, _numberOfSongs)
        {
            songName = _songName;
            songLength = _songLength;
            featArtists = null;
        }
        public Songs(string _name, string _creator, float _rating, int _releaseDate, string _duration, int _price, byte _numberOfSongs, string _songName, string _songLength, string _featArtists) : base(_name, _creator, _rating, _releaseDate, _duration, _price, _numberOfSongs)
        {
            songName = _songName;
            songLength = _songLength;
            featArtists = _featArtists;
        }
        */
        /*
        #region maybe
        
         public void AlbumSongs() 
         { 
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
            jaggedSongArray[15] = new string[7] { "Helgedigg", "Bare min", "Din sang", "Jeg vil heller ha deg", "Min kabin", "Lakenet", "Lakenet - Beachbraaten Remix"};
            jaggedSongArray[16] = new string[13] { "Press Restart", "Headphones", "One Foot", "Surrender", "All I Want", "All Night", "Kamikaze", "Tiger Teeth", "Sound Of Awakening", "Feels Good To Be High", "Can't Sleep (Wolves)", "In My Mind", "Lost In The Wild" };
            jaggedSongArray[17] = new string[12] { "Tank! - TV stretch", "What Planet Is This.", "Cosmic Dare (Pretty With A Pistol)", "Diamonds", "Don't Bother None - TV Edit", "Piano Black", "Mushroom Hunting", "No Reply", "Blue", "Einstein Groovin'", "Pearls", "Gotta Knock A Little Harder" };
            jaggedSongArray[18] = new string[10] { "Slip the Noose", "My Best Habit", "Numb Without You", "I Feel It All Over", "Heaven, We're Already There", "Forevermore", "Tears Wont Cry (ShinjU)", "One Sunset", "Broken Parts", "Flowers on the Grave" };
            jaggedSongArray[19] = new string[11] { "(Fuck A)Silver Lining", "Say Amen (Saturday Night)", "Hey Look Ma, I Made It", "High Hopes", "Roaring 20s", "Dancing's Not a Crime", "One of the Drunks", "The Overpass", "King of the Clouds", "Old Fashioned", "Dying in LA" };
            jaggedSongArray[20] = new string[12] { "Do I Wanna Know?", "R U Mine?", "One For The Road", "Arabella", "I Want It All", "No.1 Party Anthem", "Mad Sounds", "Fireside", "Why'd You Only Call Me When You're High?", "Snap Out Of It", "Knee Socks", "I Wanna be Yours" };
            jaggedSongArray[21] = new string[17] { "The Devil's Bleeding Crown", "Marie Laveau", "For Evigt", "The Gates Of Babylon", "Let It Burn", "Black Rose", "Rebound", "Mary Jane Kelly", "Goodbye Forever", "Seal The Deal", "Battleship Chains", "You Will Know", "The Loa's Crossroad", "Slaytan", "The Bliss", "Black Rose", "The Devils's Bleeding Crown - Live" };
            jaggedSongArray[22] = new string[12] { "Affirmation", "Hold Me", "I Knew I Loved You", "The Best Thing", "Crash And Burn", "Chained to You", "The Animal Song", "The Lover After Me", "Two Beds And A Coffee Machine", "You Can Still Be Free", "Gunning Down Romance", "I Don't Know Anymore"};
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
            jaggedFeaturingArray[23] = new string[7] { null, null, null, null, null, null, null};
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

            Albums myAlbums = new Albums();
            for (int i = 0; i < jaggedSongArray.Length; i++)
            {
                Console.WriteLine(myAlbums.Name[i]);
                string[] individualSongArray = jaggedSongArray[i];
                string[] individualSongLengthArray = jaggedLengthArray[i];
                string[] individualSongFeaturingArray = jaggedFeaturingArray[i];
                for (int j = 0; j < individualSongArray[i].Length; j++)
                {
                    if (individualSongFeaturingArray[j] == null) 
                    { 
                        Console.WriteLine($"{individualSongArray[j]} {individualSongLengthArray[j]}");
                    }
                    else 
                    { 
                        Console.WriteLine($"{individualSongArray[j]} featuring {individualSongFeaturingArray[j]} {individualSongLengthArray[j]}");
                    }
                }
                Console.WriteLine();
            }
         
         }
        
        #endregion*/
    }
}
