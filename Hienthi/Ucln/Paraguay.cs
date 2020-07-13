using System;
using System.Text;
namespace ConsoleApp1
{
    class Paraguay
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int a, b;           
                Console.WriteLine("Nhập số a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập số b");
                b = Convert.ToInt32(Console.ReadLine());

                a = Math.Abs(a);
                b = Math.Abs(b);
                if (a == 0 || b == 0)
                {
                    Console.WriteLine("kHÔNG CÓ ƯỚC CHUNG");
                }
                else
                {
                    while (a != b)
                    {
                        if (a > b) { a -= b; }
                        else { b = b - a; }
                    }
                }
            
            Console.WriteLine("Ước chung của chúng là " + b);
            Console.ReadKey();

            }
        }
    }

