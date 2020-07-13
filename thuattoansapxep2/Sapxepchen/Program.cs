using System;
using System.Collections;
using System.Globalization;

namespace Sapxepchen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3,5, 4, 5, 7, 8, 6, 4, 5 };
            Chen(arr);
            //hienthi(arr);
        }
        static void Chen(int[] arr)
        {
            int n = arr.Length;
            for(int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while(key<arr[j] && j >= 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;

                string a = "";
                foreach (int pb in arr)
                {
                    a = a + pb + " ";

                }
                Console.WriteLine(a);
            }
            

        }
        //static void hienthi(int[] arr)
        //{
        //    for (int i = 0; i< arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i] + " " );
        //    }
        //}
    }
}


