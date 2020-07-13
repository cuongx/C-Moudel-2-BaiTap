using System;

namespace Thuattoantimkiem
{
    class Program
    {
      public static int Search(int[]arr,int x)
        {
            int i;
            int n = arr.Length;
            for (i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {

            int[] arr = { 1, 4, 8, 7, 5, 9, 4, 3, 6 };
            foreach(int pb in arr)
            {
                Console.Write(pb + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Nhập x ");
            int x = int.Parse(Console.ReadLine());

            int result = Search(arr, x);
            if(result == -1)
            {
                Console.WriteLine("Lon");
            }
            else
            {
                Console.WriteLine(result);
            }
          
        }
    }
}
