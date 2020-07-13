using System;
using System.Text;
namespace Triangle
{
    class Triangle
    {
        private double side1 = 1.0;
        private double side2 = 1.0;
        private double side3 = 1.0;

        public Triangle() { }
        public Triangle(double side1,double side2,double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double Getside1 (double side1)
        {
            return side1;
        }
        public double Getside2(double side2)
        {
            return side2;
        }
        public double Getside3(double side3)
        {
            return side3;
        }
        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return p;
        }
        public double GetPerimeter()
        {
            return side1 + side2 + side3;
        }
        public override string ToString()
        {
            return "Cạnh 1=" + side1 + "  ; " + "Cạnh 2 =" + side2  + "  ;  " +  "Cạnh 3 =" + side3  + "  ;  " + "Chu vi hình tam giác " + " " + GetPerimeter() + " Diện tích hình tam giác " + GetArea();
        }
    }
    class Shape : Triangle
    {
        private string color = "red";

        public Shape() { }

        public Shape (string c, double side1, double side2, double side3):base(side1, side2, side3)
        {
            this.color = c;
        }
        public string Color()
        {
            return color;
        }
        public void Setcolor(string c)
        {
            this.color = c;
        }
        public override string ToString()
        {
            return "Color = " + Color() + " ; "  + base.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Triangle ax = new Triangle(3,4,5);
            Console.WriteLine(ax.ToString());
            Shape ac = new Shape("blue", 2, 2, 2);
            Console.WriteLine(ac.ToString());
        }
    }
}
