using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class Document : IDocument
    {
        public Document(string name)
        {
            this.Name = name;
        }
        public Document(string name, string content)
            :this(name)
        {
            this.Content = content;
        }

        public string Name { get; private set; }
        public string Content { get; private set; }

        public virtual string Information()
        {
            return this.Name + " " + this.Content;
        }
    }
}
