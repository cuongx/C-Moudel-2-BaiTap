using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDemo.Models
{
    class Table
    {
        public string tableid { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string cashier { get; set; }
        public bool ispaid { get; set; }
        public double toatalamount => CalaculatorTotal();

        public List<OrderDetails> orderDetail { get; set; }

        public override string ToString()
        {
            string str = $"\t\t////////////////Sống thật cafe thật//////////" +
                $"\n\t{tableid}\t{starttime}\t{cashier}\t{ispaid}\t{toatalamount}\t{endtime}";
            foreach(var pb in orderDetail)
            {
                str = $"{str}\n{pb.ToString()}";
            }
            return str;
          
        }
        public double CalaculatorTotal()
        {
            double toatal = 0.0;
            foreach(var pb in orderDetail)
            {
                toatal += pb.amount;
            }
            return toatal;
        }
        //public string Show()
        //{
        //    string show = "";
        //   foreach(var pb in orderDetail)
        //    {
        //        show += show.ToString();
        //    }
        //    return show;
        //}

    }
}
