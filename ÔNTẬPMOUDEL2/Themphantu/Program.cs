using System;
using System.Drawing;
using System.Linq;
using System.Text;
namespace Themphantu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr;
            int size;
            int i = 0;
            Console.WriteLine("Nhập size mảng");
            size = Int32.Parse(Console.ReadLine());

            arr = new int[size];
            Random rnd = new Random();
            for( i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Nhập số bạn muốn thêm");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vị trí bạn muốn thêm");
            int pos = Int32.Parse(Console.ReadLine());
            
           if(pos <0 || pos > arr.Length)
            {
                Console.WriteLine("Không có trong mảng");

            }
            else
            {
                Array.Resize(ref arr, arr.Length + 1);
                for(int j = arr.Length -1 ; j > pos; j--)
                {
                    
                    arr[j] = arr[j - 1];
                    Console.WriteLine(arr[j]);
                }
                arr[pos] = x;
               
                for (i = 0; i < arr.Length; i++)
                {                
                    Console.Write(arr[i] + " ");
                }
            }


        }
    }
}
