using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Class__OPP

{
    class Connguoi
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Class cn = new Class();
            //{
            //    cn.Thongtin();
            //    cn.Hienthi();
            //    Console.ReadLine();

            //}
            //People na = new People()
            // {
            //     na.Thongtin()
            //     na.Hienthi()
            // }
            Console.WriteLine("Nhập tên của bạn");
          String  Hoten = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhập giới tính của bạn");
           String  Gioitinh = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhập ngày sinh của bạn");
           DateTime Ngaysinh = Convert.ToDateTime(Console.ReadLine());

            People ina = new People(Hoten, Gioitinh, Ngaysinh);
            {
            Console.WriteLine("Ngày sinh của bạn là " + Hoten);
            Console.WriteLine("Gioi tính của bạn là " + Gioitinh);
            Console.WriteLine("Ngày sinh của bạn là " + Ngaysinh.ToShortDateString());

        }

    }
    }
        public class People{

            string Hoten, Gioitinh;
             DateTime Ngaysinh;

           public People() { }

            public People(String ten,String gt,DateTime ns) {
                this.Hoten = ten;
                this.Gioitinh = gt;
                this.Ngaysinh = ns;
            }

            public void Thongtin()
            {
                Console.WriteLine("Nhập tên của bạn");
                Hoten = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhập giới tính của bạn");
                Gioitinh = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Nhập ngày sinh của bạn");
                Ngaysinh = Convert.ToDateTime(Console.ReadLine());

            }

            public void Hienthi()
            {
                Console.WriteLine("Ngày sinh của bạn là" + Hoten);
                Console.WriteLine("Gioi tính của bạn là" + Gioitinh);
                Console.WriteLine("Ngày sinh của bạn là" + Ngaysinh);

            }
        }
 
    }


