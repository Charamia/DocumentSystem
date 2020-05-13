using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class SeniorStudent : Person
    {
        protected override IEnumerable<string> Courses
        {
            get
            {
                return new List<string> { "ASP.Net" };
            }
        }

    }
}
