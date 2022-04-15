using System;
using System.Collections.Generic;
using System.Text;

namespace PracTask1._2
{
    public class Split
    {
        private string[] sentenceSeparators = new string[] { "?", "!", ".", "...", "?!","\n" };
        private string[] wordSeparators = new string[] { " ", " - " };
        public string[] sentenceSeparator()
        {
            return sentenceSeparators;
        }
        public string[] wordSeparator()
        {
            return wordSeparators;
        }
    }
}
