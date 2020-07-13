using System;

namespace Baitapanhkhoa
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
                Console.WriteLine("1. Insert ");
                Console.WriteLine("2. Update ");
                Console.WriteLine("3. Remove Phone ");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Pay");
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
                        Pay();
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
                        //ShowID();
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
                bool result = false;
                Table ec = new Table();
                ec.Tableid = id;

                do
                {
                    OrderDetail order = new OrderDetail();
                    Console.WriteLine("Name ");
                    order.Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Price ");
                    order.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Count ");
                    order.Count = int.Parse(Console.ReadLine());

                    result = true;

                    Console.WriteLine("Bạn có muốn gọi món tiếp ");
                    int.TryParse(Console.ReadLine(), out int indi);
                    if(indi != 1)
                    {
                        result = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Tableid "+ ec.Tableid);
                    }

                    bool check = false; ;

                      foreach(OrderDetail pb in ec.OrderDetails)
                      {
                        if (pb.Name.ToLower().Equals(order.Name))
                        {
                            order.Count += pb.Count;
                            check = true;
                            break;
                        }
                       
                      }
                    if (check == false)
                    {
                        ec.OrderDetails.Add(order);
                    }

                } while (result);
                ec.StarTime = DateTime.Now.ToString();
            }
            else
            {
                Console.WriteLine("Invalid Table");
            }
        }
        public static void Update()
        {
            Console.WriteLine("Tableid ");
            int.TryParse(Console.ReadLine(), out int id);
            if (ace.Check(id))
            {
                bool result = false;           
                do
                {
                    OrderDetail order = new OrderDetail();
                    Console.WriteLine("Name ");
                    order.Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Price ");
                    order.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Count ");
                    order.Count = int.Parse(Console.ReadLine());

                    result = true;

                    Console.WriteLine("Bạn có muốn gọi món tiếp ");
                    int.TryParse(Console.ReadLine(), out int indi);
                    if (indi != 1)
                    {
                        result = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Tableid " + id);
                    }

                    bool check = false; ;

                    foreach (OrderDetail pb in ace.Tables[id].OrderDetails)
                    {
                        if (pb.Name.ToLower().Equals(order.Name))
                        {
                            pb.Count += order.Count;
                            check = true;
                            break;
                        }

                    }
                    if (check == false)
                    {
                        ace.UpdateOrder(id, order);
                    }

                } while (result);
             
            }
            else
            {
                Console.WriteLine("Invalid Table");
            }
        }
        public static void Pay()
        {
            Console.WriteLine("Tableid ");
            int.TryParse(Console.ReadLine(), out int id);
            if (ace.Check(id))
            {
                ace.Pay(id);
            }
        }
    }
}
