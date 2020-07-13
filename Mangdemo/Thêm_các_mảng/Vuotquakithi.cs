using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

namespace Thêm_các_mảng
{
    class Vuotquakithi
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int size;
            int[] array;
            do
            {
                Console.WriteLine("Nhập size mảng:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                    Console.WriteLine("Kích thước không quá 30");

            } while (size > 30);
            array = new int[size];
            int i = 0;
            while (i < size)
            {
                Console.WriteLine("Nhập điểm" + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            int count = 0;
            Console.Write("Danh sách điểm học sinh: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
                if (array[j] >= 5 && array[j] <= 10)
                    count++;
            }

            Console.WriteLine("\n Số lượng học sinh vượt qua kỳ thi là " + count);
        }
    }
}
        //    int size;
        //   int[] array;
        //    do
        //    {
        //        Console.WriteLine("Nhập size mảng");
        //        size = Int32.Parse(Console.ReadLine());
        //        if (size > 30)
        //        {
        //            Console.WriteLine("Vượt quá size rồi");
        //            Environment.Exit(30);
        //        }
        //    } while (size >30 );

        //    array = new int[size];
        //    int i = 0;
        //    while( i <  array.Length)
        //    {
        //        array[i] = Int32.Parse(Console.ReadLine());              
        //        Console.WriteLine("Điểm = " + (i + 1) + ": ");
        //        i++;
             
        //    }
        //    int count = 0;
        //    for (int j = 0; j<array.Length; j++)
        //    {
        //        if (array[j] >= 5 && array[j] <= 10)

        //            Console.WriteLine($"{array[j]}\n");
        //            count++;
                    
        //        }
        //    Console.WriteLine($"\nSố điểm vượt qua kì thi là {count}");
        //}
          

    //    }
    //}

