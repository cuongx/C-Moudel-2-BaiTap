using System;

namespace Thuattoantimkiemnhiphandemo
{
    class Program
    {
        static int BinarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = (r + l) / 2;

           
                if (arr[m] == x)
                    return m;
              
                if (arr[m] < x)
                    l = m + 1;
               
                else
                    r = m - 1;
            }
           
            return -1;
        }
        static void Main(string[] args)
        {

            int[] arr = { 2, 3, 4, 10, 40 };
            
            int x = 10;
            int result = BinarySearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }
    }
}
