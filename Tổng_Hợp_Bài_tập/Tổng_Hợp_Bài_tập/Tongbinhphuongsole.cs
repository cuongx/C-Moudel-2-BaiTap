using System;
using System.Collections.Generic;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class Tongbinhphuongsole
    {
        public static void Process()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            double tong = 0;
            Console.WriteLine("Nhập vào số ");
            int n = Int32.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                tong = Math.Pow(i, 2);
            }
            Console.WriteLine($"Bình phương của {n} là {tong}");
        }
    }
}
