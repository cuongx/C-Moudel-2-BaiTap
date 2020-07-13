using System;

namespace Thêm_phan_tư_vao_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            int x;
            int index;
            Console.Write("\n Enter a size: ");
            size = int.Parse(Console.ReadLine());
            array = new int[size];
            int i = 0;
            Console.WriteLine("Array is: ");
            Random rand = new Random();
            for (i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Enter Value X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index: ");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (index <= 1 && index >= array.Length - 1)
            {
                Console.WriteLine(" Could not insert element into array");
            }
            else
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[index - 1] = x;
                    Console.Write(array[j] + " ");
                }
            }
        }
    }
}