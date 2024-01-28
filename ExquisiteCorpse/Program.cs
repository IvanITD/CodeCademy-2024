using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      BuildACreature("ghost", "bug", "monster"); // Here we have created a creature that has a head of a ghost, body of a bug, and feet of a monster!
      SwitchCase(1, 1, 1); // Here We have created a full ghost creature!
      RandomMode(); // The last one is a random one, and it kinda looks like a Hawaii female dancer!

    }

    // Here I created a method where there is a switch case statement, in which there are going to be made different combinations of creature builds!
    static void BuildACreature(string head, string body, string feet)
    {
      
    }

    // Here I created a separate personal method which I called RandomMode
    static void RandomMode()
    {
        Random randomNumber = new Random();
        int head = randomNumber.Next(1, 4);
        int body = randomNumber.Next(1, 4);
        int feet = randomNumber.Next(1, 4);

        // Here I call the SwitchCase method in order to create a random creature!
        SwitchCase(head, body, feet);
    }

    // Here I created a new custom method where I store my switch case statement
    static void SwitchCase(int head, int body, int feet)
    {
      switch (head)
      {
        case 1:
        GhostHead();
        break;

        case 2:
        BugHead();
        break;

        case 3:
        MonsterHead();
        break;
      }

      switch (body)
      {
        case 1:
        GhostBody();
        break;

        case 2:
        BugBody();
        break;

        case 3:
        MonsterBody();
        break;
      }
      switch (feet)
      {
        case 1:
        GhostFeet();
        break;

        case 2:
        BugFeet();
        break;

        case 3:
        MonsterFeet();
        break;
      }

    }

    // Here we create a new method named TranslateToNumber, which is going to translate the string into a number!
    static int TranslateToNumber(string creature)
    {
      int creatureNum;

      switch (creature)
      {
        case "ghost":
          creatureNum = 1;
        break;

        case "bug":
          creatureNum = 2;
        break;

        case "monster":
          creatureNum = 3;
        break;

        default:
          creatureNum = 1;
        break;
      }
      return creatureNum;
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
