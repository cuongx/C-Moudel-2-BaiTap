using System;

namespace Thuậttoantimkiemtuyentinh
{
    class Program
    {
        public static int Search(int[] arr, int x)
        {
          
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 40;

            int result = Search(arr, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);
        }
    }
}
