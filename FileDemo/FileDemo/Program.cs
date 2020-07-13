using System;
using System.Globalization;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Moudel 2\FileDemo\FileDemo\Data";
            string finame = "Data.txt";
            Directory.CreateDirectory(path);
            //using (StreamWriter sr = File.CreateText($@"{path}{finame}"))
            //{
            //    sr.WriteLine("3 4");
            //    sr.WriteLine("2 3 4 5 ");
            //}


            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            Random rnd = new Random();
           
            using (StreamWriter sr = File.CreateText($@"{path}{finame}"))
            {
                
                sr.WriteLine("Nhập vào hàng");
                sr.WriteLine("Nhập vào số cột");
            }
            string oufine = "output.txt";
            using (StreamWriter sa = File.CreateText($@"{path} {oufine}"))
            {

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = rnd.Next(10, 70);
                        Console.WriteLine(arr[i, j] + "  ");

                    }
                }

            }

           
                    


        }
      
    }
  }
