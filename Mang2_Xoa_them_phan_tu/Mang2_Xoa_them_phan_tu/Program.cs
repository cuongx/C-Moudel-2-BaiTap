using System;
using System.Dynamic;
using System.Globalization;
using System.Text;
namespace Mang2_Xoa_them_phan_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //int size;
            //int[] array;
            //int x;
            //int index;

            //Console.Write("\n Enter a size: ");
            //size = int.Parse(Console.ReadLine());
            //array = new int[size];
            //int i = 0;
            //Console.WriteLine("Array is: ");
            //Random rand = new Random();
            //for (i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(100);
            //    Console.Write(array[i] + " ");
            //}
            ////Console.WriteLine();
            ////Console.WriteLine("Property list: ");
            ////for (int j = 0; j < array.Length; j++)
            ////{
            ////    Console.Write(array[j] + " ");
            ////}
            //Console.WriteLine();
            //Console.WriteLine("Enter Value X: ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter index: ");
            //index = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (index <= 1 && index >= array.Length - 1)

            //{
            //    Console.WriteLine(" Could not insert element into array");
            //}
            //else
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        array[index + 1] = x;
            //        Console.Write(array[j] + " ");
            //    }
            //}



            int size;
            int index;
            int x;
            int[] array;
            Console.WriteLine("Nhập size mảng");
            size = Int32.Parse(Console.ReadLine());


            int i = 0;
            Console.WriteLine("Mảng của bạn là");
            Random rnd = new Random();
            array = new int[size];
            for (i = 0; i < array.Length; i++)
            {

                array[i] = rnd.Next(100);
                Console.Write($"{i} = {array[i]}  ;");
            }
            Console.WriteLine();

            Console.WriteLine("Nhập số bạn muốn thêm");
            x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("vị trí của số đó");
            index = Int32.Parse(Console.ReadLine());
            if (index < 0 || index > array.Length)
            {
                Console.WriteLine("Vị trí k có trong mảng");
                Console.WriteLine();
            }
            else
            {
                Array.Resize(ref array, array.Length + 1);
                for (int j = array.Length - 1; j > index; j--)
                {

                    array[j] = array[j - 1];

                    Console.WriteLine(array[j] + " ");
                }
                array[index] = x;
                for (i = 0; i < array.Length; i++)
                {
                    Console.Write($"{i} = {array[i]} ; ");
                }
            }

        }
    }
}
