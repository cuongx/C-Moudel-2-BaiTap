using System;
using System.Text;

namespace Kiemtra_lan2
{
    class Program
    {
        public static int[] array;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            CreateMenu();
        }
        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("\nPlease select an option from 1 to 5:");
                Console.WriteLine("1. Tạo mảng");
                Console.WriteLine("2. Kiểm tra mảng đối xứng");
                Console.WriteLine("3. Sắp xếp mảng");
                Console.WriteLine("4. Tìm kiếm");
                Console.WriteLine("5. Thoát");
                Console.Write("Input number: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option > 5 || option < 1);

            Process(option);
        }

        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        CreateArray();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(IsSymmetryArray());
                        break;
                    }
                case 3:
                    {
                        InsertSort();
                        break;
                    }
                case 4:
                    {
                        InsertSort();
                        Find();
                        break;
                    }
                case 5:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }
        public static void CreateArray()
        {
            try
            {
                Console.Write("Input length: ");
                int length = int.Parse(Console.ReadLine());
                array = new int[length];
                Random rnd = new Random();
                for (int i = 0; i < length; i++)
                {
                    array[i] = rnd.Next(30, 60);
                    Console.Write(array[i] + " ");
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong data.Please enter again! ");
                CreateArray();
            }


        }
        public static bool IsSymmetryArray()
        {
            int hei = array.Length;
            for (int i = 0; i < hei / 2; i++)
            {
                if (array[i] != array[hei - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void InsertSort()
        {
            int hei = array.Length;
            int[] arr = array;
            for (int i = 0; i < hei; i++)
            {
                array[i] = MinArray(ref arr);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static int MinArray(ref int[] arr)
        {
            int min = arr[0];
            int id = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    id = i;
                }
            }
            for (int i = id; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return min;
        }
        public static void Find()
        {
            try
            {
                Console.Write("\nInput number: ");
                int num = int.Parse(Console.ReadLine());
                int ind = BinarySearh(num);
                if (ind == -1)
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    Console.WriteLine($"{num} at position {ind + 1}");
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong data.Please enter again! ");
                Find();
            }

        }
        public static int BinarySearh(int key)
        {
            int low = 0;
            int hei = array.Length - 1;
            while (hei >= low)
            {
                int mid = (hei + low) / 2;
                if (key < array[mid])
                {
                    hei = mid - 1;
                }
                else if (key == array[mid])
                {
                    return mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}