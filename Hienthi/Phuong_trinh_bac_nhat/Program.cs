using System;
using System.Text;
namespace Phuong_trinh_bac_nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số a");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào số b");
            double b = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                double so = -b / a;
                Console.WriteLine($"Kết quả là { so }");
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm");
                }
                else
                {
                    Console.WriteLine("Phương trình không xác định");
                }
            }
        }
    }
}
