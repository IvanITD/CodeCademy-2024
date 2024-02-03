using System;
using System.Linq.Expressions;

namespace ExquisiteCorpse_ASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exquisite Corpse Creature Builder!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
            Console.WriteLine();
            Console.WriteLine("Select a mode:");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
            Console.WriteLine();
            Console.WriteLine("1. Random Creature Mode");
            Console.WriteLine("2. Manual Creature Mode");
            Console.WriteLine("Enter your choice (1 or 2):");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                RandomModeCreature();
                break;

                case "2":
                ManualModeCreature();
                break;

                default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
            }
            // This is were the first part of the game ends!


            //SECOND PART OF THE GAME!



            // This is the second part of the game!
            Console.WriteLine();
            Console.WriteLine("Did you like the ASCII art?");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // Here I asked the user if he/she liked the ASCII art.
            Console.WriteLine();
            Console.WriteLine("If yes, then continue playing the game, because I have a little surprise for you!");
            Console.WriteLine("If no, then exit the program.");
            
            // Here I asked the user to specify his answer with yes or no!

            Console.WriteLine("Please specify your answer with (yes or no):");

            // Here I'm saving the user's answer in a string variable named usersAnswer!
            string usersAnswer = Console.ReadLine();
            
            // Now I'm checking if the user's answer is yes or no! If it isn't either one, then I will tell him a joke question, something like "Go on then, whats your answer?".
            if (usersAnswer == "Yes" || usersAnswer == "YES" || usersAnswer == "yes" || usersAnswer == "y" || usersAnswer == "Y")
            {
                Console.WriteLine();
                Console.WriteLine("GREAT!!! OMG I LOVE ASCII ART!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine("Oops sorry I didn't mean to startle you with my excitement!");
                Console.WriteLine("Now let's continue playing the game!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Welcome to \"Exquisite Corpse and the animal maker\"");
                Console.WriteLine("Part 2 ot the game!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine("I hope you enjoyed the ASCII arts!\nBut don't go, I think you'll love them!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                // Just like before we will add the same optional functions, manual or random!

            }
            else if (usersAnswer == "No" || usersAnswer == "NO" || usersAnswer == "no" || usersAnswer == "n" || usersAnswer == "N")
            {
                Console.WriteLine();
                Console.WriteLine("Ok, then! You can exit the game!");

                Console.WriteLine();
                Console.WriteLine("Thanks for Playing!");
                Console.WriteLine("Press ESC key to exit...");
                
                // Here I add the key ESC as a valid key to exit the game!
                ConsoleKeyInfo keyInfo;
                do
                {
                    keyInfo = Console.ReadKey(true); // Read key without displaying it on the console.
                    
                    if (keyInfo.Key == ConsoleKey.Escape) // Check if the pressed key is the ESC key.
                    {
                        
                        Console.WriteLine("Exiting! Thanks for Playing!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"In order to exit the game, press the ESC key! You pressed {keyInfo.KeyChar}.");
                    }
                }
                while (true);
            }
        }

        static void RandomModeCreature()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            Console.WriteLine($"Random Mode: Head: {head}, Body: {body}, Feet: {feet}");
            
            SwitchCaseRandomCreature(head.ToString(), body.ToString(), feet.ToString());
        }

        static void ManualModeCreature()
        {
            Console.WriteLine("You've chosen Manual Creature mode!");
            Console.WriteLine("Please enter the parts of the creature (ghost, bug, or monster) for head, body, and feet:");

            Console.Write("Head: ");
            string head = Console.ReadLine();

            Console.Write("Body: ");
            string body = Console.ReadLine();

            Console.Write("Feet: ");
            string feet = Console.ReadLine();

            SwitchCaseManualCreature(head, body, feet);
        }

        static void SwitchCaseRandomCreature(string head, string body, string feet)
        {
            switch (head)
            {
                case "1":
                GhostHead();
                break;

                case"2":
                BugHead();
                break;

                case "3":
                MonsterHead();
                break;

                default:
                Console.WriteLine("Invalid head choice.");
                return;
            }

            switch (body)
            {
                case "1":
                GhostBody();
                break;

                case "2":
                BugBody();
                break;

                case "3":
                MonsterBody();
                break;

                default:
                Console.WriteLine("Invalid body choice.");
                return;
            }

            switch (feet)
            {
                case "1":
                GhostFeet();
                break;

                case "2":
                BugFeet();
                break;

                case "3":
                MonsterFeet();
                break;

                default:
                Console.WriteLine("Invalid feet choice.");
                return;
            }
        }

        static void SwitchCaseManualCreature(string head, string body, string feet)
        {
            switch (head)
            {
                case "ghost":
                GhostHead();
                break;

                case"bug":
                BugHead();
                break;

                case "monster":
                MonsterHead();
                break;

                default:
                Console.WriteLine("Invalid head choice.");
                return;
            }

            switch (body)
            {
                case "ghost":
                GhostBody();
                break;

                case "bug":
                BugBody();
                break;

                case "monster":
                MonsterBody();
                break;

                default:
                Console.WriteLine("Invalid body choice.");
                return;
            }

            switch (feet)
            {
                case "ghost":
                GhostFeet();
                break;

                case "bug":
                BugFeet();
                break;

                case "monster":
                MonsterFeet();
                break;

                default:
                Console.WriteLine("Invalid feet choice.");
                return;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("   (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }





        // SECOND PART OF GAME CODE!
        // Here I'll write the code for the second part of the game.
        // Firstly I have to add some methods that are going to be used in the second part of the game.

        //The first ones are going to be the ones that contain the ASCII art for the different animals!

    }
}