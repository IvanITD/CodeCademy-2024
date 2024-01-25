using System.Collections;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      BuildACreature("ghost", "bug", "monster");
    }

    // Here I created a method where there is a switch case statement, in which there are going to be made different combinations of creature builds!
    static void BuildACreature(string head, string body, string feet)
    {
        switch (head)
        {
            case "ghost":
            GhostHead();
            break;
        }
        switch (body)
        {
            case "bug":
            BugBody();
            break;
        }
        switch (feet)
        {
            case "monster":
            MonsterFeet();
            break;
        }

    }

    static void RandomMode()
    {
        Random randomNumber = new Random();
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
      Console.WriteLine("　  (,___,)");
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
