using System;

namespace Thuattoantimkiemnhiphan
{
    class Program
    {
        // else return -1 
        static int BinarySearch(int[] arr, int x)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int m = (r+l) / 2;

                // Kiểm tra xem x có ở giữa không
                if (arr[m] == x)
                    return m;

                // Nếu x lớn hơn, bỏ qua nửa bên trái
                if (arr[m] < x)
                    l = m + 1;

                // Nếu x nhỏ hơn, bỏ qua một nửa bên phải
                
                    r = m - 1;
            }

            // nếu chúng ta đến đây, thì phần tử là
            // không hiện diện
            return -1;
        }
    
        static void Main(string[] args)
        {

            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int result = BinarySearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result);
        }
    }
}
