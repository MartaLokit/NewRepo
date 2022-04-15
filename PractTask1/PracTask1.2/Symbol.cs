using System;
using System.Collections.Generic;
using System.Text;

namespace PracTask1._2
{
    public struct Symbol
    {
        private string chars;
        public Symbol(char source)
        {
            this.chars = String.Format("{0}", source);
        }
        public string Chars
        {
            get { return chars; }
            private set { chars = value; }
        }
        public bool IsUppercase
        {
            get { return chars != null && chars.Length >= 1 && char.IsLetter(chars[0]) && char.IsUpper(chars[0]); }
        }

        public bool IsLower
        {
            get { return chars != null && chars.Length >= 1 && char.IsLetter(chars[0]) && char.IsLower(chars[0]); }
        }
    }
}
