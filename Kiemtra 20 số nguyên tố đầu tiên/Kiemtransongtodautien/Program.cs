using System;
using System.Collections.Specialized;

namespace Kiemtransongtodautien
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Nhap();
            Hienthikq(a);
        }

        private static void Hienthikq(int n)
        {
            int i = 2;
            int count = 0;
            while(count < n)
            {
                if (Ktngto(i))
                {
                    count++;
                    Console.WriteLine(i +  " ");
                }
                i++;
            }
        }

        static bool Ktngto(int n)
        {
            int i = 2;
            if (n < 2) { return false; }
          for(i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
       static int Nhap()
        {
            int n = 0;
            while (n <=0)
            {
                Console.WriteLine("Mời bạn nhập lớn hơn 0");             
                 n = Int32.Parse(Console.ReadLine());
                if (n>0)
                {
                    break;
                }
            }
            return n;
        } 
    }
}
