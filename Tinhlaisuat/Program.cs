using System;
using System.Text;

namespace Tinhlaisuat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            double tiengui = 1.0;
            int thanggui = 1;
            double laisuat = 1.0;
            Console.WriteLine("Nhập số tiền gửi");
            tiengui = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tháng gửi");
            thanggui = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lãi suất hàng năm");
            laisuat = Double.Parse(Console.ReadLine());

            double laisuatcuaban = 0;
            for (int i = 0; i < thanggui; i++)
            {
                laisuatcuaban = tiengui * (laisuat / 100) / 12 * 3;
            }
            Console.WriteLine("Lãi suất của bạn là " + laisuatcuaban);

        }
        
    }
}
