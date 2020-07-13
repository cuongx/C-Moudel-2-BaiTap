using System;
using System.Text;
namespace Cau2Kiemtra
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
                Console.WriteLine("2. Kiểm tra mảng có giảm dần không");
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
                        Console.WriteLine(Islncrement());
                        break;
                    }
                case 3:
                    {
                        BubbleSort();
                        break;
                    }
                case 4:
                    {
                        BubbleSort();
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
            Console.WriteLine("Nhập mảng");
            int length = int.Parse(Console.ReadLine());
            array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(40, 80);
                Console.Write(array[i] + " ");
            }
        }
        public static bool Islncrement()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void BubbleSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                Console.Write(array[i] + " " );

            }
        }
        public static void Find()
        {
            try
            {
                Console.WriteLine("Nhap so");
                int x = int.Parse(Console.ReadLine());         
                int n = Searching(x);
                if (x != -1)
                {
                    Console.WriteLine();
                    Console.WriteLine($" {x} postion {n}");
                }
                else
                {
                    Console.WriteLine("Không có trong mảng");
                }
            
            }
            catch (Exception)
            {

                Find();
            }
        }
        public static int Searching(int x)
        {
            int l = 0;
            int n = array.Length;           
            while (l <= n)
            {
                int m = (l + n) / 2;
                if (array[m] == x)
                {
                    return m;
                }
                else if (array[m] > x)
                {
                    n = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
          
            return -1;
        }
        
    }
}

