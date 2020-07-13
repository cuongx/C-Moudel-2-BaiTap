using System;

namespace Duongcheophu
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, sum = 0, n, m = 0;
            int[,] arr1 = new int[50, 50];


            Console.Write("\nTinh tong cac phan tu tren duong cheo phu cua ma tran trong C#:\n");
            Console.Write("--------------------------------------------------------------\n");

            Console.Write("Nhap kich co cua ma tran vuong: ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            Console.Write("Nhap cac phan tu vao trong ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("In ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            // tinh tong cac phan tu tren duong cheo phu 
            for (i = 0; i < n; i++)
            {
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arr1[i, j];
                    }

                }
            }
            Console.Write("Tong cac phan tu tren duong cheo phu la: {0}\n", sum);

            Console.ReadKey();
        
     }
    }
}
