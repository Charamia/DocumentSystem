using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public abstract class Person : IPerson
    {
        public string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                if(value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than 2 symbols");
                }
                this.Name = value;
            }
        }


        protected abstract IEnumerable<string> Courses { get; } 

        public string GetAllCourses()
        {
            return string.Join(" ", this.Courses);
        }
    }
}
