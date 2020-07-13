using System;
using System.Collections.Specialized;
using System.Text;
using System.Threading;

namespace Ungdungchuyendoitiente
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Nhập số nguyên tố");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //int m = 2;


            //if (n > 1)
            //{
            //    int count = 0;
            //    while (count < n)
            //    {
            //        bool flag = true;
            //        for (int i = 2; i <Math.Sqrt(m); i++)
            //        {
            //            if (m % i == 0)
            //            {
            //                flag = false;
            //            }
            //        }

            //        if (flag)
            //        {
            //            count++;
            //            Console.WriteLine(m + " ");
            //        }
            //        m++;
            //    }
            //}

            //else
            //{
            //    Console.WriteLine("Mời bạn nhập lại ");
            //}

            Console.WriteLine("Nhập vào số nguyên tố");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 1)
            {

                int m = 2;
                int count = 0;
                while(count < n)
                {
                    bool check = true;
                   
                    if (n < 2) { check = false; }
                    for(int i = 2; i <= Math.Sqrt(m); i++)
                    {
                        if (m % i == 0)
                        {
                            check = false;
                        }
                    }
                    if (check)
                    {
                        count++;
                        Console.WriteLine(m + " ");
                    }
                    m++;                            

                }
               
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại");
            }
        }
    }
}
