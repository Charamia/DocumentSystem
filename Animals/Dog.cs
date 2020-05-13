using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {

        public bool IsAsleep { get; set; }

        public override int GetNumberOfLegs()
        {
            return 4;
        }

        public override string Greet()
        {
            return base.Greet() + " - Djav!";
        }

        public void Run()
        {
            Console.WriteLine("I am running!");
        }
    }
}
