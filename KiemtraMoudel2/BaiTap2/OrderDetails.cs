using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2
{
    class OrderDetails
    {
        public string name { get; set; }
        public int age { get; set; }
        public string diachi { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public double Total => Calculator();
        public override string ToString()
        {
            return $"{name}\t{age}\t{diachi}\t{price}\t{count}";
        }
        public double Calculator()
        {
          return  (double)price * (double)count;
        }
    }
}
