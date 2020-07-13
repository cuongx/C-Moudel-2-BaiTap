using System;

namespace Sapxepchon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 3, 6, 8, 7, 9, 13 };
            Chon(arr);
            hienthi(arr);
        }
        static void Chon(int[] arr)
        {
            int n = arr.Length;
            for(int i = 0; i<n;i++){

                int min = i;
                for (int j =i+1; j <n; j++)
                {
                    if (arr[j] < arr[min])
                    {

                        min = j;
                    }
                    if (min != i)
                    {
                        int t = arr[min];
                        arr[min] = arr[i];
                        arr[i] = t;
                    }
                }
            }
                   
          }

              
        static void hienthi(int []arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
