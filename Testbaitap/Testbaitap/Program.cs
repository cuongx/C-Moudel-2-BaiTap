using System;

namespace Testbaitap
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
                        Remove();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Searching();
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        Raiting();
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
                        Show();
                        break;
                    }
            }

            CreateMenu();
        }

        public static Forum ace = new Forum();
        public static void Add()
        {
            Post ae = new Post();
           
            Console.WriteLine("Nhập title");
            ae.Title = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhập centent");
            ae.Content = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhập author");
            ae.Author = Convert.ToString(Console.ReadLine());
            //ae.CalculatorRate();
            ae.id = ace.Posts.Count;
            ace.Add(ae);
        }
        public static void Update()
        {
            Console.WriteLine("Nhập id ");
            int.TryParse(Console.ReadLine(), out int id);
            Console.WriteLine("Nhập content");
            string content = Convert.ToString(Console.ReadLine());
            ace.Update(id, content);
        }
        public static void Remove()
        {
            Console.WriteLine("Nhập id ");
            int.TryParse(Console.ReadLine(), out int id);
            ace.Remove(id);
        }
        public static void Searching()
        {
            Console.WriteLine("Nhập name");
            string author=Console.ReadLine();
            ace.Searching(author);
        }
        public static void Show()
        {

            ace.Show();
        }
        public static void Raiting()
        {
            Console.WriteLine("Nhập id");
            int.TryParse(Console.ReadLine(), out int id);
            Console.WriteLine("Nhập 1 đến 5");
            int.TryParse(Console.ReadLine(), out int ad);
            
            ace.Rate(id, ad);
        }


    }
}
