using System;
using System.Collections;
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

            string creatureChoice = Console.ReadLine();

            switch (creatureChoice)
            {
                case "1":
                RandomModeCreature();
                break;

                case "2":
                ManualModeCreature();
                break;

                default:
                Console.WriteLine("Invalid creature choice. Exiting program.");
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
                Console.WriteLine("Now just like before, select a mode:");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                Console.WriteLine();
                Console.WriteLine("1. Random Animal Mode");
                Console.WriteLine("2. Manual Animal Mode");

                // Just like before we are going to save the string variable of the user's choice in a string variable named animalChoice!
                string animalChoice = Console.ReadLine();

                switch (animalChoice)
            {
                case "1":
                RandomModeAnimal();
                break;

                case "2":
                ManualModeAnimal();
                break;

                default:
                Console.WriteLine("Invalid animal choice. Exiting program.");
                break;
            }
            // This is were the second part of the game ends!

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
                Console.WriteLine("Invalid creature head choice.");
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
                Console.WriteLine("Invalid creature body choice.");
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
                Console.WriteLine("Invalid creature feet choice.");
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
                Console.WriteLine("Invalid creature head choice.");
                return;
            }

            switch (body)
            {
                case "ghost":
                case "GHOST":
                case "Ghost":
                GhostBody();
                break;

                case "bug":
                case "BUG":
                case "Bug":
                BugBody();
                break;

                case "monster":
                case "MONSTER":
                case "Monster":
                MonsterBody();
                break;

                default:
                Console.WriteLine("Invalid creature body choice.");
                return;
            }

            switch (feet)
            {
                case "ghost":
                case "GHOST":
                case "Ghost":
                GhostFeet();
                break;

                case "bug":
                case "BUG":
                case "Bug":
                BugFeet();
                break;

                case "monster":
                case "MONSTER":
                case "Monster":
                MonsterFeet();
                break;

                default:
                Console.WriteLine("Invalid creature feet choice.");
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

        //Now we have to add both manual and random creator code process
        static void RandomModeAnimal()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 5);
            int body = randomNumber.Next(1, 5);
            int feet = randomNumber.Next(1, 5);
            
            SwitchCaseRandomAnimal(head.ToString(), body.ToString(), feet.ToString());
        }

        static void ManualModeAnimal()
        {
            Console.WriteLine("You've chosen Manual Creature mode!");
            Console.WriteLine("Please enter the parts of the creature (ghost, bug, or monster) for head, body, and feet:");

            Console.Write("Head: ");
            string head = Console.ReadLine();

            Console.Write("Body: ");
            string body = Console.ReadLine();

            Console.Write("Feet: ");
            string feet = Console.ReadLine();

            SwitchCaseManualAnimal(head, body, feet);
        }

        // Before the ASCII arts i'm going to write the methods that will contain the switch cases for the random and manual ASCII animal creator!
        static void SwitchCaseRandomAnimal(string head, string body, string feet)
        {
            switch (head)
            {
                case "1":
                DogHead();
                break;

                case"2":
                CatHead();
                break;

                case "3":
                FoxHead();
                break;

                case "4":
                BunnyHead();
                break;

                default:
                Console.WriteLine("Invalid animal head choice.");
                return;
            }

            switch (body)
            {
                case "1":
                DogBody();
                break;

                case "2":
                CatBody();
                break;

                case "3":
                FoxBody();
                break;

                case "4":
                BunnyBody();
                break;

                default:
                Console.WriteLine("Invalid animal body choice.");
                return;
            }

            switch (feet)
            {
                case "1":
                DogFeet();
                break;

                case "2":
                CatFeet();
                break;

                case "3":
                FoxFeet();
                break;

                case "4":
                BunnyFeet();
                break;

                default:
                Console.WriteLine("Invalid animal feet choice.");
                return;
            }
        }

        // Here I will add the methods that will contain the ASCII arts for the manual animals creation!
        static void SwitchCaseManualAnimal(string head, string body, string feet)
        {
            switch (head)
            {
                case "dog":
                case "DOG":
                case "Dog":
                DogHead();
                break;

                case "cat":
                case "CAT":
                case "Cat":
                CatHead();
                break;

                case "fox":
                case "FOX":
                case "Fox":
                FoxHead();
                break;
                
                case "bunny":
                case "BUNNY":
                case "Bunny":
                BunnyHead();
                break;

                default:
                Console.WriteLine("Invalid animal head choice.");
                return;
            }

            switch (body)
            {
                case "dog":
                case "DOG":
                case "Dog":
                DogBody();
                break;

                case "cat":
                case "CAT":
                case "Cat":
                CatBody();
                break;

                case "fox":
                case "FOX":
                case "Fox":
                FoxBody();
                break;

                case "bunny":
                case "BUNNY":
                case "Bunny":
                BunnyBody();
                break;

                default:
                Console.WriteLine("Invalid animal body choice.");
                return;
            }

            switch (feet)
            {
                case "dog":
                case "DOG":
                case "Dog":
                DogFeet();
                break;

                case "cat":
                case "CAT":
                case "Cat":
                CatFeet();
                break;

                case "fox":
                case "FOX":
                case "Fox":
                FoxFeet();
                break;

                case "bunny":
                case "BUNNY":
                case "Bunny":
                BunnyFeet();
                break;

                default:
                Console.WriteLine("Invalid animal feet choice.");
                return;
            }
        }

        //The first ones are going to be the ones that contain the ASCII art for the different animals!

        //Let's start with the Dog's Head!
        static void DogHead()
        {
            Console.WriteLine("(/(>*<)\\)");
        }

        //Now the Dog's Body!
        static void DogBody()
        {
            Console.WriteLine("   ___");
        }

        // And now the Dog's Feet!
        static void DogFeet()
        {
            Console.WriteLine("  /   \\");
        }


        // Now it's time for the Cat!

        // Let's start with the Cat's Head!
        static void CatHead()
        {
            Console.WriteLine(" /\\_/\\");
            Console.WriteLine("( o.o )");
        }

        //Now the Cat's Body!
        static void CatBody()
        {
            Console.WriteLine(" > ^ <");
		    Console.WriteLine("(u . u)");
        }

        // And now the Cat's Feet!
        static void CatFeet()
        {
            Console.WriteLine("( (.) )");
    		Console.WriteLine("(U   U)");
            
        }


        // Now it's time for the Fox!

        // Let's start with the Fox's Head!
        static void FoxHead()
        {
        Console.WriteLine("(\\___/)");
        Console.WriteLine("(=^.^=)");
        }

        // Now the Fox's Body!
        static void FoxBody()
        {
            Console.WriteLine(" > w <");
            Console.WriteLine("(o   o)");
        }

        // And now the Fox's Feet!
        static void FoxFeet()
        {
            Console.WriteLine("( ( ) )");
            Console.WriteLine("(O   O)");
        }


        // Now it's time for the Bunny!

        // Let's start with the Bunny's Head!
        static void BunnyHead()
        {
            Console.WriteLine(" (\\(\\");
		    Console.WriteLine(" (-.-)");

        }

        // Now the Bunny's Body!
        static void BunnyBody()
        {
            Console.WriteLine(" (u><u)");
        }

        // And now the Bunny's Feet!
        static void BunnyFeet()
        {
            Console.WriteLine("O(_(\")(\")");
        }
        
    }
}