namespace Password_Checker
{
    public class Tools
    {
        public Tools()
        {

        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        public static void ContainsTest()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Here we will write all the needed requirements for a newly writen password. 

            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~`!@#$%^&*()_-+={[}]|<>.?/";

            // Now we will ask the user to enter a password and capture their input in a variable!

            Console.WriteLine("Dear user! \nPlease input your desired password!");
            string userPassword = Console.ReadLine();
            int passwordLength = userPassword.Length;

            // Now we need to score the users inputted password, in order to see if it meets the requirements!

            int score = 0;

            if (passwordLength >= minLength)
            {
                score++;
            }

            // Here we need to give a score point to the user, if he has added an upper case to the password

            bool upperCaseChecker = Tools.Contains(userPassword, upperCase);
            if (upperCaseChecker == true)
            {
                score++;
            }

            // Here we score the user, only if he added lowe case to his password

            bool lowerCaseChecker = Tools.Contains(userPassword, lowerCase);
            if (lowerCaseChecker == true)
            {
                score++;
            }

            //If the password contains digits, we add one point to the score!

            bool digitsChecker = Tools.Contains(userPassword, digits);
            if (digitsChecker == true)
            {
                score++;
            }

            // Now if the password contains special characters, we need to add a point to the score!

            bool specialCharsChecker = Tools.Contains(userPassword, specialChars);
            if (specialCharsChecker == true)
            {
                score++;
            }


            // Another functionality for the password checker is the just "password" word usage. In that case we give the user 0 score points and we tell him that the password doesn't meet the standarts!

            if (userPassword == "password")
            {
                score = 0;
                Console.WriteLine("The password doesn't meet any of the standarts!");
            }
            else
            {

            }
            // Here we need to print the total collected score, up until now!

            Console.WriteLine(score);


            // Now that we checked our program we need to inform the user how he did with the password!

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("The password is extremely strong!");
                    break;

                case 3:
                    Console.WriteLine("The password is strong!");
                    break;

                case 2:
                    Console.WriteLine("The password is medium!");
                    break;

                case 1:
                    Console.WriteLine("The password is weak!");
                    break;

                default:
                    Console.WriteLine("The password doesn't meet any of the standarts!");
                    break;
            }

            // Now we need to make some checks to the program to see if everything is working in proper order!
            // 1) First try / "word" scores 1 - prints => The password is weak! (Success)
            // 2) Second try / "woRD scores 2 - prints => The password is medium! (Success)
            // 3) Third try / 1woRD scores 3 - prints => The password is strong! (Success)
            // 4) Fourth try / 2woRDsss scores 4 - prints => The password is extremely strong! (Success)
            // 5) Fifth try / 2woRDsss!  scores 5 - prints => The password is extremely strong, AGAIN! (Success)
            // 6) Sixth try / " " scores 0 - prints => The password doesn't meet any of the standarts (Success)
        }
    }
}
