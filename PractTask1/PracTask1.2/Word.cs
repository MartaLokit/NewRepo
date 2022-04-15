using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PracTask1._2
{
    public class Word
    {
        private Symbol[] symbols;
        public Word(string chars)
        {
            if (chars != null)
            {
                this.symbols = chars.Select(x => new Symbol(x)).ToArray();
            }
            else
            {
                this.symbols = null;
            }
        }
        public string Chars
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var s in this.symbols)
                {
                    sb.Append(s.Chars);
                }
                return sb.ToString();
            }
        }
    }
}
