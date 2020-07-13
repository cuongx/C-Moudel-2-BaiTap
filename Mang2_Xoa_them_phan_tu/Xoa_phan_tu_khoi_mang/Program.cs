using System;
using System.Globalization;
using System.Text;
namespace Xoa_phan_tu_khoi_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            int[] array;
            int pos;
            int size;
            int i = 0;
            Console.WriteLine("Nhập size mảng");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[100];
            Random rnd = new Random();
            for (i = 0; i < size; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write($"{array[i]}   ");

            }

            Console.WriteLine();
            int j = 0;
            Console.Write("Nhập một vị trí cần xóa ");
            pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            j = pos - 1;
            Console.WriteLine(j);
            while (j < size)
            {
              array[j] = array[j + 1];  
                //Console.WriteLine(array[j]);
                j++;
            }
            size--;
            Console.WriteLine("mảng sau khi xóa ");
            for (j = 0; j < size; j++)
            {
                Console.Write(array[j] + " ");

            }
        }
    }
}





        
