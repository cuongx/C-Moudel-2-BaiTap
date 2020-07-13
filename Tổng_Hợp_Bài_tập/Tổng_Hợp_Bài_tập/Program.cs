using System;
using System.Text;
namespace Tổng_Hợp_Bài_tập
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Process();
        }

        public static void CreateMenu(out int selected)
        {
            do
            {
                Console.WriteLine() ;
                Console.WriteLine("Bài Tập Anh Khoa");
                Console.WriteLine("1. Mã Assci");
                Console.WriteLine("2. Tính Tổng Bậc 3");
                Console.WriteLine("3. Ưóc của số");
                Console.WriteLine("4. Tổng bình phương số lẻ");
                Console.WriteLine("5. Số nhỏ nhất số lớn nhất");
                Console.WriteLine("6. Tính giai thừa N ");
                Console.WriteLine("7. Tính ƯSCLN và BCLN  ");
                Console.WriteLine("8. Kiểm tra số nguyên tố ");
                Console.WriteLine("9. Nhập số thành chữ");
                Console.WriteLine("10. Exit");
                Console.Write("Please select an option (1-5): ");
                int.TryParse(Console.ReadLine(), out selected);
                if (selected < 1 || selected > 10)
                {
                    Console.Clear();
                }
            }
            while (selected < 1 || selected > 10);

        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                CreateMenu(out selected);
                switch (selected)
                {
                    case 1:
                        {
                            Console.Clear();                         
                            MaAsscii.Process();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Tongbac3.Process();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Uoccuaso.Process();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Tongbinhphuongsole.Process();
                            break;                        
                        }
                    case 5:
                        {
                            Console.Clear();
                            Solonnhatnhonhat.Process();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            giaithua.Process();
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Usclnbscnn.Process();
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Ktsnt.Process();                         
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Ktsnt.nhapso();
                            break;
                        }
                    case 10:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != 11);
        }
    }
}
