using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class JuniorStudent : Person
    {
        private List<int> allMarks;

        public JuniorStudent()
        {
            allMarks = new List<int>();
        }

        public List<int> Marks
        {
            get
            {
                return new List<int>(this.allMarks);
            }
        }

        public void AddMark(int mark)
        {
            this.allMarks.Add(mark);
        }
        public override string ToString()
        {
            return string.Join(" ", this.Marks);
        }

        protected override IEnumerable<string> Courses
        {
            get
            {
                return new List<string> { "Fundamentals of C#", "Gosho" };
            }
        }

    }
}
