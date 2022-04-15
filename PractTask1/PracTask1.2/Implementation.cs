using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PracTask1._2
{
    public class Implementation
    {
        private Read read = new Read();
        Symbol symbol = new Symbol();
        
        Split split = new Split();
        public Implementation()
        {          
            var arr = read.ToString().Split(split.sentenceSeparator().ToString()).Select(s => s.ToLower().First()).Distinct().OrderBy(s => s);
            foreach (var item in arr)
            {
                symbol = new Symbol(item);
                Console.WriteLine(symbol);
            }
            var word = read.ToString().Select(s => s.ToString().Distinct().OrderBy(s => s));
            foreach (var item in word)
            {
               Word words = new Word(item.ToString());
               Console.WriteLine(words);
            }
        }
    }
}
