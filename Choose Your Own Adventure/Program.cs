using System.Net.NetworkInformation;
using System.Threading.Tasks;

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
            string upperNoiseChoice = noiseChoice.ToUpper();

            // Here I added an if-else statement in order the user to have more options, after the YES or NO answer!
            if (upperNoiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room! \nTHE END.");
            }
            else if (upperNoiseChoice == "YES") // Here we wrote an else if statement to have a second option if the user chooses to answer YES
            {
                // Added some more story to the game in order for the user to be able to continue!
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. \nYou walk towards it. Do you open it or knock?");

                /* Here we are asking the user to type the answer he prefers!
                 * After we get the user's answer we have to save it in a string variable named doorChoice! Later on we change the case letters into upper case! */
                Console.WriteLine("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine();
                string upperDoorChoice = doorChoice.ToUpper();

                // Now we wrote and if/if-else statement in order to give multiple answers to the user's answer choice!
                if (upperDoorChoice == "KNOCK")
                {
                    // Here I wrote an print code in order to print the text for the story
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \nPoor people have it. " +
                    "Rich people need it. If you eat it you die. What is it?");


                    // We ask the user to answer the riddle by typing his prefered answer!
                    // After that we save the answer in a string variable named riddleAnswer!
                    Console.WriteLine("Type your answer: ");
                    string riddleAnswer = Console.ReadLine();
                    string upperRiddleAnswer = riddleAnswer.ToUpper(); // Added this code so that when the user types the write answer, so that it prints with upper case letters!

                    // The right answer to this question is "NOTHING", and now an if-else statement is going to make that work corectly
                    if (upperRiddleAnswer == "NOTHING")
                    {
                        Console.WriteLine($"The door opens and {upperRiddleAnswer} is there. \nYou turn off the lights and run back to your room and lock the door. \nTHE END.");
                    }
                    else // If the user answers anything else we should print this text
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open. \nTHE END.");
                    }

                }
                else if (upperDoorChoice == "OPEN")
                {
                    // Now we have to check IF the condition is true, then we need to print the written text to the user!
                    Console.WriteLine("The door is locked! See if one of you three keys will open it.");
                }




            }





        }
    }
}
