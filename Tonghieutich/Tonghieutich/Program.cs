using System;
using System.Security;
using System.Text;
namespace Tonghieutich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //int A, B;
            //string tryA, tryB;
            //int tong, hieu, tich;
            //double  thuong;
            //Console.WriteLine("Nhập vào số a");
            //tryA = Console.ReadLine();
            //Console.WriteLine("Nhập vào số b");
            //tryB = Console.ReadLine();

            //A = int.Parse(tryA);
            //B = int.Parse(tryB);

            //tong = A + B;
            //hieu = A - B;
            //tich = A * B;
            //thuong = (double)A / B;
            //Console.WriteLine("Tổng "+tong);
            //Console.WriteLine("Hiệu" + hieu);
            //Console.WriteLine("Tích "+tich);
            //Console.WriteLine("Thương "+thuong);
            int  a =5;
            Hello(ref a);

            Console.WriteLine("SỐ  " + a);

             int ra =  Tinhtong();
            Console.WriteLine("RA  " + ra );
        }
        private static void Hello(ref int input)
        {
            input ++;
            Console.WriteLine("INPUT  " + input);
            Console.WriteLine("Hello");
        }
        private static int Tinhtong()
        {
            int a = 3;
            int b = 5;
            int tong = a + b;
            return tong;
        }
    }
}
