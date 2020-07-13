using System;

namespace Thuattoantimkiemnhiphan
{
    class Program
    {
        static int BinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // Nếu phần tử có mặt tại
                // chính giữa
                if (arr[mid] == x)
                    return mid;

                //Nếu phần tử nhỏ hơn mid, thì
                 // nó chỉ có thể có mặt trong subarray trái
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);

                // Khác phần tử chỉ có thể có mặt
                // trong phân đoạn bên phải
                return BinarySearch(arr, mid + 1, r, x);
            }

            // Chúng ta đến đây khi không có phần tử
            // trong mảng
            return -1;
        }
            static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7,8,9 };
            int n = arr.Length;
            int x = 10;

            int result = BinarySearch(arr,0, n-1 , x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }
    }
}
