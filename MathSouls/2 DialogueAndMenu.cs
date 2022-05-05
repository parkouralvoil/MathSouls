using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSouls
{
    internal class DialogueAndMenu
    {
        public void Dialogue_Level1_Boss()
        {
            string Beadle = @"
      ////^\\\\
      | ^   ^ |
     @ (o) (o) @
      |   <   |
      |  ___  |
       \_____/
     ____|  |____
    /    \__/    \
   /              \
  /\_/|        |\_/\
 / /  |        |  \ \
( <   |        |   > )
 \ \  |        |  / /
  \ \ |________| / /
";

            Console.WriteLine(Beadle);
            Console.WriteLine("Hello! I am the Beadle (for my dialogue, press enter to continue)");
            Console.ReadKey();
            Console.WriteLine("I'm here to warn you of the upcoming boss fight, it'll be a much different enemy...");
            Console.ReadKey();
            Console.WriteLine("It will create division problems! To defeat it, you must input both:");
            Console.ReadKey();
            Console.WriteLine("The quotient and the remainder.");
            Console.ReadKey();
            Console.WriteLine("Like this!");
            Console.ReadKey();
            Console.WriteLine("EXAMPLE - 10 / 3 = ?");
            Console.ReadKey();
            Console.WriteLine("EXAMPLE - Input Quotient: 3");
            Console.ReadKey();
            Console.WriteLine("EXAMPLE - Input Remainder: 1");
            Console.ReadKey();
            Console.WriteLine("You need to get both right to damage the boss, or else you'll be counted as wrong!");
            Console.ReadKey();
            Console.WriteLine("I'll be going now! Good luck young mathematician! (dialogue ended)");
            Console.ReadKey();
        }
        public void Dialogue_Level2_Boss()
        {
            string Beadle = @"
      ////^\\\\
      | ^   ^ |
     @ (o) (o) @
      |   <   |
      |  ___  |
       \_____/
     ____|  |____
    /    \__/    \
   /              \
  /\_/|        |\_/\
 / /  |        |  \ \
( <   |        |   > )
 \ \  |        |  / /
  \ \ |________| / /
";

            Console.WriteLine(Beadle);
            Console.WriteLine("So you've defeated the inhabitants of the Forest of Intermediate Math... (for my dialogue, press enter to continue)");
            Console.ReadKey();
            Console.WriteLine("Nicely done!");
            Console.ReadKey();
            Console.WriteLine("However, the next boss is much harder than any you've faced yet.");
            Console.ReadKey();
            Console.WriteLine("It will create algebraic problems! To defeat it, you must solve for the value of x, ");
            Console.ReadKey();
            Console.WriteLine("in the equations it will give out.");
            Console.ReadKey();
            Console.WriteLine("These equations can use any of the 4 operations.");
            Console.ReadKey();
            Console.WriteLine("I'll give an example:");
            Console.ReadKey();
            Console.WriteLine("EXAMPLE - x/3 = 18");
            Console.ReadKey();
            Console.WriteLine("My solution would be to isolate x, such that ");
            Console.ReadKey();
            Console.WriteLine("x = 18 * 3");
            Console.ReadKey();
            Console.WriteLine("which gives me the answer, x = 54");
            Console.ReadKey();
            Console.WriteLine("I'll be going now! Good luck young mathematician! (dialogue ended)");
            Console.ReadKey();
        }
        public void Guide_menu()
        {
            Console.WriteLine("|Combat Mechanics|");
            Console.WriteLine("1. For each level, you will be given a select number of enemies to beat before proceeding to the boss");
            Console.WriteLine("2. Combat in this game involves answering generated math problems within a certain time limit (30 to 40 seconds)");
            Console.WriteLine("3. Incorrect answers, invalid inputs, or running out of time removes 1 Player HP");
            Console.WriteLine("4. Correct answers deal damage to the enemy. Answer quickly and you'll deal even more damage.");
            Console.WriteLine("5. After defeating all enemies and before facing the boss, you will heal 3 Player HP and receive guidance from an NPC.");
            Console.WriteLine("6. Level [2] allows you to choose 1 player upgrade");

            Console.WriteLine("\n|Other Stuff|");
            Console.WriteLine("1. Most of the statements in the game uses Thread.sleep (basically wait for a few seconds), so please refrain from inputting anything until the program tells you to do so");
            Console.WriteLine("2. EXCEPT if you meet the Friendly NPC, whose dialogue runs on Console.Readkey (basically press Enter to proceed to the next line)");
            Console.WriteLine("3. Just a suggestion, but for the harder levels (only lvl 2 atm), using a pen and paper to solve is recommended since the problems are harder to solve mentally");
            Console.WriteLine("4. Sound effects only play on basic enemies, while music only plays on boss. I can't play both at once due to SoundPlayer limitations :(");

            Console.WriteLine("\n|Music and Sound Effects used|");
            Console.WriteLine("Title Screen: Dark Souls 1 Character Creation music (https://www.youtube.com/watch?v=Ch0xO_Jm8_c&ab_channel=MotoiSakuraba-Topic)");
            Console.WriteLine("The Divider boss theme: boss battle music by trust pixels (https://www.youtube.com/watch?v=GkWtMPMrGTI&ab_channel=trustpixels)");
            Console.WriteLine("Knight X boss theme: FF6 Pixel Remaster boss theme (https://www.youtube.com/watch?v=LBxBvtQIUEs)");
            Console.WriteLine("Victory sound: Roblox Badge Giver sound (https://www.youtube.com/watch?v=hDgLKfplwqU&ab_channel=MyeHYT)");
            Console.WriteLine("Strong, Average, and Weak damage sound effects all from (https://www.zapsplat.com/)");
            Console.WriteLine("Player damaged sound: Minecraft Damage Oof (https://www.youtube.com/watch?v=0T_NR2KY8uI)");

            Console.WriteLine("\n|ASCII Artworks of enemies, bosses and Friendly NPC|");
            Console.WriteLine("Friendly NPC and all characters in Level 2 were obtained from the internet from various websites, such as,");
            Console.WriteLine("https://www.asciiart.eu/");
            Console.WriteLine("Level 1 Enemies created using https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20");
        }
        public void TitleScreen()
        {
            Console.WriteLine("     ▄▄▄▄███▄▄▄▄      ▄████████     ███        ▄█    █▄            ▄████████  ▄██████▄  ███    █▄   ▄█          ▄████████ ");
            Console.WriteLine("   ▄██▀▀▀███▀▀▀██▄   ███    ███ ▀█████████▄   ███    ███          ███    ███ ███    ███ ███    ███ ███         ███    ███ ");
            Console.WriteLine("   ███   ███   ███   ███    ███    ▀███▀▀██   ███    ███          ███    █▀  ███    ███ ███    ███ ███         ███    █▀  ");
            Console.WriteLine("   ███   ███   ███   ███    ███     ███   ▀  ▄███▄▄▄▄███▄▄        ███        ███    ███ ███    ███ ███         ███        ");
            Console.WriteLine("   ███   ███   ███ ▀███████████     ███     ▀▀███▀▀▀▀███▀       ▀███████████ ███    ███ ███    ███ ███       ▀███████████ ");
            Console.WriteLine("   ███   ███   ███   ███    ███     ███       ███    ███                 ███ ███    ███ ███    ███ ███                ███ ");
            Console.WriteLine("   ███   ███   ███   ███    ███     ███       ███    ███                 ███ ███    ███ ███    ███ ███                ███ ");
            Console.WriteLine("   ███   ███   ███   ███    ███     ███       ███    ███                 ███ ███    ███ ███    ███ ███                ███ ");
            Console.WriteLine("    ▀█   ███   █▀    ███    █▀     ▄████▀     ███    █▀          ▄████████▀   ▀██████▀  ████████▀  █████▄▄██  ▄████████▀  ");
        }
    }
}
