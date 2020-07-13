using System;
using System.Collections.Generic;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class Uoccuaso
    { 
        public static void Process()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
             string dem = " ";
            Console.WriteLine("Nhập vào số A");
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Nhập vào số B");
            //int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {

                    dem += " " + (a / i);

                }

            }
            Console.WriteLine("Ưóc số của " + a + " là" + dem);

        }
    }

   }

