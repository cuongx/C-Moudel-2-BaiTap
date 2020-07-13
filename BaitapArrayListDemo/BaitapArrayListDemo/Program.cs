using System;

namespace BaitapArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static PhoneBook alon = new PhoneBook();
        public static void Menu()
        {
            int seclect = 0;
            do
            {
                Console.WriteLine("PHONE MANAGEMENT SYSTEM");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Update Phone");
                Console.WriteLine("3. Remove Phone ");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Exit");
                Console.WriteLine("7. Show");
                Console.Write("Please select an option (1-7): ");
                int.TryParse(Console.ReadLine(), out seclect);
                if (seclect < 1 || seclect > 7)
                {
                    Console.Clear();
                }
            } while (seclect < 1 || seclect > 7);

            Process(seclect);
        }


        public static void Process(int seclect)
        {
            Console.Clear();

            switch (seclect)
            {
                case 1:
                    {
                        Console.Clear();
                        Add();

                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Update();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Removee();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Serching();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        Sort();
                        break;
                    }
                case 6:
                    {
                        Environment.Exit(0);
                        break;
                    }
                case 7:
                    {
                        Console.Clear();
                        ShowID();
                        break;
                    }
            }
            Menu();
        }
        public static void Add()
        {
            Console.WriteLine("Nhập tên");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập số ");
            string numberphone = Console.ReadLine();
            alon.insertPhone(name, numberphone);
        }
        public static void Removee()
        {
            Console.WriteLine("Nhập tên");
            string name = Console.ReadLine();
            alon.removePhone(name);
        }
        public static void Serching()
        {
            
            Console.WriteLine("Nhập tên");        
            string name = Console.ReadLine();
            Console.Clear();
            alon.SearchPhone(name);

        }
        public static void Update()
        {
            Console.WriteLine("Nhập tên");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập số ");
            string numberphone = Console.ReadLine();
            alon.updatePhone(name, numberphone);
        }
        public static void Sort()
        {

            alon.Sort();
        }
        public static void ShowID()
        {
            alon.Show();
        }
    }
}
