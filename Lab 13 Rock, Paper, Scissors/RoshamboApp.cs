using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock__Paper__Scissors
{
    class RoshamboApp 
    {
        public static void PlayGame(string userName, string playerName, int userChoice, int playerChoice)
        {
            if (userChoice == playerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (userChoice == 1 && playerChoice == 2)
            {
                Console.WriteLine($"{userName} has lost");
            }
            else if(userChoice == 2 && playerChoice == 3)
            {
                Console.WriteLine($"{userName} has lost");
            }
            else if (userChoice == 3 && playerChoice == 1)
            {
                Console.WriteLine($"{userName} has lost");
            }
            else if (userChoice == 2 && playerChoice == 1)
            {
                Console.WriteLine($"{userName} has won");
            }
            else if (userChoice == 3 && playerChoice == 2)
            {
                Console.WriteLine($"{userName} has won");
            }
            else if (userChoice == 1 && playerChoice == 3)
            {
                Console.WriteLine($"{userName} has won");
            }
        }
    }
}
