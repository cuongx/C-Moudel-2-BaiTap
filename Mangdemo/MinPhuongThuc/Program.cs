using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace MinPhuongThuc
{

    public class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số dòng  ");
            int dong = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột  ");
            int cot = int.Parse(Console.ReadLine());

            int[,] array = new int[dong, cot];

            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 70);

                }
            }


            Console.WriteLine("Mảng bạn vừa nhập là");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" " + array[i, j] + "  ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Số nhỏ nhất " + Minval(array));
            Console.WriteLine("Số nhỏ nhất " + Maxval(array));

            var sum2 = Cheop(array);
            Console.WriteLine("Chéo phụ là " + sum2);
            var sum1 = Cheoc(array);
            Console.WriteLine("Chéo chính " + sum1);
        }
        public static int Minval(int[,] araay)
        {


            int min = araay[0, 0];
            foreach (int num in araay)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            //for (int i = 0; i < araay.Length; i++)
            //{
            //    if (araay[i, j] < min)
            //    {
            //        min = araay[i, j];

            //    }
            //}
            return min;
        }
        public static int Maxval(int[,] araay)
        {
            int max = araay[0, 0];
            foreach (int num in araay)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public static int Cheoc(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j) { sum = sum + array[i, j]; }

                }
            }
            return sum;
        }
        public static int Cheop(int[,] array)
        {
            int sump = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i + j == array.Length + 1) { sump = sump + array[i, j]; }

                }
            }
            return sump;

        }
    }
}
