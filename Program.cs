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
            Console.WriteLine("Enter the number of characters who were involved in this RP.");
            string charNumString = Console.ReadLine();
            int charNum = Convert.ToInt32(charNumString);
            Person[] people = new Person[charNum];
            string[] servers = new string[] { "AeriePeak", "Anvilmar", "Arathor", "Antonidas", "Azuremyst", "Baelgun", "BladesEdge", "Bladefist", "Bronzebeard", "Cenarius", "Darrowmere", "Draenor", "Dragonblight", "EchoIsles", "Galakrond", "Gnomeregan", "Hyjal", "Kilrogg", "Korialstrasz", "Lightbringer", "Misha", "Moonrunner", "Nordrassil", "Proudmoore", "Shadowsong", "Shu'Halo", "Silvermoon", "Skywall", "Suramar", "Uldum", "Uther", "Velen", "Windrunner", "Blackrock", "BlackwingLair", "Bonechewer", "Boulderfist", "Coilfang", "Crushridge", "Daggerspine", "DarkIron", "Destromath", "Dethecus", "Dragonmaw", "Dunemaul", "Frostwolf", "Gorgonnash", "Gurubashi", "Kalecgos", "Kil'Jaeden", "Lethon", "Maiev", "Nazjatar", "Ner'zhul", "Onyxia", "Rivendare", "ShatteredHalls", "Spinebreaker", "Spirestone", "Stonemaul", "Stormscale", "Tichondrius", "Ursin", "Vashj", "BlackwaterRaiders", "CenarionCircle", "Feathermoon", "Sentinels", "SilverHand", "TheScryers", "WyrmrestAccord", "TheVentureCo", "Kel'Thuzad", "Darkspear", "Deathwing", "Bloodscalp", "Nathrezim", "ShadowCouncil", "Aggramar", "Alexstrasza", "Alleria", "Blackhand", "BoreanTundra", "Cairne", "Dawnbringer", "Draka", "Eitrigg", "Fizzcrank", "Garona", "Ghostlands", "Greymane", "GrizzlyHills", "Hellscream", "Hydraxis", "Kael'thas", "KhazModan", "KulTiras", "Madoran", "Malfurion", "Malygos", "Mok'Nathal", "Muradin", "Nesingwary", "Quel'Dorei", "Ravencrest", "Rexxar", "Runetotem", "Sen'Jin", "Staghelm", "Terokkar", "Thunderhorn", "Vek'nilash", "Whisperwind", "Winterhoof", "Aegwynn", "Agamaggan", "Akama", "Archimonde", "Azgalor", "Azshara", "Balnazzar", "BloodFurnace", "BurningLegion", "Cho'gall", "Chromaggus", "Detheroc", "Drak'tharon", "Drak'thul", "Frostmane", "Garithos", "Gul'dan", "Hakkar", "Illidan", "Korgath", "LaughingSkull", "Mal'Ganis", "Malorne", "Mug'thol", "Stormreaver", "Sargeras", "TheUnderbog", "Thunderlord", "Wildhammer", "Farstriders", "KirinTor", "MoonGuard", "ScarletCrusade", "SistersofElune", "ThoriumBrotherhood", "EmeraldDream", "Lightninghoof", "Maelstrom", "TwistingNether", "Area52", "Arygos", "Bloodhoof", "Dalaran", "Drenden", "Durotan", "Duskwood", "Eldre'Thalas", "Elune", "Eonar", "Exodar", "Fenris", "Garrosh", "Gilneas", "GrizzlyHills", "Kargath", "Khadgar", "Llane", "Lothar", "Medivh", "Nazgrel", "Norgannon", "Shandris", "Stormrage", "Tanaris", "Thrall", "Trollbane", "Turalyon", "Uldaman", "Undermine", "Ysera", "Zul'jin", "AltarofStorms", "AlteracMountains", "Andorhal", "Anetheron", "Anub'arak", "Arthas", "Auchindoun", "BlackDragonflight", "BleedingHollow", "BurningBlade", "Dalvengyr", "DemonSoul", "Eredar", "Executus", "Firetree", "Gorefiend", "Haomarush", "Jaedenar", "Lightning'sBlade", "Mannoroth", "Magtheridon", "Scilla", "Shadowmoon", "ShatteredHand", "Skullcrusher", "Smolderthorn", "TheForgottenCoast", "Tortheldrin", "Warsong", "Ysondre", "Zuluhed", "ArgentDawn", "EarthenRing", "SteamwheedleCartel", "Aman'Thul", "Caelestrasz", "Dath'Remar", "Khaz'goroth", "Nagrand", "Saurfang", "Barthilas", "Dreadmaul", "Frostmourne", "Gundrak", "Jubei'Thos", "Thaurissan", "Quel'Thalas", "Drakkari", "Ragnaros", "Goldrinn", "Gallywix", "Azralon", "Nemesis", "TolBarad", "AeriePeak", "Aggramar", "Alonsus", "Anachronos", "Arathor", "Aszune", "Azjol-Nerub", "Azuremyst", "Blade'sEdge", "Bloodhoof", "Bronzebeard", "BronzeDragonflight", "ChamberofAspects", "Darkspear", "Doomhammer", "Draenor", "Dragonblight", "Eonar", "Ghostlands", "Hellfire", "Hellscream", "Khadgar", "Kilrogg", "KulTiras", "Lightbringer", "Nagrand", "Nordrassil", "Quel'Thalas", "Runetotem", "Saurfang", "Shadowsong", "Silvermoon", "Stormrage", "Terenas", "Terokkar", "Thunderhorn", "Turalyon", "Vek'nilash", "Wildhammer", "Agamaggan", "Al'Akir", "Ahn'Qiraj", "Auchindoun", "Balnazzar", "Bladefist", "Bloodfeather", "Bloodscalp", "Boulderfist", "BurningBlade", "BurningLegion", "BurningSteppes", "Chromaggus", "Crushridge", "Daggerspine", "Darksorrow", "Deathwing", "Dentarg", "Dragonmaw", "Drak'thul", "Dunemaul", "Emeriss", "Executus", "Frostmane", "Frostwhisper", "Genjuros", "GrimBatol", "Haomarush", "Hakkar", "Jaedenar", "Karazhan", "Kazzak", "Kor'gall", "LaughingSkull", "Lightning'sBlade", "Magtheridon", "Mazrigos", "Neptulon", "Outland", "Ragnaros", "Ravencrest", "ShatteredHalls", "ShatteredHand", "Skullcrusher", "Spinebreaker", "Stormreaver", "Stormscale", "Sunstrider", "Sylvanas", "Talnivarr", "TarrenMill", "TheMaelstrom", "Trollbane", "Twilight'sHammer", "TwistingNether", "Vashj", "Xavius", "Zenedar", "ArgentDawn", "DarkmoonFaire", "EarthenRing", "Moonglade", "SteamwheedleCartel", "TheSha'tar", "DefiasBrotherhood", "Ravenholdt", "ScarshieldLegion", "Sporeggar", "TheVentureCo", "Dalaran", "Drek'Thar", "Eitrigg", "Elune", "Hyjal", "KhazModan", "Krasus", "Medivh", "Suramar", "Uldaman", "Vol'jin", "Arak-arahm", "Arathi", "Archimonde", "Cho'gall", "Eldre'Thalas", "Garona", "Illidan", "Kael'Thas", "Naxxramas", "Ner'zhul", "Rashgarroth", "Sargeras", "Sinstralis", "Templenoir", "Throk'Feroth", "Varimathras", "Ysondre", "KirinTor", "LesClairvoyants", "LesSentinelles", "ConseildesOmbres", "CultedelaRiveNoire", "Alexstrasza", "Alleria", "Aman'Thul", "Ambossar", "Antonidas", "Area52", "Arygos", "Baelgun", "Blackhand", "DunMorogh", "Durotan", "Gilneas", "Kargath", "Khaz'goroth", "Lordaeron", "Lothar", "Madmortem", "Malfurion", "Malygos", "Nethersturm", "Norgannon", "Nozdormu", "Perenolde", "Proudmoore", "Rexxar", "Sen'jin", "Shattrath", "Teldrassil", "Thrall", "Tirion", "Ysera", "Aegwynn", "Anetheron", "Anub'arak", "Arthas", "Azshara", "Blackmoore", "Blackrock", "Blutkessel", "Dalvengyr", "Destromath", "Dethecus", "Echsenkessel", "Eredar", "Frostmourne", "Frostwolf", "Gorgonnash", "Gul'dan", "Kel'Thuzad", "Kil'Jaeden", "Krag'jin", "Mal'Ganis", "Mannoroth", "Mug'thol", "Nathrezim", "Nazjatar", "Nefarian", "Nera'thor", "Onyxia", "Rajaxx", "Taerar", "Terrordar", "DerMithrilorden", "DerRatvonDalaran", "DieAldor", "DieewigeWacht", "DieNachtwache", "DieSilberneHand", "Forscherlig", "Todeswache", "ZirkeldesCenarius", "Theradras", "Tichondrius", "Un'Goro", "Vek'lor", "Wrathbringer", "Zuluhed", "ColinasPardas", "Exodar", "LosErrantes", "Minahonda", "Tyrande", "C'Thun", "DunModr", "Sanguino", "Shen'dralar", "Uldum", "Zul'jin", "Nemesis" };

            while (charNum > 0)
            {
                Console.WriteLine("Enter the name of a character as seen in-game: ");
                string inGame = Console.ReadLine();
                Console.WriteLine("Enter the name of that character as it should be displayed: ");
                string name = Console.ReadLine();
                people[charNum - 1] = new Person(inGame, name);
                charNum--;
            }
            Console.WriteLine("Enter the location of the chatlog you would like to use, including the file name and extension, or type N to use the default value.");
            string locationInput = Console.ReadLine();
            Console.WriteLine(logLocation(locationInput));
            string[] lines = System.IO.File.ReadAllLines(logLocation(locationInput));
            List<string> toBeWritten = new List<string>();

            Console.WriteLine("Enter the location where you would like to have your output go, including the file name and extension, or type N to use the default value.");
            string locationOutput = Console.ReadLine();
            Console.WriteLine(outputLocation(locationOutput));
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(outputLocation(locationOutput), true))
            {
                foreach (Person player in people)
            {
                Console.WriteLine(player.GetDisplayName() + " " + player.GetGameName());
            }
            Console.WriteLine("Parsing....");


            foreach (string line in lines)
            {

                
                    if (!isOOC(line) && isNameContained(line, people) && !beenParsed(line, toBeWritten))
                    {
                         if (!line.Contains('[') && !isLogin(line) && !beenParsed(line, toBeWritten))
                        {
                            int trimIndex = line.IndexOf("  ") + 2;



                            int lineLength = line.Length - trimIndex;
                            // Console.WriteLine(line);
                            if (!line.Contains(':'))
                            {
                                // file.WriteLine("All lines parsed: Emote.");
                                break;
                            }

                            //{

                            string trimmedLine = line.Substring(trimIndex, lineLength);
                            string noServerLine = ParseEmote(trimmedLine, servers);
                            toBeWritten.Add(noServerLine);

                            // }
                        }
                        if (!line.Contains(':'))
                        {
                            file.WriteLine("All lines parsed: Name.");
                         
                        }
                        else
                        {
                            string chatLine = ParseChatLine(line, whichGameName(line, people), whichDisplayName(line, people));
                            //file.WriteLine(chatLine + "\r\n");
                            toBeWritten.Add(chatLine);
                         
                        }
                    }
                 
    
                }
                foreach(string chatline in toBeWritten)
                {
                    file.WriteLine(chatline);
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }

        static string ParseEmote(string line, string[] servers)
        {
            int serverTrimIndex;
            int trimLength;
            string noServer;
            foreach (string servername in servers)
            {
                if (line.Contains(servername))
                {
                    Console.WriteLine("Server found: " + servername);
                    serverTrimIndex = line.IndexOf(servername);
                    trimLength = servername.Length - 1;
                    noServer = line.Remove(serverTrimIndex, trimLength);
                    return noServer;
                }
                else
                {
                    return line;
                }
                  

            }
            return line;
        }
        static string ParseChatLine(string line, string name, string realName)
        {
            int trimIndex = line.IndexOf(name);
            int lineLength = line.Length - trimIndex;
            string dateRemoved = line.Substring(trimIndex, lineLength);
            int trimIndex2 = dateRemoved.IndexOf(':') + 2;
            int lineLength2 = dateRemoved.Length - trimIndex2;
            string trimmedLine = dateRemoved.Substring(trimIndex2, lineLength2);
            trimmedLine = trimmedLine.Insert(0, getPrename(realName));
            return trimmedLine;
        }

        static string getPrename(string name)
        {
            string preName = name + ": ";
            return preName;
        }

        static bool isLogin(string line)
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

        static bool isOOC(string line)
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

        static string logLocation(string input)
        {
            string output;
            if (input == "N")
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

        static string outputLocation(string input)
        {
            string output;
            if (input == "N")
            {
                Console.WriteLine("Enter your Windows username.");
                string name = Console.ReadLine();
                output = @"C:\\Users\\" + name + "\\Documents\\ParsedLog.txt";
                return output;
            }
            else
            {
                output = input;
                return output;
            }
        }

        static bool isNameContained(string input, Person[] people)
        {
            foreach (Person player in people)
            {
                Console.WriteLine(input + " : " + player.GetGameName());
                if (input.Contains(player.GetGameName()))
                {
                    Console.WriteLine("Name found!");
                    return true;
                }

            }
            return false;

        }

        static string whichGameName(string input, Person[] people)
        {

            foreach (Person player in people)
            {
                if (input.Contains(player.GetGameName()))
                {
                    return player.GetGameName();
                }
            }
            return null;
        }

        static string whichDisplayName(string input, Person[] people)
        {

            foreach (Person player in people)
            {
                if (input.Contains(player.GetGameName()))
                {
                    return player.GetDisplayName();
                }
            }
            return null;
        }

        static bool beenParsed(string input, List<string> parsed)
        {
            foreach (string chatline in parsed)
            {

                if (parsed.Contains(input))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;

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


       
    }
}




