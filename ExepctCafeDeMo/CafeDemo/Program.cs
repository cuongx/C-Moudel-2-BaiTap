using CafeDemo.Models;
using CafeDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeDemo
{
    class Program
    {
        public static string path = @$"D:\Moudel 2\ExepctCafeDeMo\CafeDemo\Data\";
        public static string fillname ="Data.json";
        public static CofffeeService cofffeeService = new CofffeeService(path,fillname);
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
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
                Console.WriteLine("3. ShowTable");
                Console.WriteLine("4. Showall");
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
                        ShowTable();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(cofffeeService.ShowAll());
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

        public static void NewOrder()
        {
            Console.Write("TableId: ");
            var tableId = Console.ReadLine();
            if (cofffeeService.Check(tableId) == null)
            {
                Table table = new Table()
                {
                    endtime = "",
                    ispaid = false,
                    starttime = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"),
                    tableid = tableId,
                };
                Console.Write("Cashier: ");
                table.cashier = Console.ReadLine();
                Console.WriteLine("Input order: ");
                table.orderDetail = NewListOrder();
                cofffeeService.NewOrder(table);
                Console.WriteLine("Order success");
            }
            else
            {
                Console.WriteLine("Table is using");
            }

        }
        public static void UpdateOrder()
        {
            Console.Write("TableId: ");
            var tableId = Console.ReadLine();
            Table table = cofffeeService.Check(tableId);
            if (table != null)
            {
                Console.WriteLine("Input order: ");
                List<OrderDetails> ListNewOrder = NewListOrder();

                cofffeeService.UpdeteOrder(tableId, ListNewOrder);
                Console.WriteLine("Order success");
            }
            else
            {
                Console.Write("Not found table.Please enter tableId again!\n");
            }
        }

        public static void ShowTable()
        {
            Console.Write("TableId: ");
            var tableId = Console.ReadLine();
            if (cofffeeService.Check(tableId) != null)
            {
                Console.WriteLine(cofffeeService.Showtable(tableId));
            }
            else
            {
                Console.WriteLine("Not found table.Please enter again!\n");
            }
        }

        public static void Pay()
        {
            Console.Write("TableId: ");
            var tableId = Console.ReadLine();
            Table table = cofffeeService.Check(tableId);
            if (table != null) 
            {
                table.endtime = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                Console.WriteLine(table.ToString());
                Console.Write("Do you want to add order? y/n:");
                string pass = Console.ReadLine();
                if (pass.ToLower() == "y")
                {
                    cofffeeService.Pay(tableId);
                    Console.WriteLine($"Pay Table {tableId} success!");
                }
            }
            else
            {
                Console.WriteLine("Not found table.Please enter again!\n");
            }
        }

        public static List<OrderDetails> NewListOrder()
        {

            List<OrderDetails> newList = new List<OrderDetails>();
            string pass = "";
            do
            {
                OrderDetails order = neworder();
                if (order != null)
                {
                    InputOrder(newList, order);
                    Console.WriteLine("Order success");
                    Console.Write("Do you want to add order? y/n:");
                    pass = Console.ReadLine();
                }
                else
                {
                    pass = "n";
                }

            } while (pass.ToLower() == "y");
            return newList;
        }
        public static OrderDetails neworder()
        {
            OrderDetails order = new OrderDetails();
            try
            {
                Console.Write("Name: ");
                order.name = Console.ReadLine();
                Console.Write("Count: ");
                order.count = int.Parse(Console.ReadLine());
                Console.Write("Price: ");
                order.price = int.Parse(Console.ReadLine());
                return order;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong data. Please enter again!");
                Console.Write("Do you want to add order? y/n:");
                string pass = Console.ReadLine();
                if (pass.ToLower() == "y")
                {
                    return neworder();
                }
                return order = null;
            }
        }
       public  static void InputOrder (List<OrderDetails>listOrder,OrderDetails order)
        {
            bool result = false;
            foreach(OrderDetails od in listOrder)
            {
                if (od.name.ToLower().Equals(od.name.ToLower())){

                    od.count += order.count;
                    result = true;
                }
            };

            if (!result)
            {
                listOrder.Add(order);
            }
        }
    }
}


    

