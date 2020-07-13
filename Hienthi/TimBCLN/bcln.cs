using System;

namespace TimBCLN
{
    class bcln 
    {
        static void Main(string[] args)
        {
            int n1, j, n2, hcf=1,bscnn;
           
            Console.WriteLine("Nhập vào số a");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào số B");
            n2 = Convert.ToInt32(Console.ReadLine());
            bscnn = (n1 * n2) / hcf;
            j = (n1 < n2) ? n1 : n2;

            for (int i = 1; i <= j; i++)
            {

                if (n1 % i == 0 && n2 % i == 0)
                {
                    hcf = i;
                }
            }
            /* chung ta biet rang: tich cua uoc so chung lon nhat va boi 
            so chung nho nhat thi bang tich cua hai so.*/
            bscnn = (n1 * n2) / hcf;

            Console.WriteLine("bscnn" + n1, n2, bscnn);
            Console.ReadKey();

        }
     }
}
