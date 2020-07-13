using System;
using System.Collections.Generic;
using System.Text;

namespace Baitap
{
    class OrderDetail
    {
        public string Name { get; set; }
        public long Price { get; set; }
        public int Count { get; set; }
        public long Total => CalculatorTotal();


        public long CalculatorTotal()
        {
            return Price * (long)Count;
        }
        public string Show()
        {
            return "Name " + Name + "Price " + "Count " + Count + "Total " + Total;
        }
    }
}
