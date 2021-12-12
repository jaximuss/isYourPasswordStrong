using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace passwordChecker
{
    class Program
    {
        static void passWordCheck(string password)
        {
            //determining values for the password
            // minimum length of password
            int minlength = 9;
            //a tally score to say whether the password is strong or not
            int score = 0;
            //check if the password has uppercase
            bool hasUppercase = password.Any(char.IsUpper);
            if (hasUppercase == true)
            {
                score++;
            }
            char[] chartedPassword = password.ToCharArray();
            if (password.Length >= minlength)
            {
                score += 1;
            }
            // check if it has lower case
            bool hasLowercase = password.Any(char.IsLower);
            if (hasLowercase == true)
            {
                score++;
            }
            //check to see if it has a number
            bool hasNumber = password.Any(char.IsDigit);
            if (hasNumber == true)
            {
                score++;
            }

            //check to see if it has a special character
            //=> is a lamda expression that helps us put! infront of a method
            bool hasSpec = password.Any(doesnot => !char.IsLetterOrDigit(doesnot));
            if (hasSpec == true)
            {
                score++;
            }

            Console.WriteLine(score);
            switch (score)
            {
                case 1:
                    Console.WriteLine("your password is very weak");
                    break;
                case 2:
                    Console.WriteLine("your password isnt good enough");
                    break;
                case 3:
                    Console.WriteLine("your password is fair");
                    break;
                case 4:
                    Console.WriteLine("your password is strong");
                    break;
                case 5:
                    Console.WriteLine("your password is invicible");
                    break;

                default:
                    Console.WriteLine("error404 : please enter password");
                    break;
            }
        }
        static void Main(string[] args)
        {   //password checker

            Console.WriteLine("Enter a pass word make sure its strong");
            string password = Console.ReadLine();
            passWordCheck(password);
        }
    }
}
