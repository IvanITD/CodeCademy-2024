namespace Money_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            // In the first section we need to ask the user for the amount for wich we will convert and capture the value in a variable!
            Console.WriteLine("Dear user! \nPlease input your amount, in order to be converted into coins!");
            string theAmount = Console.ReadLine();

            // Here we are going to convert the string variable into a double
            double amount = Convert.ToDouble(theAmount);

            // In this particular section we need to inform the user about the inputted amount, from the beginning. The printed text should say: "'amount' cents is equal to...".
            Console.WriteLine($"{amount} cents is equal to...");

            // Here we need to fine the value of each type of coin and then define two variables in wich we can put the values.
            int goldValue = 10;
            int silverValue = 5;

            // Now in order to find the maximum number of gold coins that can fit into the amount, we need to divide the amount by the value of the gold coins!
            double goldCoins = Math.Round(goldValue / amount);
            // Here we need to use the modulo in order to find the remaining amount and store it in a double variable!
            double remainder = amount % goldValue;

            // Now we have to find the maximum amount of silver coins that fit into the remainder. In order to find that, we need to divide the remainder by the value of a silver coin!
            double silverCoins = Math.Round(remainder / silverValue);

            // Here we need to find the remainder, in wich case the curent remainder are the "Bronze Coins"!
            remainder = remainder % silverValue;

            // Now we need to print out all of the coins. We need to take every variable that we collected as information and print it together with the first printed amount!
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder:F2}");
        }
    }
}
