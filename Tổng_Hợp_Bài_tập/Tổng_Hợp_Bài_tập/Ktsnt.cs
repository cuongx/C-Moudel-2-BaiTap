using System;
using System.Collections.Generic;
using System.Text;

namespace Tổng_Hợp_Bài_tập
{
    class Ktsnt
    {
        static int n ;
        static bool songuyento(int n)
        {
           
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n <= 1) { return false; }
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        public static void nhap()
        {
          
            n = Int32.Parse(Console.ReadLine());
        }

       
        public static void Process()
        {
            Console.WriteLine("Nhập số nguyên tố");
            nhap();
            Console.WriteLine($"{n} là {songuyento(n)}");
           
        }

         
        public static void nhapso()          
        {
            
            Console.WriteLine("Nhập số thành chữ");
            nhap();
            while (n<0 || n > 9)
            {
                nhap();
            }
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Một");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Hai");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ba");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Bốn");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Năm");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Sáu");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Bảy");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Tám");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Chín");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Không có");
                        break;
                    }
                    
            }
            Console.WriteLine($"{n}  ");
        }
       
    }      
    
}

