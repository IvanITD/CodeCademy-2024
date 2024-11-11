namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is about "Mad Libs" game, and we will need to write a code that will help the user pick only the words for his story. The story should be written by us. The user should only input the required text that will fill the written story.
            Author: Ivan Ivanov
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Dear user! \nWelcome to the game of Mad Libs!");

            // Give the Mad Lib a title:
            string title = "WORDIE";

            Console.WriteLine(title);
            // Define user input and variables:

            // Here we're asking the user to type a name that he desires, for the main character!
            Console.WriteLine("Dear user! \nPlease input a name that we can call you!");
            string mainCharacterName = Console.ReadLine();

            // Here we ask the user to type three different adjectives and save them in three different variables. The variables are named differently in order to be used later for the story!
            Console.WriteLine($"Dear user! \nPlease write three different adjectives. Adjectives could be words like: color (red), texture (hard) or a feeling (silly).");
            string adjective1 = Console.ReadLine();
            string adjective2 = Console.ReadLine();
            string adjective3 = Console.ReadLine();

            // Here we ask the user to input a verb, in order to be inoputted into the story!
            Console.WriteLine($"Dear user! \nPlease write one verb of your choice. The verb must be something like: sit, sleep or eat. \nChoose your prefered one and input it in the console app!");
            string verb = Console.ReadLine();

            // Here we ask the user to input two nouns, in order to be added to our story!
            Console.WriteLine($"Dear user! \nPlease input two different nouns of your choice. It could be a person (girl), a place (cabin), or thing (toaster). \nMake your choices and write them in the console!");
            string noun1 = Console.ReadLine();
            string noun2 = Console.ReadLine();

            // At this point we have a little bit of progress. Here we have to ask the user to input one of each of the following: animal, food, fruit, superhero, country, dessert, year.

            Console.WriteLine($"Dear user! \nAt this point you have made some inputs already, and now is the most valiable point of the game. \nPlease input one of each of the following: \nAn animal \nA food \nA fruit \nA superhero \nA country \nA dessert \nA year");
            string animal = Console.ReadLine();
            string food = Console.ReadLine();
            string fruit = Console.ReadLine();
            string superhero = Console.ReadLine();
            string country = Console.ReadLine();
            string dessert = Console.ReadLine();
            string year = Console.ReadLine();



            // The template for the story:

            /* In this final section we've added every variable, that we took as input from the user, and used it in the story,
             *in a particular way. The order of the variables are as it goes: Name, First adjective, Second adjective, Animal, Food, Verb, First noun, Fruit, Third adjective, Name, Superhero, Name, Country, Name, Dessert, Name, Year, Second Noun.
             */
            string story = $"This morning {mainCharacterName} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' " +
                $"Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. " +
                $"Concerned, {mainCharacterName} texted {superhero}, who flew {mainCharacterName} to {country} and dropped {mainCharacterName} in a puddle of frozen {dessert}. " +
                $"{mainCharacterName} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:

            // Finaly we can print the whole story and show it to the user!
            Console.WriteLine(story);

            // Thank the user for playing the game and make sure to advice him to try it again!

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Congratulations user!!! \nYou just finished our game and created a new story! \nIf you liked it, make sure you try it again, but this time with different words and options of your choice! \nEnjoy The Game!");

            // THE END!!!
            //________________________________________
        }
    }
}
