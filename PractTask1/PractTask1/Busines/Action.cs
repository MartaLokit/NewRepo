using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PractTask1.Data_Access;

namespace PractTask1.Busines
{   
    public class Action:IAction
    {
        Sort sort = new Sort();
        Read read = new Read();
        Save save = new Save();
        NumberWord number = new NumberWord();
        NumberChar numberChar = new NumberChar();
        public void Read()
        {
            _=read.AReadFile();
        }
        public void Sort()
        {
            sort.SotrFile();
        }
        public void NumberWord()
        {
            number.Number();
        }
        public void NumberChar()
        {
            numberChar.Number();
        }
        public void Save()//сделать
        {
            save.SaveText();
        }
    }
}
