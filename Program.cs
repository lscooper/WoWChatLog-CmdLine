using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChatLog
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] servers = new string[] { "AeriePeak", "Anvilmar", "Arathor", "Antonidas", "Azuremyst", "Baelgun", "BladesEdge", "Bladefist", "Bronzebeard", "Cenarius", "Darrowmere", "Draenor", "Dragonblight", "EchoIsles", "Galakrond", "Gnomeregan", "Hyjal", "Kilrogg", "Korialstrasz", "Lightbringer", "Misha", "Moonrunner", "Nordrassil", "Proudmoore", "Shadowsong", "Shu'Halo", "Silvermoon", "Skywall", "Suramar", "Uldum", "Uther", "Velen", "Windrunner", "Blackrock", "BlackwingLair", "Bonechewer", "Boulderfist", "Coilfang", "Crushridge", "Daggerspine", "DarkIron", "Destromath", "Dethecus", "Dragonmaw", "Dunemaul", "Frostwolf", "Gorgonnash", "Gurubashi", "Kalecgos", "Kil'Jaeden", "Lethon", "Maiev", "Nazjatar", "Ner'zhul", "Onyxia", "Rivendare", "ShatteredHalls", "Spinebreaker", "Spirestone", "Stonemaul", "Stormscale", "Tichondrius", "Ursin", "Vashj", "BlackwaterRaiders", "CenarionCircle", "Feathermoon", "Sentinels", "SilverHand", "TheScryers", "WyrmrestAccord", "TheVentureCo", "Kel'Thuzad", "Darkspear", "Deathwing", "Bloodscalp", "Nathrezim", "ShadowCouncil", "Aggramar", "Alexstrasza", "Alleria", "Blackhand", "BoreanTundra", "Cairne", "Dawnbringer", "Draka", "Eitrigg", "Fizzcrank", "Garona", "Ghostlands", "Greymane", "GrizzlyHills", "Hellscream", "Hydraxis", "Kael'thas", "KhazModan", "KulTiras", "Madoran", "Malfurion", "Malygos", "Mok'Nathal", "Muradin", "Nesingwary", "Quel'Dorei", "Ravencrest", "Rexxar", "Runetotem", "Sen'Jin", "Staghelm", "Terokkar", "Thunderhorn", "Vek'nilash", "Whisperwind", "Winterhoof", "Aegwynn", "Agamaggan", "Akama", "Archimonde", "Azgalor", "Azshara", "Balnazzar", "BloodFurnace", "BurningLegion", "Cho'gall", "Chromaggus", "Detheroc", "Drak'tharon", "Drak'thul", "Frostmane", "Garithos", "Gul'dan", "Hakkar", "Illidan", "Korgath", "LaughingSkull", "Mal'Ganis", "Malorne", "Mug'thol", "Stormreaver", "Sargeras", "TheUnderbog", "Thunderlord", "Wildhammer", "Farstriders", "KirinTor", "MoonGuard", "ScarletCrusade", "SistersofElune", "ThoriumBrotherhood", "EmeraldDream", "Lightninghoof", "Maelstrom", "TwistingNether", "Area52", "Arygos", "Bloodhoof", "Dalaran", "Drenden", "Durotan", "Duskwood", "Eldre'Thalas", "Elune", "Eonar", "Exodar", "Fenris", "Garrosh", "Gilneas", "GrizzlyHills", "Kargath", "Khadgar", "Llane", "Lothar", "Medivh", "Nazgrel", "Norgannon", "Shandris", "Stormrage", "Tanaris", "Thrall", "Trollbane", "Turalyon", "Uldaman", "Undermine", "Ysera", "Zul'jin", "AltarofStorms", "AlteracMountains", "Andorhal", "Anetheron", "Anub'arak", "Arthas", "Auchindoun", "BlackDragonflight", "BleedingHollow", "BurningBlade", "Dalvengyr", "DemonSoul", "Eredar", "Executus", "Firetree", "Gorefiend", "Haomarush", "Jaedenar", "Lightning'sBlade", "Mannoroth", "Magtheridon", "Scilla", "Shadowmoon", "ShatteredHand", "Skullcrusher", "Smolderthorn", "TheForgottenCoast", "Tortheldrin", "Warsong", "Ysondre", "Zuluhed", "ArgentDawn", "EarthenRing", "SteamwheedleCartel", "Aman'Thul", "Caelestrasz", "Dath'Remar", "Khaz'goroth", "Nagrand", "Saurfang", "Barthilas", "Dreadmaul", "Frostmourne", "Gundrak", "Jubei'Thos", "Thaurissan", "Quel'Thalas", "Drakkari", "Ragnaros", "Goldrinn", "Gallywix", "Azralon", "Nemesis", "TolBarad", "AeriePeak", "Aggramar", "Alonsus", "Anachronos", "Arathor", "Aszune", "Azjol-Nerub", "Azuremyst", "Blade'sEdge", "Bloodhoof", "Bronzebeard", "BronzeDragonflight", "ChamberofAspects", "Darkspear", "Doomhammer", "Draenor", "Dragonblight", "Eonar", "Ghostlands", "Hellfire", "Hellscream", "Khadgar", "Kilrogg", "KulTiras", "Lightbringer", "Nagrand", "Nordrassil", "Quel'Thalas", "Runetotem", "Saurfang", "Shadowsong", "Silvermoon", "Stormrage", "Terenas", "Terokkar", "Thunderhorn", "Turalyon", "Vek'nilash", "Wildhammer", "Agamaggan", "Al'Akir", "Ahn'Qiraj", "Auchindoun", "Balnazzar", "Bladefist", "Bloodfeather", "Bloodscalp", "Boulderfist", "BurningBlade", "BurningLegion", "BurningSteppes", "Chromaggus", "Crushridge", "Daggerspine", "Darksorrow", "Deathwing", "Dentarg", "Dragonmaw", "Drak'thul", "Dunemaul", "Emeriss", "Executus", "Frostmane", "Frostwhisper", "Genjuros", "GrimBatol", "Haomarush", "Hakkar", "Jaedenar", "Karazhan", "Kazzak", "Kor'gall", "LaughingSkull", "Lightning'sBlade", "Magtheridon", "Mazrigos", "Neptulon", "Outland", "Ragnaros", "Ravencrest", "ShatteredHalls", "ShatteredHand", "Skullcrusher", "Spinebreaker", "Stormreaver", "Stormscale", "Sunstrider", "Sylvanas", "Talnivarr", "TarrenMill", "TheMaelstrom", "Trollbane", "Twilight'sHammer", "TwistingNether", "Vashj", "Xavius", "Zenedar", "ArgentDawn", "DarkmoonFaire", "EarthenRing", "Moonglade", "SteamwheedleCartel", "TheSha'tar", "DefiasBrotherhood", "Ravenholdt", "ScarshieldLegion", "Sporeggar", "TheVentureCo", "Dalaran", "Drek'Thar", "Eitrigg", "Elune", "Hyjal", "KhazModan", "Krasus", "Medivh", "Suramar", "Uldaman", "Vol'jin", "Arak-arahm", "Arathi", "Archimonde", "Cho'gall", "Eldre'Thalas", "Garona", "Illidan", "Kael'Thas", "Naxxramas", "Ner'zhul", "Rashgarroth", "Sargeras", "Sinstralis", "Templenoir", "Throk'Feroth", "Varimathras", "Ysondre", "KirinTor", "LesClairvoyants", "LesSentinelles", "ConseildesOmbres", "CultedelaRiveNoire", "Alexstrasza", "Alleria", "Aman'Thul", "Ambossar", "Antonidas", "Area52", "Arygos", "Baelgun", "Blackhand", "DunMorogh", "Durotan", "Gilneas", "Kargath", "Khaz'goroth", "Lordaeron", "Lothar", "Madmortem", "Malfurion", "Malygos", "Nethersturm", "Norgannon", "Nozdormu", "Perenolde", "Proudmoore", "Rexxar", "Sen'jin", "Shattrath", "Teldrassil", "Thrall", "Tirion", "Ysera", "Aegwynn", "Anetheron", "Anub'arak", "Arthas", "Azshara", "Blackmoore", "Blackrock", "Blutkessel", "Dalvengyr", "Destromath", "Dethecus", "Echsenkessel", "Eredar", "Frostmourne", "Frostwolf", "Gorgonnash", "Gul'dan", "Kel'Thuzad", "Kil'Jaeden", "Krag'jin", "Mal'Ganis", "Mannoroth", "Mug'thol", "Nathrezim", "Nazjatar", "Nefarian", "Nera'thor", "Onyxia", "Rajaxx", "Taerar", "Terrordar", "DerMithrilorden", "DerRatvonDalaran", "DieAldor", "DieewigeWacht", "DieNachtwache", "DieSilberneHand", "Forscherlig", "Todeswache", "ZirkeldesCenarius", "Theradras", "Tichondrius", "Un'Goro", "Vek'lor", "Wrathbringer", "Zuluhed", "ColinasPardas", "Exodar", "LosErrantes", "Minahonda", "Tyrande", "C'Thun", "DunModr", "Sanguino", "Shen'dralar", "Uldum", "Zul'jin", "Nemesis" };

            //moose is debugging directory input
            Console.WriteLine(Directory.GetCurrentDirectory());

            //Initialization begins
            //Get number of characters
            Console.WriteLine("Enter the number of characters who were involved in this RP.");
            string charNumString = Console.ReadLine();
            int charNum = Convert.ToInt32(charNumString);
            Person[] people = new Person[charNum];

            //Prompt user to enter character information
            Console.WriteLine("You will now be prompted to enter the names for each character involved in this RP. Please enter the information for your character first.");
            while (charNum > 0)
            {
                Console.WriteLine("Enter the name of a character as seen in-game: ");
                string inGame = Console.ReadLine();
                Console.WriteLine("Enter the name of that character as it should be displayed: ");
                string name = Console.ReadLine();
                people[charNum - 1] = new Person(inGame, name);
                charNum--;
            }

            //Load the input file. Default value is WoWChatLog.txt in the current directory.
            Console.WriteLine("Enter the location of the chatlog you would like to use, including the file name and extension, or type N to use the default value.");
            string locationInput = Console.ReadLine();
            Console.WriteLine(LogLocation(locationInput));
            //Validate input file.

            /*Except it's not working so I've commented it out.
            if (!File.Exists(locationInput))
            {
                Console.WriteLine("Chatlog not found. Please double-check the location and try again.");
                Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
                System.Environment.Exit(0);
            }*/

            //Dump input file into an array.
            string[] lines = System.IO.File.ReadAllLines(LogLocation(locationInput));
            List<string> toBeWritten = new List<string>();

            //Get location to write file to. Default location is a timestamped .txt file in the current directory.
            Console.WriteLine("Enter the location where you would like to have your output go, including the file name and extension, or type N to use the default value.");
            string locationOutput = Console.ReadLine();
            Console.WriteLine(OutputLocation(locationOutput));

            //Parsing begins!
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(OutputLocation(locationOutput), true))

            {


                //Notifies user that parsing has begun
                Console.WriteLine("Parsing....");


                foreach (string line in lines)
                {
                    //All lines need to get the timestamp chopped off.
                    string noTime = ElimTimestamp(line);
                    //Check for lines to contain names or to be a player emote
                    string lineName = NameContained(noTime, people);
                    if (lineName != null && !IsOOC(noTime) && !IsLogin(noTime))
                    {
                        if (IsEmote(noTime))
                        {
                            Console.WriteLine("Emote found in line: " + line);
                            if (noTime.StartsWith("You"))
                            {
                                Console.WriteLine("Player emote being parsed.");
                                toBeWritten.Add(ParsePlayerEmote(noTime, people[people.Length-1].GetDisplayName()));
                            }
                            else if(!noTime.StartsWith("You"))
                            {
                                string noServer = ElimServer(noTime, servers, lineName, people);
                                string parsedLine = lineName + noServer;
                                toBeWritten.Add(parsedLine);
                            }
                        }
                        else if(!IsEmote(noTime))
                        {
                            string noServer = ElimServer(noTime, servers, lineName, people);
                            string parsedLine = lineName + noServer;
                            toBeWritten.Add(parsedLine);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Line does not contain a valid player name.");
                    }

                }

                foreach (string chatline in toBeWritten)
                {
                    file.WriteLine(chatline);
                }

            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Parsing successful! Press any key to exit.");
            //  System.Diagnostics.Process.Start(locationOutput);
            System.Console.ReadKey();
            //  System.Environment.Exit(0);

        }

        static bool IsLogin(string line)
        {
            if (line.Contains("OFFLINE") || line.Contains("ONLINE") || line.Contains("offline") || line.Contains("online") || line.Contains("is currently playing"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsOOC(string line)
        {
            if (line.Contains('(') && line.Contains(')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string LogLocation(string input)
        {
            string output;
            if (input == "N")
            {
                output = Path.Combine(Directory.GetCurrentDirectory(), "\\WoWChatLog.txt");
                return output;
            }
            else if (input == "D")
            {
                output = @"D:\World of Warcraft\_retail_\Logs\WoWChatLog.txt";
                return output;
            }
            else
            {
                output = input;
                return output;
            }
        }

        static string OutputLocation(string input)
        {
            string output;
            if (input == "N")
            {
                DateTime localDate = DateTime.Now;
                string date = localDate.ToString();
                string location = "\\ParsedLog" + date + ".txt";
                output = Path.Combine(Directory.GetCurrentDirectory(), location);
                return output;
            }
            else if (input == "D")
            {
                output = @"D:\World of Warcraft\_retail_\Logs\ParsedLog.txt";
                return output;
            }
            else
            {
                output = input;
                return output;
            }
        }

        static string NameContained(string input, Person[] people)
        {
            if (input.StartsWith("You"))
            {
                Console.WriteLine("Line is emote from player.");
                return people[people.Length - 1].GetDisplayName();
            }
            else
            {
                foreach (Person player in people)
                {

                    if (input.Contains(player.GetGameName()))
                    {
                        Console.WriteLine("Line contains name: " + player.GetGameName());
                        return player.GetDisplayName();
                    }
                }
            }
            return null;

        }

        static string ElimServer(string input, string[] servers, string name, Person[] people)
        {
            string output;
            int substringLoc;
            foreach (string server in servers)
            {
                if (input.Contains(server))
                {
                    Console.WriteLine("Server name: " + server);
                    substringLoc = input.IndexOf(server) + server.Length;
                    output = input.Substring(substringLoc);
                    return output;
                }

            }
            string gameName = FindGameName(name, people);
            substringLoc = input.IndexOf(gameName) + gameName.Length;
            output = input.Substring(substringLoc);
            return output;
        }

        static string ElimTimestamp(string input)
        {
            if (input.Length < 19)
            {
                String failedOutput = input;
                return failedOutput;
            }
            string output = input.Substring(19);
            Console.WriteLine(output);
            return output;
        }

        static bool IsEmote(string input)
        {
            if (input.Contains(":"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static string ParsePlayerEmote(string input, string name) 
        {
            string parsedLine = input.Substring(3);
            string firstHalf;
            string secondHalf;

            int spaceOne = parsedLine.IndexOf(" ");
            int spaceTwo = parsedLine.IndexOf(" ", spaceOne + 1);

            if (spaceTwo == -1)
            {
                int periodLoc = parsedLine.IndexOf(".");
                firstHalf = parsedLine.Substring(0, periodLoc) + "s";
                secondHalf = ".";
                parsedLine = firstHalf + secondHalf;
                parsedLine = name + parsedLine;
            }
            else
            {
                firstHalf = parsedLine.Substring(0, spaceTwo) + "s";
                secondHalf = parsedLine.Substring(spaceTwo);
                parsedLine = firstHalf + secondHalf;
                parsedLine = name + parsedLine;
            }

            return parsedLine;
        }

        public class Person
        {
            private string inGame;
            private string display;

            public Person(string inGameName, string displayName)
            {
                inGame = inGameName;
                display = displayName;
            }

            public string GetGameName()
            {
                return inGame;
            }

            public string GetDisplayName()
            {
                return display;
            }
        }

        static string FindGameName(string name, Person[] people)
        {
            foreach(Person player in people)
            {
                if(player.GetDisplayName() == name)
                {
                    return player.GetGameName();
                }
            }
            return null;
        }


    }
}




