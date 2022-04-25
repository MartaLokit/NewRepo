using System;
using System.Collections.Generic;
using System.Text;

namespace PractTask3
{
    public delegate void AccountHandler(string message);
    public class Balance
    {
        int _sum;
        public event AccountHandler CurrentBalance;//текущий баланс
        public event AccountHandler Added;//добавлен
        public event AccountHandler Withdrawn;// снятие
        public event AccountHandler Enrollment;// зачисление
        public Balance(int sum)
        {
            _sum = sum;
        }
        public void Add(int sum)
        {
            if (Enrollment != null) Added($"На баланс пришло {sum}");
            {
                _sum += sum;
                CurrentBalance($"Баланс равен: {_sum}");
            }
        }
        public void WriteOff(int sum)
        {
            if (_sum>=sum)
            {
                _sum =- sum;
                if (Withdrawn != null) Withdrawn($"С баланса списано{sum}");
            }
            else
            {
                Withdrawn("На балансе не достаточно средств");
            }
        }
    }
}
