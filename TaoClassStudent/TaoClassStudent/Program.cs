using System;

namespace TaoClassStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Nhap enter = new Nhap(1,"Cường","Minh Hóa",18);
            Nhap inter = new Nhap();
            inter.Aidia(2);
            inter.Name("Thảo");
            inter.Diachi("Minh HÓA");
            inter.Age(18);
            
            
            Console.WriteLine(enter.ToString());
            Console.WriteLine(inter.ToString());
        }
    }
}
