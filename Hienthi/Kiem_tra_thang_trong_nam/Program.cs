using System;
using System.Text;
namespace Kiem_tra_thang_trong_nam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int month;
            string daysInMonth;
            Console.WriteLine("Nhập số tháng");
            month = Convert.ToInt32(Console.ReadLine());
            //switch (month)
            //{
            //    case 2:
            //        Console.WriteLine("Có 28 Hoặc 29 Ngày");
            //        break;
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Tháng Có 31 ngày");
            //         break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Tháng có 30 ngày");
            //        break;
            //    default:
            //        Console.WriteLine("Số bạn  chọn không phải tháng");
            //        break;

            //}
            switch (month)
            {
                case 2:
                    daysInMonth = "28 or 29";
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = "30";
                    break;
                default:
                    daysInMonth = "";
                    break;
            }

            if (daysInMonth != "")
            {
                Console.WriteLine($" tháng {month} có số ngày là { daysInMonth}");

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            }
        }
    }
