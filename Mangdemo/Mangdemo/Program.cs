using System;
using System.Drawing;
using System.Text;
namespace Mangdemo
{
    class Program
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
                    //Console.Write("Mời bạn nhập mảng 2 chiều[{0},{1}] = ",i,j);
                    array[i, j] = rnd.Next(10, 70);
                }
                //Console.WriteLine();
            }
          

            int vitricotm = 0;
            int vitrim = 0;
            int max = array[0,0];
            int min = array[0, 0];
            int sum = 0;
            int vtcmin = 0;
            int vtdmin = 0;
            int sumc = 0;
            int sump = 0;
            int tgt = 0;
            int tgd = 0;
            Console.WriteLine(" Mảng bạn vừa nhập là : ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" " + array[i, j] + "  ");

                    sum = sum + array[i, j];

                    ///Tam giác trên//
                    if (i > j) { tgt = tgt + array[i, j]; }

                    //Tam giác dưới///
                    if (i < j) { tgd = tgd + array[i, j]; }

                    /// Đường chéo phụ//
                  
                    if (i+j==array.Length+1) { sump = sump + array[i, j]; }

                    //max///
                    if (array[i, j] > max)
                    {
                        max = array[i, j]; vitrim = i; vitricotm = j;
                    }

                    ///min////
                        if (array[i, j] < min)
                        {
                            min = array[i, j]; vtcmin = i; vtdmin = j;

                        }

                    ///Đường chéo chính///
                    if (i == j) { sumc = sumc + array[i, j]; }

                    /// Đường chéo phụ//

                    //if (i + j == array.Length + 1) { sump = sump + array[i, j]; }

                }

                Console.WriteLine();
            }
            
          
           


                    Console.WriteLine();
            Console.WriteLine($"Tổng của tất cả giá trị là {sum}");
            Console.WriteLine();
            Console.WriteLine($"Gía Trị Lớn Nhất Trong Mảng Là {max} năm ở dòng {vitrim+1} và nằm ở cột {vitricotm+1}");
            Console.WriteLine();
            Console.WriteLine($"Gía Trị Nhỏ Nhất  Trong Mảng Là {min} năm ở dòng {vtcmin+1} và nằm ở cột {vtdmin+1}");
            Console.WriteLine();
            Console.WriteLine("Tổng đường chéo chính là " + sumc);
            Console.WriteLine();
            Console.WriteLine("Tổng đường chéo phụ  là " + sump);
            Console.WriteLine();
            Console.WriteLine("Tam giác trên "+tgt );
            Console.WriteLine();
            Console.WriteLine("Tam giác dưới " + tgd);
        }
    }
}
