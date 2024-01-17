namespace Choose_Your_Own_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");


            // Here I am printing the first sentence needed for the project!

            Console.WriteLine("It begins on a cold rainy night. " +
                "You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            // Here I'm using 'Console.WriteLine();' in order to ask the user to type the needed answer!

            Console.WriteLine("Type YES or NO:");

            // Here I am going to get the user's answer and then put it in a string variable named "noiseChoice"

            string noiseChoice = Console.ReadLine();

            // Here I made a little tweak, in case the user desides to use lower case letters. This function is going to, automaticaly change the letters to upper case!

            string uppernoiseChoice = noiseChoice.ToUpper();

        }
    }
}
