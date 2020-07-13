using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class Usclnbscnn
    {
       
       public static  void Process()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            
                Console.WriteLine("Nhập vào số a");
                int a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Nhập vào số b");
                int b = Int32.Parse(Console.ReadLine());
                 int c = a;
                 int d = b;
           
                while (a != b)
                {
                    if (a > b) { a = a - b; }

                    else
                    {
                        b = b - a;
                    }
                }

            Console.WriteLine($"Ước chung lớn nhất là {a}");
            bool result = false;
            int i = 1;
            if (c > d)
            {
                i = c / a;
            } else
            {
                i = d / a;
            }
            int boichung=a;
            while (!result)
            {
                 boichung= i * a;
                if (boichung % c==0 && boichung % d == 0)
                {
                    result = true;
                }
                i++;
            }
            Console.WriteLine($"Bội chung nhỏ nhất là {boichung}");
        }            
        
       }

     }

