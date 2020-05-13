using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAtItsFinest
{
   public class Students
    {
        public int Id { get; set; }
        public IEnumerable<Courses> Courses { get; set; }

        public Students()
        {
            this.Courses = new List<Courses>();
        }
    }
}
