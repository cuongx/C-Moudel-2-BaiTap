using System;

namespace hienthi100Snt
{
    class Program
    {
        static void Main(string[] args)
        {

            int dem = 0;

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }
                }

                    if (dem == 2)
                    {
                        Console.WriteLine(i);
                    }
                dem = 0;
                }
            }
        }
   }


