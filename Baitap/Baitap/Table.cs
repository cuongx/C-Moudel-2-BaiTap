using System;
using System.Collections.Generic;
using System.Text;

namespace Baitap
{
    class Table :ITable
    {
        public int TableId { get; set; }
        public string StarTime { get; set; }
        public string EndTime { get; set; }
        public long SumTotal => Pay();

        public List<OrderDetail> OrderDetails = new List<OrderDetail>(0);

        public long Pay()
        {
            long sum = 0;
            foreach(var item in OrderDetails)
            {
                sum += item.Total;
            }
            return sum;
        }
     

        public void ShowInfo()
        {
            Console.WriteLine($"\t\t\t TableId: {TableId} \n\t\tStartTime: {StarTime} \n" +
                $"\t\tEndTime  : {EndTime} \n{ShowOrderDetails()} \t\t\tSumTotal: {SumTotal} ");
        }

        public string ShowOrderDetails()
        {
            string show = "";
            foreach(OrderDetail item in OrderDetails)
            {
                show += item.Show()+"\n";
            }
            return show;
        }

       
    }
}
