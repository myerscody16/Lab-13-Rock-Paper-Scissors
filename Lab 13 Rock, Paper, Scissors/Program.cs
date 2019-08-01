using System;

namespace Lab_13_Rock__Paper__Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Person.GreetUser();
            bool cont = true;
            while (cont)
            {
                
                string opponent = Person.GetOpponent();
                Console.WriteLine($"{name}, please indicate your choice by inputting the corresponding number; rock = 1, paper = 2, scissors = 3");
                int userChoice = Validator.ValidateUserChoice();
                int playerChoice = 0;
                if (opponent == "john")
                {
                    playerChoice = 1;
                    RoshamboApp.PlayGame(name, opponent, userChoice, playerChoice);
                }
                else if (opponent == "stacey")
                {
                    playerChoice = Person.generateRoshambo();
                    RoshamboApp.PlayGame(name, opponent, userChoice, playerChoice);
                }
                cont = Validator.ValidateContinue(); 
            }
        }
        
    }
}   

