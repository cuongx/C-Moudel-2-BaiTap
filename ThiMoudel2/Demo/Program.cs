using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                CreateMenu();
            }
        }
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
                Console.WriteLine("6. Pay");
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
                        Neworder();
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
                        //Remove();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                       
                        break;
                    }
                case 5:
                    {
                        Console.Clear();
                        //Searching();
                        break;
                    }
                case 6:
                    {
                        Console.Clear();
                        Pay();
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
        public static Coffee ace = new Coffee();
        public static void Neworder()
        {
            Console.WriteLine("Tableid ");
            int.TryParse(Console.ReadLine(), out int id);
            if (!ace.Check(id))
            {
                Table table = new Table();
                table.Tableid = id;
                bool result = false;

                do
                {
                    OrrderDetail order = new OrrderDetail();
                    Console.WriteLine("Name ");
                    order.Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Price ");
                    order.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Count ");
                    order.Count = int.Parse(Console.ReadLine());
                    result = true;

                    Console.WriteLine("Bạn có muốn gọi món tiếp ");
                    int.TryParse(Console.ReadLine(), out int indi);
                    if (indi == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(table.Tableid);
                    }
                    else
                    {
                        result = false;
                    }

                    bool check = false;
                    foreach (OrrderDetail pb in table.OrrderDetails)
                    {
                        if (pb.Name.ToLower().Equals(order.Name))
                        {
                            pb.Count += order.Count;
                            check = true;
                        }

                    }
                    if (check == false)
                    {
                        table.OrrderDetails.Add(order);

                    }

                } while (result);

                table.Endtime = DateTime.Now.ToString();
                ace.NewOrder(table);
            }
            else
            {
                Console.WriteLine("Is Not Complete");
            }

        }
        public static void Update()
        {
            Console.WriteLine("Tableid ");
            int.TryParse(Console.ReadLine(), out int id);
            if (ace.Check(id))             
            {
                bool result = true;
                do
                {
                    OrrderDetail order = new OrrderDetail();

                    Console.WriteLine("Name ");
                    order.Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Price ");
                    order.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Count ");
                    order.Count = int.Parse(Console.ReadLine());

                 

                    Console.WriteLine("Bạn có muốn gọi thêm món không");
                    int.TryParse(Console.ReadLine(), out id);
                    if (id != 1)
                    {
                        
                        result = false;
                    }
                    {
                        Console.Clear();
                        Console.WriteLine( "Tabled " + id);
                        result = true;
                        
                    }
                    bool check = false;

                    foreach(OrrderDetail pb in ace.Tables[id].OrrderDetails)
                    {
                        if (pb.Name.ToLower().Equals(order.Name))
                        {
                            pb.Count += order.Count;
                            check = true;
                            break;
                        }
                    }
                    if(check == false)
                    {
                        ace.UpdateOrder(order, id);
                    }

                } while (result);
            }
            else
            {
                Console.WriteLine("Not complete");
            }
        }
        public static void Pay()
        {
            Console.Clear();
            Console.WriteLine("Tableid ");
           
            int id = int.Parse(Console.ReadLine());
            if (ace.Check(id))
            {
                ace.Pay(id);
            }
            else
            {
                Console.WriteLine("Not is Complete");
            }
        }
        public static void Remove()
        {
            Console.WriteLine("Tableid ");
            int id = int.Parse(Console.ReadLine());
            if (ace.Check(id))
            {
                ace.CancelOrder(id);
            }
            else
            {
                Console.WriteLine("Not is Complete");
            }
        }
        public static void Searching()
        {
            Console.WriteLine("Tableid ");
            int id = int.Parse(Console.ReadLine());
            if (ace.Check(id))
            {
                ace.Search(id);
            }
            else
            {
                Console.WriteLine("Not is Complete");
            }
        }
        public static void Show(int id)
        {
            int.TryParse(Console.ReadLine(), out  id);
            if (ace.Check(id))
            {
                ace.Show(id);
            }
        }
    }

}
