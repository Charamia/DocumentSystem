using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public override int GetNumberOfLegs()
        {
            return 4; 
        }

        public override string Greet()
        {
            return "Mqu!";
        }
       
        public void Sleep()
        {
            Console.WriteLine("Mrrrr");
        }
    }
}
