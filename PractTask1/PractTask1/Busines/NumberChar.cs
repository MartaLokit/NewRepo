using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PractTask1.Data_Access;
namespace PractTask1.Busines
{

    public class NumberChar
    {
        Read read = new Read();
        public string[] Lines = File.ReadAllLines("text.txt");
        public void Number()
        {
            string text =read.ReadFile();
            string[] allwords = text.Split(' ', ',', '\n');
            var arr = (text.Split(' ').Select(s => s.First()).Distinct());
            foreach (var item in arr)
            {
                Console.WriteLine($"\t '{item}'");
                foreach (string word in allwords.Distinct())
                {
                    char[] s = word.ToCharArray();
                    if (s[0] == item)
                    {
                        Console.Write(word + " " + GetCount(word, allwords) + ".......");
                        GetNumberWord(word);
                        Console.Write("\n");
                    }
                    s = null;
                }
            }
        }
        public int GetCount(string word, string[] allwords)
        {
            int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
            return cnt + 1;
        }
        public void GetNumberWord(string word)
        {
            string[] Lines = File.ReadAllLines("text.txt");
            for (int i = 0; i < Lines.Length; i++)
            {
                if (Lines[i].Contains(word))
                {
                    Console.Write(i + 1 + ",");
                }
            }
        }
    }
}
