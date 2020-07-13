using System;
using System.Text;
namespace Kiem_tra_nam_nhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int year;
            bool isLeapYear = false;
            Console.WriteLine("Nhập vào năm ");
            year = Convert.ToInt32(Console.ReadLine());

            bool nam4 = year % 4 == 0;
            if (nam4)
            {
                bool nam400 = year % 400 == 0;
                if (nam400)
                {
                    bool nam100 = year % 100 == 0;
                    if (nam100)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }

            }
            if (isLeapYear)
            {
                Console.WriteLine(year + " Là năm nhuận");
            }
            else
            {
                Console.WriteLine(year + " Không phải năm nhuận");
            }

        }
    }
}

