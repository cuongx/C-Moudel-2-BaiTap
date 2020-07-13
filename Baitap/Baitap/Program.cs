using System;

namespace Baitap
{
    class Program
    {
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
                Console.WriteLine("1. NewOrder");
                Console.WriteLine("2. UpdateOrder");
                Console.WriteLine("3. CancelOrder");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Pay");
                Console.WriteLine("6. Exit");
                Console.Write("Input number: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
                if (option > 6 || option < 1)
                {
                    Console.Clear();
                }
            }
            while (option > 6 || option < 1);

            Process(option);
        }

        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        NewOrder();
                        break;
                    }
                case 2:
                    {
                        UpdateOrder();
                        break;
                    }
                case 3:
                    {
                        Cancel();
                        break;
                    }
                case 4:
                    {
                        Search();
                        break;
                    }
                case 5:
                    {
                        Pay();
                        break;
                    }
                case 6:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }


        public static Coffee coffee = new Coffee();

        public static void NewOrder()
        {
            Console.WriteLine("Tableid ");
            int.TryParse(Console.ReadLine(), out int id);
            if (!coffee.Check(id))
            {
                Table table = new Table();
                table.TableId = id;
                bool result = false;

                do
                {
                    OrderDetail newOrder = new OrderDetail();
                   
                    Console.Write("Name: ");
                    newOrder.Name = (Console.ReadLine()).ToLower();
                    Console.Write("Price: ");
                    newOrder.Price = long.Parse(Console.ReadLine());
                    Console.Write("Count: ");
                    newOrder.Count = int.Parse(Console.ReadLine());
                    result = true;

                    Console.WriteLine("Bạn có muốn thêm món không");
                    int.TryParse(Console.ReadLine(), out id);
                    if(id != 1)
                    {
                        result = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Table " + table.TableId);
                    }

                    bool check = false;
                    foreach(var item in table.OrderDetails)
                    {
                        if (item.Name.Equals(id))
                        {
                            newOrder.Count += item.Count;
                            check = true;
                          
                        }
                    }
                    if (!check)
                    {
                        table.OrderDetails.Add(newOrder);
                    }
                
                } while (result);

                table.EndTime = DateTime.Now.ToString();
                coffee.NewOrder(table);
            }


        }

        public static void UpdateOrder()
        {
            Console.WriteLine("Tableid ");
            int.TryParse(Console.ReadLine(), out int id);
            if (coffee.Check(id))
            {
                bool result = false;

                do
                {
                    OrderDetail newOrder = new OrderDetail();
                    Console.Write("Name: ");
                    newOrder.Name = (Console.ReadLine()).ToLower();
                    Console.Write("Price: ");
                    newOrder.Price = long.Parse(Console.ReadLine());
                    Console.Write("Count: ");
                    newOrder.Count = int.Parse(Console.ReadLine());

                    Console.WriteLine("Bạn có muốn thêm món không");
                    int.TryParse(Console.ReadLine(), out id);
                    if (id != 1)
                    {
                        result = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("TableId " + newOrder );
                    }
                    bool check = false;
                    foreach (OrderDetail item in coffee.Tables[id].OrderDetails)
                    {
                        if (item.Name.Equals(id))
                        {
                            newOrder.Count += item.Count;
                            check = true;

                        }
                    }
                    if (!check)
                    {
                        coffee.UpdateOrder(newOrder, id);
                    }
                } while (result);
            
            
            
            }
                

            }          

        public static void Search()
        {
            Console.Write("TableID: ");
            int.TryParse(Console.ReadLine(), out int id);
            if (coffee.Check(id) && id != 0)
            {
                coffee.Search(id);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public static void Cancel()
        {
            Console.Write("TableID: ");
            int id = int.Parse(Console.ReadLine());
            if (coffee.Check(id) && id != 0)
            {
                coffee.Remove(id);
            }
            else
            {
                Console.WriteLine("Invailid Table");
            }
        }

        public static void Pay()
        {
            Console.Write("TableID: ");
            int.TryParse(Console.ReadLine(), out int id);
            if (coffee.Check(id) && id != 0)
            {
                coffee.Pay(id);
            }
            else
            {
                Console.WriteLine("Invailid Table");
            }
        }
    }
}
