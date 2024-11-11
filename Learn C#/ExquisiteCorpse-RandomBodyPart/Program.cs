using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ExquisiteCorpse_RandomBodyPart
{
  class Program
  {
    static void Main(string[] args)
    {
      RandomMode(); // This is the RandomMode method, with which I created a random creature!
    }

    // Here I created a method where there is a switch case statement, in which there are going to be made different combinations of creature builds!
    static void BuildACreature(string head = null, string body = null, string feet = null)
    {
      if (head == null)
      {
        head = GetRandomBodyPart();
      }
      else if (body == null)
      {
        body = GetRandomBodyPart();
      }
      else if(feet == null)
      {
        feet = GetRandomBodyPart();
      }
      
      SwitchCase(head, body, feet);
    }

    // Here I created a separate personal method which I called RandomMode
    static void RandomMode()
    {
        Random randomNumber = new Random();
        int head = randomNumber.Next(1, 4);
        int body = randomNumber.Next(1, 4);
        int feet = randomNumber.Next(1, 4);

        // Here I call the BuildACreature method in order to create a random creature!
        BuildACreature(TranslateToBodyPart(head), TranslateToBodyPart(body), TranslateToBodyPart(feet));
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
      }

    }

    // Here we create a new method named TranslateToNumber, which is going to translate the string into a number!
    static  string TranslateToBodyPart(int number)
    {

      switch (number)
      {
        case 1:
          return "ghost";
        
        case 2:
          return "bug";

        case 3:
          return "monster";

        default:
          return "ghost";
      }
      
    }

    // Here we create a new method named GetRandomBodyPart, which is going to return a random body part!
    static string GetRandomBodyPart()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4);

        switch (randomNumber)
        {
            case 1:
                return "ghost";

            case 2:
                return "bug";
            
            case 3:
                return "monster";
            
            default:
                return "ghost"; // The default case is the same as the first case if the value is unexpected! 
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
