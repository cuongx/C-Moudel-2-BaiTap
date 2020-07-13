using System;
using System.Collections.Generic;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class giaithua
    {
        public static void Process()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int i = 1;
            int gt = 1;
            Console.WriteLine("Nhập số n");
            int n = Int32.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                gt = gt * i;
            }
           
            Console.WriteLine($"{n}! = {gt}");
        }
     }
}
