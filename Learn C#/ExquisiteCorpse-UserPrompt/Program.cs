using System;

namespace ExquisiteCorpse_UserPrompt
{
  class Program
  {
    static void Main(string[] args)
    {
      BuildCustomCreature(); // This is the RandomMode method, with which I created a random creature!
    }

    // Here I created a method where there is a switch case statement, in which there are going to be made different combinations of creature builds!
    static void BuildCustomCreature()
    {
      Console.WriteLine("Welcome to the Exquisite Corpse Creature Builder!\nChoose the head of your creature (ghost, bug, or monster):");
      string head = Console.ReadLine();

      Console.WriteLine("Choose the body of your creature (ghost, bug, or monster):");
      string body = Console.ReadLine();

      Console.WriteLine("Choose the feet of your creature (ghost, bug, or monster):");
      string feet = Console.ReadLine();

      SwitchCase(head, body, feet);
    }

    

    // Here I created a new custom method where I store my switch case statement
    static void SwitchCase(string head, string body, string feet)
    {
      switch (head)
      {
        case "ghost":
        GhostHead();
        break;

        case "bug":
        BugHead();
        break;

        case "monster":
        MonsterHead();
        break;

        default:
        Console.WriteLine("Invalid head choise.");
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
        Console.WriteLine("Invalid body choise.");
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

    // This written code is the the creature's parts, which are written in separated methods in order those methods to be used later!
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