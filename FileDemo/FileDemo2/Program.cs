
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Sockets;
using System.Numerics;

namespace FileDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Moudel 2\FileDemo\FileDemo2\inputData\";
            string fileName = "inputData.txt";
            Directory.CreateDirectory(path);
            using (StreamWriter sw = File.CreateText($@"{path}{fileName}"))
            {
                sw.WriteLine("3 4");
                sw.WriteLine("2 3 4 5 ");
                sw.WriteLine("8 6 7 11 ");
                sw.WriteLine("6 7 8 8 ");
                //sw.WriteLine("5 3 4 ");
            }
            int[,] maxtrix;
            int row = 0, col = 0;
            using (StreamReader sr = File.OpenText($@"{path}{fileName}"))
            {
                string line = sr.ReadLine();
                string[] rowcol = line.Split(" ");
                row = int.Parse(rowcol[0]);
                col = int.Parse(rowcol[1]);
                maxtrix = new int[row, col];
                maxtrix.GetLength(0);
                maxtrix.GetLength(1);
                for (int i = 0; i < row; i++)
                {
                    line = sr.ReadLine();
                    rowcol = line.Split(" ");
                    for (int j = 0; j < col; j++)
                    {
                        maxtrix[i, j] = int.Parse(rowcol[j]);
                    }
                }

            }

            string outfile ="output.txt";
            using (StreamWriter sw = File.CreateText(($@"{path}{outfile}")))

            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        sw.Write($"{maxtrix[i, j] } ");
                    }
                    sw.WriteLine();
                }
                Console.WriteLine();
                int total = Tong(maxtrix);
                sw.WriteLine("Tổng " + total);

                int a = Duongbien(maxtrix);
                sw.WriteLine("Tổng duong bien " + a);
                int b = Ngto(maxtrix);
                int c = Sole(maxtrix);
                sw.WriteLine("Số lẻ " + c);

            }




        }
        public static int Tong(int[,] maxtrix)
        {
            int total = 0;
            foreach (int iteam in maxtrix)
            {
                total += iteam;
            }
            return total;
        }
        public static int Duongbien(int[,] maxtrix)
        {
            int sum = 0;

            for (int i = 0; i < maxtrix.GetLength(1); i++)
            {
                sum = sum + i;

                //sum = sum + maxtrix[i, 0] + maxtrix[ maxtrix.GetLength(1) - 1,i];

                for ( i = 0; i < maxtrix.GetLength(1); i++)
                {
                    sum = sum + maxtrix[0, i];

                }
                for (int j = 0; j < maxtrix.GetLength(0); j++)
                {
                    sum = sum + maxtrix[j, 0];
                }
            }
        
            
            return sum;
        }
        public static int Ngto(int [,] maxtrix)
        {
           int n = 2;
            int dem = 0;
            while (dem <= n)
            {
                bool result = true;
                for (int i = 2; i <=Math.Sqrt(n); i++)
                {
                    if (n < 2) { result = false; }
                    if (n % i == 0)
                    {
                        result = false;
                    }
                }
                if (result)
                {
                    dem++;
                    n++;
                    //Console.WriteLine("so nguyen to " + n);
                }
               
            }
        
         
            return n; ;
           
        }
        public static int Sole(int [,]maxtrix )
        {
            int sole = 0;
            foreach(int item in maxtrix)
            {
                if (item % 2 != 0)
                {
                    sole++;
                }
                else
                {
                    continue;
                }
            }
            return sole;
        }
       
    }

}


     
   


