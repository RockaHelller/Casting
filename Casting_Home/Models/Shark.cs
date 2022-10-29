using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_Home.Models
{
    public class Shark : Fish
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
