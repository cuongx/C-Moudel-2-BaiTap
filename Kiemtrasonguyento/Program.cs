using System;


namespace hinhchunhaApp1
{
    class Program
    {
        static void Main(string[] args)
        {                
            int number;
            Console.WriteLine("Nhập số");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2) 
            Console.WriteLine("Không phải số nguyên tố");
            else
            {
                bool check = true;
                for (int i = 2; i < Math.Sqrt(number); i++)
                {
                    if (number % i == 0) { check = false; break; }
                }
                    if (check) 
                    {
                        Console.WriteLine(number+"Là số nguyên tố");
                    }
                    else
                    {
                        Console.WriteLine(number + "Không phải số nguyên tố");
                    }
                }

            }
        }
    }

