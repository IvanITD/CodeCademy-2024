using System;
using System.Linq.Expressions;

namespace ExquisiteCorpse_StartingMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exquisite Corpse Creature Builder!");
            Console.WriteLine("Select a mode:");
            Console.WriteLine("1. Random Creature Mode");
            Console.WriteLine("2. Manual Creature Mode");
            Console.WriteLine("Enter your choice (1 or 2):");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                RandomMode();
                break;

                case "2":
                ManualMode();
                break;

                default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
            }
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            Console.WriteLine($"Random Mode: Head: {head}, Body: {body}, Feet: {feet}");
            
            SwitchCaseRandom(head.ToString(), body.ToString(), feet.ToString());
        }

        static void ManualMode()
        {
            Console.WriteLine("You've chosen Manual Creature mode!");
            Console.WriteLine("Please enter the parts of the creature (ghost, bug, or monster) for head, body, and feet:");

            Console.Write("Head: ");
            string head = Console.ReadLine();

            Console.Write("Body: ");
            string body = Console.ReadLine();

            Console.Write("Feet: ");
            string feet = Console.ReadLine();

            SwitchCaseManual(head, body, feet);
        }

        static void SwitchCaseRandom(string head, string body, string feet)
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

        static void SwitchCaseManual(string head, string body, string feet)
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
    }
}