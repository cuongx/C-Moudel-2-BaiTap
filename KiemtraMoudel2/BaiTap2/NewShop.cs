using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap2
{
    class NewShop
    {
        public string Orderid { get; set; }
        public string hang { get; set; }
        public double Sumtotal => Calculator();
        public int status;
        public string Timeout;

        public List<OrderDetails> orderDetails = new List<OrderDetails>();

        public override string ToString()
        {
            string str = $"{Orderid}\t{hang}\t{Timeout}\t" +
          $"Status: {((status == 1) ? "Nhận đơn" : (status == 2) ? "Đã thanh toán" : "Hủy đơn")}";
            foreach (var pb in orderDetails)
            {
                str = $"{str}\t{pb.ToString()}";
               
            }
            str = $"Sumtotal {Sumtotal}";
            return str;
        }
        public double Calculator()
        {
            double toatl = 0.0;
            foreach(var pb in orderDetails)
            {
                toatl += pb.Total;
            }
            return toatl;
        }
      
    
    }
}
