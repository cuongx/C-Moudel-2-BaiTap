using System;
using System.Collections.Generic;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class Solonnhatnhonhat
    {
        public static void Process()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
           
            int[] array;
            Console.WriteLine("Nhập vào size mảng");
            int size = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhập vào số b");
            //int b = Int32.Parse(Console.ReadLine());
            array = new int[size];
            int max =array[0];
            int min = array[0];
            Random rnd = new Random();
            int i  = 0;
            //int j = 0;

            for (i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write($" {array[i]} ");
                if (array[i] > max)
                {
                    max = array[i];
                 
                }
                
               else if (array[i] < min)
                {
                    min = array[i];
                }
               }
                 Console.WriteLine();
                Console.WriteLine("max là " + max);
                Console.WriteLine("min là " + min);
        }
    }
}
