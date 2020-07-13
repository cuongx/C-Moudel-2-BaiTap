using System;
using System.Text;

namespace Hienthi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int ve;
            Console.WriteLine("Menu");
            Console.WriteLine("1 : Vẽ Hình Tam Giac");
            Console.WriteLine("2 : Vẽ Hình Vuông");
            Console.WriteLine("3 : Vẽ Hình Chữ Nhật");
            Console.WriteLine("4 : Vẽ Hình Trái Tim");
            Console.WriteLine("0 : Thoát ra");
            Console.WriteLine("Xin Mời Bạn Nhập");
            ve = Int16.Parse(Console.ReadLine());
     
                
                switch (ve)
                {
                   
                    case 1:
                        Console.WriteLine("******");
                        Console.WriteLine("*****");
                        Console.WriteLine("****");
                        Console.WriteLine("***");
                        Console.WriteLine("**");
                        Console.WriteLine("*");
                        break;
                    case 2:

                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:

                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("* * * * * *");
                        break;
                case 4:
                    Console.WriteLine     ("* * *    * * *");
                    Console.WriteLine   ("*       * *       *");
                    Console.WriteLine  ("*                   *");
                    Console.WriteLine  ("*                   *");
                    Console.WriteLine   ("*                 *");
                    Console.WriteLine    ("*               *");
                    Console.WriteLine     ("*             *");
                    Console.WriteLine      ("*           *");
                    Console.WriteLine        ("*       *");
                    Console.WriteLine          ("*    *");
                    Console.WriteLine           ("*");
                    break;
                case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Không Có Trong MẢNG");
                        break;
                }
            }
        }
    }

