using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock__Paper__Scissors
{
    class Validator
    {
        public static string ValidateOpponent(string OpponentChoice)
        {
            string opponent = "";
            bool cont = true;
            while (cont)
            {
                if (OpponentChoice == "j")
                {
                    opponent = "john";
                    cont = false;
                }
                else if (OpponentChoice == "s") 
                {
                    opponent = "stacey";
                    cont = false;
                }
                else
                {
                    Console.WriteLine("That is not john or stacey. Please input either a j or an s.");
                    continue;
                }
            }
            return opponent;
        }
        public static int ValidateUserChoice()
        {
            int userChoice1 = 0;
            bool cont = true;
            while(cont)
            {
                string userChoice = Console.ReadLine();
                if(userChoice == "1")
                {
                    userChoice1 = int.Parse(userChoice);
                    cont = false;
                }
                else if(userChoice == "2")
                {
                    userChoice1 = int.Parse(userChoice);
                    cont = false;
                }
                else if(userChoice == "3")
                {
                    userChoice1 = int.Parse(userChoice);
                    cont = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please give one of the corresponding numbers; rock = 1, paper = 2, scissors = 3");
                    continue;
                }
            }
            return userChoice1;
        }
        public static bool ValidateContinue()
        {
            Console.WriteLine("Would you like to play again?(y/n)");
            bool cont = true;
            bool cont1 = true;
            while(cont)
            {
                string answer = Console.ReadLine().ToLower();
                if(answer == "y")
                {
                    cont1 = true;
                    cont = false;
                }
                else if(answer == "n")
                {
                    Console.WriteLine("Goodbye.");
                    cont1 = false;
                    cont = false;
                }
                else
                {
                    Console.WriteLine("Invalid response, please enter y or n.");
                    continue;
                }
            }
            return cont1;
        }
    }
}
