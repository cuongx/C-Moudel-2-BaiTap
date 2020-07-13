using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDemo.Models
{
    class OrderDetails
    {
        public string name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public double amount => Calculator();

        public override string ToString()
        {
            return $"\t\t{name}\t{count}\t{price}\t{amount}";
        }

        public double Calculator()
        {
            return (double)price * (double)count;
        }
    }
}
