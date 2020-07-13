using System;
using System.Collections;
using System.ComponentModel;

namespace BaiTapDeMo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMenu();
         
        }
       
        public static void CreateMenu()
        {
            int selected = 0;
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
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 7)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 7);

            Process(selected);
        }

        public static void Process(int selected)
        {
            Console.Clear();

                switch (selected)
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
                            Search();
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

            CreateMenu();
        }

        public static PhoneBook ace = new PhoneBook();
        public static void Add()
        {
           
            Console.WriteLine("Nhập name");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập phone");
            var phone = Console.ReadLine();
            ace.InsertPhone(name, phone);
        }
        public static void Update()
        {
            Console.WriteLine("Nhập name");
            string Names = Console.ReadLine();          
            Console.WriteLine("Nhập phone");
            string newphone = Console.ReadLine();
            ace.updatePhone(Names, newphone);
        }
       
        public static void Search()
        {
           
            Console.WriteLine("Nhập name");
            string name = Console.ReadLine();
            Console.Clear();
            ace.SearchPhone(name) ;
        }
        public static void ShowID()
        {
            ace.Show();
        }
        public static void Removee()
        {
            Console.WriteLine("Nhập name");
            string name = Console.ReadLine();          
            ace.removePhone(name);
        }
        public static void Sort()
        {
            ace.Sort();
        }
    }
}

