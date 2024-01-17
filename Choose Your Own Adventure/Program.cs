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

        }
    }
}
