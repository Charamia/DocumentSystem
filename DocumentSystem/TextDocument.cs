using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class TextDocument : Document, IDocument
    {
        public TextDocument(string name, string charset)
            :base(name)
        {
            this.Charset = charset;
        }

        public TextDocument(string name, string charset, string content)
            :base(name, content)
        {
            this.Charset = charset;
        }
       public string Charset { get; private set; }
    }
}
