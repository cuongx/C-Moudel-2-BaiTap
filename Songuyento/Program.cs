using System;
using System.Text;

namespace Songuyento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int number;
            Console.WriteLine("Nhập Số: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
                Console.WriteLine(number + "Không phải số nguyên tố" );
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + "Là Số Nguyên Tố");
                }
                else
                {
                    Console.WriteLine(number + " Không Phải Số Nguyên Tố");
                }
            }
        }
    }
}
