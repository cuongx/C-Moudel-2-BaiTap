using System;
using System.Collections.Generic;
using System.Text;

namespace Baitapanhkhoa
{
    class Table : ITable
    {
        public int Tableid;
        public string StarTime;
        public string EndTime;
        public long Suntotal => Pay();


        public List<OrderDetail> OrderDetails = new List<OrderDetail>(0);

        public string ShowInfo()
        {
            return "\t" + "Tableid " + Tableid + "StarTime " + StarTime + "EndTime " + EndTime + "\n" + Showorder() + "Sumtotal";
        }
        public long Pay()
        {
            long sum = 0;
            foreach(OrderDetail pb in OrderDetails)
            {
                sum += pb.Total;
            }
            return sum;
        }
        public string Showorder()
        {
            string show = " ";
            foreach(OrderDetail pb in OrderDetails)
            {
                show += pb.Show()+"\t";
            }
            return show;
            
        }
    
    }
}
