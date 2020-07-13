using System;
using System.ComponentModel;

namespace BaitapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMenu();
        }
        public static Forum ace = new Forum();
        public static void CreateMenu()
        {
            int selected = 0;
            do
            {
                Console.WriteLine("Please select an option from 1 to 6:");
                Console.WriteLine("1. Create Post");
                Console.WriteLine("2. Update Post");
                Console.WriteLine("3. Remove Post");
                Console.WriteLine("4. Show Post");
                Console.WriteLine("5. Search Post");
                Console.WriteLine("6. Rating");
                Console.WriteLine("7. Exit");
                Console.Write("Input number: ");
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
                        Updatee();
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
                        Show() ;
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        Search();
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        Raiting();
                        break;
                    }
                case 7:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
            }

            CreateMenu();
        }
        public static void Add()
        {
            Post post = new Post();

            Console.Write("Input new Title:");
            post.Title = Console.ReadLine();
            Console.Write("Input Content:");
            post.Content = Console.ReadLine();
            Console.Write("Input Author:");
            post.Author = Console.ReadLine();
            post.CaculatorRate();
            post.Id = ace.Posts.Count;
            ace.Add(post);
        }
        public static void Raiting()
        {
            Console.Write("Input Id Post:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Input Rate (1-5):");
            int rate = int.Parse(Console.ReadLine());
            ace.Raiting(id, rate);
        }
        public static void Updatee()
        {
            Console.Write("Input Id Post:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Input Content:");
            string content =Convert.ToString (Console.ReadLine());
            ace.Update(id,content);
        }
        public static void Search()
        {
            Console.WriteLine("Tác giả hoặc tiêu đề đầu vào:");
            string auto = Console.ReadLine();
            ace.Search(auto);
        }
        public static void Remove()
        {
            Console.Write("Input Id Post:");
            int id = int.Parse(Console.ReadLine());
            ace.Remove(id);
        }
        public static void Show()
        {
            ace.Show();
        }
    }
}
