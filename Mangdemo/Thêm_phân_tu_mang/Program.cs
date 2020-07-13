using System;
using System.Globalization;
using System.Text;
namespace Thêm_phân_tu_mang
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
            //Console.WriteLine();
            //Console.WriteLine("Danh sách: ");
            //for (int j = 0; j < array.Length; j++)
            //{
            //    Console.Write(array[j] + " ");
            //}
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
            //        array[index - 1] = x;
            //        Console.Write(array[j] + " ");
            //    }
            //}
            //}



            //public static int MinValue(int[] array)
            //{
            //    Console.InputEncoding = Encoding.UTF8;
            //    Console.OutputEncoding = Encoding.UTF8;
            //    int min = array[0];
            //    int index = 0;
            //    int max = array[0];

            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i] < min)
            //        {
            //            min = array[i];
            //            index = i;
            //        }

            //    }

            //    return index;

            //}
            //public static void Main(String[] args)
            //{
            //    int[] arr = { 4, 12, 7, 8, 1, 6, 9 };
            //    int index = MinValue(arr);
            //    Console.WriteLine("Phần tử nhỏ nhất trong mảng là: " + arr[index]);
            //  ;
            //}
            //int size;
            //int[] array;
            //do
            //{
            //    Console.WriteLine("Enter a size:");
            //    size = Int32.Parse(Console.ReadLine());
            //    if (size > 20)
            //        Console.WriteLine("Size should not exceed 20");

            //} while (size > 20);
            //array = new int[size];
            //int i = 0;
            //while (i < array.Length)
            //{
            //    Console.WriteLine("Enter element" + (i + 1) + " : ");
            //    array[i] = Int32.Parse(Console.ReadLine());
            //    i++;
            //}
            //    Console.WriteLine("Danh sách ");
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        Console.WriteLine(array[j] + "\t");
            //    }
            //    int max = array[0];
            //    int index = 1;
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (array[j] > max)
            //        {
            //            max = array[j];
            //            index = j + 1;
            //        }

            //    Console.WriteLine("Lớn nhất là " + max + " ,Tại vị trí " + index);break;
            //}
            int size;
            int[] array ;
            do
            {
                Console.WriteLine("Nhập size mảng");
                size = Convert.ToInt32(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Stop");break;
                }
            } while (size > 20);
            array = new int[size];
            for (int i =0; i < array.Length; i++)
            {
                Console.Write($"Phần tử {i + 1}=  ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.Write("Danh sách các phần tử là\n");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine($"{array[j]} ");
            }
            int max = array[0];
            int vitrim = 0;
            int vitrimin = 0;
            int min = array[0];
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max) { max = array[j];vitrim = j + 1; }
                if (array[j] < min) { min = array[j]; vitrimin = j + 1; }

            }
            Console.WriteLine($"Số lớn nhất trong mảng là {max} nằm ở vị trí {vitrim}");
           Console.WriteLine($"Số lớn nhất trong mảng là {min} nằm ở vị trí {vitrimin}");
        }
    }
}

