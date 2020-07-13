using System;

namespace thuattoantimkiemnhiphankhongdequy
{
   public class Program
    {
       
      
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 1, 5, 6, 85, 89, 2, 6,8 };
            //Console.WriteLine(BinarySearch(list, 5));
            int key = 6;
            int result = BinarySearch(list, key);
            if(result == -1)
            {
                Console.WriteLine("Not");
            }
            else
            {
                Console.WriteLine(result);
            }
             
        
        }
        static int BinarySearch(int[] list, int key)
        {
            int low = 0;
            int high = list.Length - 1;
           
            while (high >= low)
            {
                int mid = (low + high) / 2;
                if (key < list[mid])
                    high = mid - 1;
                else if (key == list[mid])
                    return mid;
                else
                    low = mid + 1;

            }

            return -1;
        }

    }
}
