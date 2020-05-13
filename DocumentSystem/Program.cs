using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class Program
    {
        static void Main()
        {
            WordDocument wrdDoc = new WordDocument("Pesho", "Pesho", 11, "2014", 5);

            List<IDocument> allDocs = new List<IDocument>();
            allDocs.Add(wrdDoc);

        }
    }
}
