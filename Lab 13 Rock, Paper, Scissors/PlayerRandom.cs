using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Rock__Paper__Scissors
{
    class PlayerRandom : Person
    {

        public PlayerRandom(string name, int roshambovalue ):base(name, roshambovalue)
        {
            name = "stacey";
            roshambovalue = 0;
        }
        //public override int generateRoshambo()
        //{
        //    Random random = new Random();
        //    Array choices = Enum.GetValues(typeof(int));
        //    int roshambovalue = (int)choices.GetValue(random.Next(choices.Length));
        //    return roshambovalue;
        //}
    }
}
