using System;
using System.Collections.Generic;
using System.Text;

namespace PracTask1._2
{
    public interface ISentence:ICollection<Read>
    {
        bool Remove();
        int Count(string word);
    }
}
