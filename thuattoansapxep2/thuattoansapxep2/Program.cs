using System;

namespace thuattoansapxep2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 5, 4, 7, 8, 9, 6, 4 };
            Noibot(list);
            Console.WriteLine("sapxep");
            hienthi(list);
        }
        static void Noibot(int[] list)
        {
            int i, j, temp;
            int n = list.Length;
            bool result = false;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        result = true;
                    }
                }
                if (!result)
                {
                    break;
                }
            }
        }
            static void hienthi(int[] list)
            {
                int i;
                for (i = 0; i < list.Length; i++)
                {
                    Console.WriteLine(list[i] + "  ");
                }
            }
        }
    }


    

