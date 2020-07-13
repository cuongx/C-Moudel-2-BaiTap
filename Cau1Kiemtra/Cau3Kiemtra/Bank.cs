using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3Kiemtra
{
      class Bank
        {
          static void Main(string[] args)
        {
                CreateMenu();
            }
            public static
            void  CreateMenu()
            {
                int selected = 0;
                do
                {
                    Console.WriteLine("Please select an option from 1 to 6:");
                    Console.WriteLine("1. CreateAccount");
                    Console.WriteLine("2. PayInto");
                    Console.WriteLine("3. Show Customers");
                    Console.WriteLine("4. Exit");                  
                    Console.Write("Please select an option (1-4): ");
                    int.TryParse(Console.ReadLine(), out selected);
                    if (selected < 1 || selected > 4)
                    {
                        Console.Clear();
                    }
                }
                while (selected < 1 || selected > 4);

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
                            CreateAccount(id);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            PayInto();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                        ShowData();
                        break;
                        }

                    case 4:
                        {
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        }
                }

                CreateMenu();
            }
       
        public static Dictionary<int, Account> AcountList = new Dictionary<int, Account>();
        public static int id = 0;
        public static int Check(int id)
        {
            foreach(var pb in AcountList.Keys)
            {
                if (pb==id)
                {
                    return pb;
                }
            }
            return -1;
        }
        public static void CreateAccount(int id)
        {
            int index = Check(id);
            if(index == -1)
            {
                Account account = new Account();
                Console.WriteLine("Nhập FistName");
                account.Fristname = Console.ReadLine();
                Console.WriteLine("Nhập Last Name");
                account.Lastname = Console.ReadLine();
                Console.WriteLine("Nhập Gender");
                account.Gender = Console.ReadLine();
                account.Accountld = ++id;
                AcountList.Add(id, account);
                Console.WriteLine("ok");
            }

        }
        public static void PayInto()
        {
            try
            {
                Console.WriteLine("Nhập id");
                int n = int.Parse(Console.ReadLine());
                int index = Check(n);
                if (index != -1)
                {
                    Console.WriteLine("Thêm tiền vào tài khoản");
                    float amount = int.Parse(Console.ReadLine());
                    AcountList[index].Paylnto(amount);
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Id chưa tồn tại");
                }
            }
            catch (Exception)
            {

                PayInto();
            }
            
        }
        public static void ShowData()
        {
            string str = $"\tAccountld\tFristname\tLastname\tGender\t\tBalance";
        
            foreach (Account pb in AcountList.Values)
            {
                //Console.WriteLine(pb.ShowInfo());
                  str += $"\n{pb.ShowInfo()}";          
            }
            Console.WriteLine(str);
        }

    }
  }


