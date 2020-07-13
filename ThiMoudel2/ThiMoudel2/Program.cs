using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ThiMoudel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số dòng");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số cột");
            int c = Int32.Parse(Console.ReadLine());
            Program.CreateMatrix(d, c);
         
            int[,] array = new int[d, c];        
             
            Console.WriteLine();
            int a = ShowMaxRow(array);

            Console.WriteLine(a);
            
        }
        public static void CreateMatrix(int d, int c)
        {

            int[,] array = new int[d, c];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 50);
                    Console.Write(" " + array[i, j] + " ");

                }
                Console.WriteLine();

            }
        }
        public static int Sum(int[] mang)
        {

            int sum = 0;

           foreach(int iteam in mang)
            {
                sum += iteam;
            }
            return sum;
        }
        public static int ShowMaxRow(int[,] array) {


            int max = 0;
            
            int index = 0;
           for(int i = 0; i < array.GetLength(0); i++)
            {
                int[] arr = new int [(array.GetLength(1))];
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    arr[j] = array[i, j];

                    int sum = Sum(arr);

                    if (sum > max) { max = sum; }
                    index = i;
             
                }
                Console.WriteLine("Tổng giá trị của dòng " + max + 1  +  " index " + index + 1);
            }
            return max;                     
        }
    }
}