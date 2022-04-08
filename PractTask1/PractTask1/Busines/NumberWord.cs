using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PractTask1.Data_Access;

namespace PractTask1.Busines
{
    public class NumberWord
    {
        Sort sort = new Sort();
        Read read = new Read();
        public void Number()
        {
            string text = read.ReadFile().ToString();
            string[] allwords = text.Split(' ', '.',',','\n');
            var unique = (from word in allwords select word.ToLower()).Distinct().OrderBy(name => name);
            foreach (var word in unique)
            {
                int cnt = GetCount(word, allwords);
                Console.Write($"\n{word}.....{cnt}...");
                GetNumberWord(word);
            }
        }
        public int GetCount(string word, string[] allwords)
        {
            int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
            return cnt;
        }
        public void GetNumberWord(string word)
        {
            string[] Lines = File.ReadAllLines("text.txt");
            for (int i = 0; i < Lines.Length; i++)
            {
                if (Lines[i].Contains(word))
                {
                    Console.Write(i + 1 + " ");
                }
            }

        }
    }
}
