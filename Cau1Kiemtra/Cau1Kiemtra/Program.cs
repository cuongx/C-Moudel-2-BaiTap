using System;
using System.Diagnostics.Tracing;
using System.Text;
namespace Cau1Kiemtra
{
    class Program
    {
              static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                int n = 0;
                int m = 0;
                do
                {
                    Console.Write("Nhập kích cỡ ma trận :  ");              
                   n = int.Parse(Console.ReadLine());
                  
                    if (n == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Vui lòng nhập lại nhập số nguyên!");
                    }
                } while (n == 0);
              
                int[,] array = CreateMatrix(n);
                ShowMatrix(array);
                Console.WriteLine($"Giá trị nhỏ nhất trong ma trận là: {FindMin(array)}");
                string str1, str2;
                int Crossmain = SumCrossmain(array, out str1);
                int Crossside = SumCrossside(array, out str2);
                Console.WriteLine($"Tổng chéo chính: {str1.Substring(0, str1.Length - 3)} = {Crossmain}");
                Console.WriteLine();
                Console.WriteLine($"Tổng chéo phụ: {str2.Substring(0, str2.Length - 3)} = {Crossside}");
                Console.WriteLine();
                Console.WriteLine($"Gía Trị tuyệt đối của hiệu đường chéo chính và đường chéo phụ là:" +
                    $" |{Crossmain} - {Crossside}| = {DiagonalDifference(Crossmain, Crossside)}");
            }
            public static int[,] CreateMatrix(int n)
            {
                int[,] array = new int[n, n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = rnd.Next(40, 80);
                    }
                }
                return array;
            }
            public static int FindMin(int[,] arr)
            {
                int min = arr[0, 0];
                foreach (int num in arr)
                {
                    if (min > num)
                    {
                        min = num;
                    }
                }
                return min;
            }
            public static int DiagonalDifference(int main, int side)
            {
                int sub = main - side;
                return Math.Abs(sub);
            }
            public static void ShowMatrix(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($" {arr[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            public static int SumCrossmain(int[,] arr, out string str)
            {
                int Sumcrossmain = 0;
                str = "";
                int length = arr.GetLength(0);
                for (int i = 0; i < length; i++)
                {
                    Sumcrossmain += arr[i, i];
                    //str += $"{arr[i, i]} + ";
                }
                return Sumcrossmain;
            }
            public static int SumCrossside(int[,] arr, out string str)
            {
                int Sumcrossside = 0;
                str = "";
                int length = arr.GetLength(0);
                for (int i = 0; i < length; i++)
                {   
                    Sumcrossside += arr[i, length - 1 - i];
                    str += $"{arr[i, length - 1 - i]} + ";
                }
                return Sumcrossside;
            }
        }
    }
  

