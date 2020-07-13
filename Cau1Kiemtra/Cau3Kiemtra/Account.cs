using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3Kiemtra
{
    class Account : IAccount
    {
        public int Accountld;
        public string Fristname;
        public string Lastname;
        public string Gender;
        public float Balance { get; private set; }

        public void Paylnto(float Amount)
        {
             Balance = Balance+ Amount;
        }
      

        public string ShowInfo()
        {
            return $"\t{Accountld}\t\t{Fristname}\t\t{Lastname}\t\t{Gender}\t\t{Balance}";
        }
    }
}
