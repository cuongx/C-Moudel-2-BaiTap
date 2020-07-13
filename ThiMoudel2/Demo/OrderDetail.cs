using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
  class OrrderDetail { 
        public string Name { get; set; }
        public long Price { get; set; }
        public int Count { get; set; }
        public long Total => Caculator();

        public long Caculator()
        {
            return Price + (long)Count;
        }

        public string Show()
        {
            return "\t" + " Name " + Name + " Price " + Price + " Count " + Count + " Totat " + Total;
        }
    }

}
