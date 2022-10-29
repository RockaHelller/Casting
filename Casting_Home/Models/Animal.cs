using System;
using System.Collections.Generic;
using System.Text;

namespace Casting_Home.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void Eat();
    }
}
