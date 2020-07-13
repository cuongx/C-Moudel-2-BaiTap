using System;
using System.Drawing;
using System.Text;
namespace Tv__Classs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập vào chiều rộng");
            double width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều dài");
            double height = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Chu vi HCN"  + rectangle.Chuvi());
           Console.WriteLine("Diện tích " + rectangle.Dientich());
            Console.WriteLine(rectangle.Display());

        }

    }

    public class Rectangle
    {
    
        double width, height;

        public Rectangle() { }
        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;

        }
        public double Dientich()
        {
            return height * width;
        }
        public double Chuvi()
        {
            return (height + width) * 2;
        }
        public String Display()
        {
            return "Rectangle {"+ "width" + width +",height"+ height+"}";

    }
    }
}
