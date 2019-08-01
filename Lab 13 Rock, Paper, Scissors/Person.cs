using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock__Paper__Scissors
{
    abstract class Person
    {
        public string Name { get; set; }
        public int RoshamboValue { get; set; }
        public Person(string name, int roshambovalue)
        {
            this.Name = name;
            this.RoshamboValue = roshambovalue;
        }
        public static string GreetUser()
        {
            Console.WriteLine("Welcome to rock, paper, scissors.");
            Console.WriteLine("Please enter your name.");
            string ans = Console.ReadLine();
            return ans;
        }
        public static int generateRoshambo()
        {
            Array choices = Roshambo.GetValues(typeof(Roshambo));
            Random random = new Random();
            int roshambovalue = (int)choices.GetValue(random.Next(choices.Length));
            return roshambovalue;
        }
        public static string GetOpponent()
        {
            Console.WriteLine("Would you like to play John or Stacey?(j/s)");
            string opponentChoice = Console.ReadLine().ToLower();
            string opponent = Validator.ValidateOpponent(opponentChoice);
            return opponent;
        }
        public enum Roshambo
        {
            rock = 1,
            paper,
            scissors
        }
    }
}
