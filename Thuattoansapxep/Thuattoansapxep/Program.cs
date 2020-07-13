using System;

namespace Thuattoansapxep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2,4,5,8,7,4,3,6,9,7};
            BubleSort(arr);
            Console.WriteLine("Sort array");
            Print(arr);
        }


        static void BubleSort(int[] arr)
        {
            int i, j, temp;
            bool check;
            int n = arr.Length;
            for (i = 0; i < n-1; i++)
            {
                check = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                        check = true;
                    }
                }
                
            }
        }
        static void Print(int [] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            
        }
    }
}
