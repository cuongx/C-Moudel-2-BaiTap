using System;

namespace KiemtraMoudel2
{
    class Program
    {
        public static int[] arr;
        static void Main(string[] args)
        {
           
            CreateMenu();
        }
        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please select an option from 1 to 6:");
                Console.WriteLine("1. Create Mang");
                Console.WriteLine("2. Kietra");
                Console.WriteLine("3. Sap xep");
                Console.WriteLine("4. Search");
               
                Console.WriteLine("6. Exit");
                Console.Write("Input number: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
                if (option > 5 || option < 1)
                {
                    Console.Clear();
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
                        Console.WriteLine("mỜI BẠN NHẬP");
                        int n = int.Parse(Console.ReadLine());
                        CreateArray(n);

                        break;
                    }
                case 2:
                    {
                       
                        Console.WriteLine(isSymmetryArray());
                        break;
                    }
                case 3:
                    {                     
                        InsertionSort();
                        
                        break;
                    }
                case 4:
                    {
                        Fin();
                        InsertionSort();
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

        public static void CreateArray(int n)
        {
            try
            {
                //int n = int.Parse(Console.ReadLine());
                arr = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(30, 60);
                    Console.Write(arr[i] + " ");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Hello");
                CreateArray(n);


            }
        }
        public static void InsertionSort()
        {
            try
            {
                int n = arr.Length;
               for(int i = 0; i < n; i++)
                {
                    int min = i;
                    for(int j = i + 1; j < n; j++)
                    {
                        if (arr[j] < arr[min])
                        {
                            min = j;
                        }
                        if (min != i)
                        {
                            int temp = arr[min];
                            arr[min] = arr[i];
                            arr[i] = temp;
                        }
                    }
                    Console.Write(arr[i] + " ");
                }
                
                    
                
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi");
                CreateMenu();
            }

        }
        public static bool isSymmetryArray()
        {
            try {                
                int n = arr.Length;
                for (int i = 0; i < n / 2; i++)
                {
                    if (arr[i] != arr[n - i - 1])
                    {
                        return false;
                    }
                }
               
            }
        
            catch (Exception)
            {

                Console.WriteLine("Not");
            }
            return true;
        }


        public static void Fin()
        {
            try
            {
                Console.WriteLine("Nhập số cần tìm");
                int num = int.Parse(Console.ReadLine());
                int abc = BinarySearch(num);
                if (abc == -1)
                {
                    Console.WriteLine("Not found ");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{num} Located in position is {abc + 1} ");
                }
            }
            catch (Exception)
            {
                Console.Clear();
              
                CreateMenu();
            }

        }

        public static int BinarySearch(int x)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (r>=l)
            {
                int m = (l + r) / 2;

                if (arr[m] == x)
                {
                    return m;
                }
                else if (arr[m] > x)
                {
                    r = m - 1;
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
