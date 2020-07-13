using System;
using System.Collections.Generic;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class MaAsscii
    {
        public static void Process()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bảng Ascci");
            for(int i= 0; i<128; i++)
            {
                Console.Write((char)i + "\t");
               
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
