using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Cau1Demo
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Nhập dòng");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số cột");
            //int m = Int32.Parse(Console.ReadLine());
            int[,] arr = Createamatrix(n);
            ShowMatrix(arr);           
            Console.WriteLine();
            Console.WriteLine("Số nhỏ nhất là " + Min(arr));
            int a = Sumc(arr,out string str);
            int b = Sump(arr, out string str1);
            int c = Giatritd(arr, a, b);
            Console.WriteLine("Dường chéo chính " + str.Substring(0, str.Length - 1) + "=" + a);
            Console.WriteLine("Dường chéo phụ " + str1.Substring(0, str1.Length - 1) + "=" + b);

            Console.WriteLine($"Gía trị tuyệt đối {a} - {b} = {c} ");
        }

        public static int[,] Createamatrix(int n)
        {
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(40, 80);
                }

            }
            return arr;

        }
        public static void ShowMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int Giatritd(int[,]arr,int a, int b)
        {
           int tong = a - b;
           return Math.Abs(tong);
        }
        public static int Min(int[,] arr)
        {
            int min = arr[0, 0];

            foreach (var iteam in arr)
            {
                if (iteam < min)
                {
                    min = iteam;
                }
            }
            return min;

        }
        public static int Sumc(int [,]arr,out string str1)
        {
        
            int sum = 0;
            str1 = "";
            
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    if (i == j) { sum = sum + arr[i, j]; str1 = str1 + arr[i,j] + "+" ; }
                    
                }
                
            }
            return sum;
        }
        public static int Sump(int[,] arr, out string str)
        {
            int sum = 0;
            str = "";
            int lenght = arr.GetLength(0);
            for (int i = 0; i < lenght; i++)
            {
                sum = sum + arr[i, lenght - 1 - i];
                str += arr[i, lenght - 1 - i] + "+";
            }
            return sum;
            //int sum = 0;
            //str1 = "";
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i + j == arr.Length) { sum = sum + arr[i, j]; str1 = str1 + arr[i, j] + "+"; }

            //    }

            //}
            //return sum;
        }
        public static int DuongBien(int[][]arr)
        {
            int sum = 0;
            for(int j = 1; j <=arr.GetLength(1);j++)
            {
                sum += arr[0][j];
                sum += arr[arr.GetLength(1) - 1][j];
            }
            for (int i = 1; i <= arr.GetLength(0); i++)
            {
                sum += arr[i][0];
                sum += arr[i][arr.GetLength(1)-1];
            }
            return sum;

        }
    }
}    

