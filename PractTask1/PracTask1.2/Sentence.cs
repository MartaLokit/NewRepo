using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracTask1._2
{
    public class Sentence : ISentence
    {
        private Split split = new Split();
        private ICollection<Read> read; 
        public bool Remove()
        {
            return true;
        }
        public int Count(string word)
        {
            string[] allwords = split.sentenceSeparator();
            int cnt = (from word2 in allwords where word2.ToLower() == word select word2).Count();
            return cnt;
        }

        public void Add(Read item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Read item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Read[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Read item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Read> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        int ICollection<Read>.Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
    }
}
