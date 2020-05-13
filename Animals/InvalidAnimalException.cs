using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   public class InvalidAnimalException : ApplicationException
    {
        public string ErrorName { get; set; }
        public string ErrrorName { get; set; }

        public InvalidAnimalException(string msg)
            : base(msg)
        {

        }

        public InvalidAnimalException(string msg, string invalidName) 
            : base(msg + " " + invalidName)
        {
            this.ErrorName = invalidName;
        }
    }
}
