using System;
using System.Data.Common;
using System.Xml;

namespace Statictinh
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Số Lượng mèo ban đầu {Helo.Count}");
            Helo Cat = new Helo();
            Console.WriteLine($"Số Lượng mèo ban đầu {Helo.Count}");
            Helo Dog = new Helo();
            Console.WriteLine($"Số Lượng mèo ban đầu {Helo.Count}");

            Console.WriteLine($"{Helo.LuyThua(2,2)}");

        }
    }
}
