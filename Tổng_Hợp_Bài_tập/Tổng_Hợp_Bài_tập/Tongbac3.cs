using System;
using System.Collections.Generic;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class Tongbac3
    {
        public static void Process()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            int tong = 0;
            Console.WriteLine("Nhập vào N");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i= 0; i<n; i++)
            {
                tong += i * i * i;
            }
            Console.WriteLine(tong + " ");
        }
    }
}
