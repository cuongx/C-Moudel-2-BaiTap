using System;
using System.Drawing;
using System.Text;

namespace Hệ_Các_Đối_Tượng_Hình_Học
{
    class Shape
    {
        private string color { get; set; }
        private bool filled { get; set; }
        public Shape()
        {

        }          

        public Shape(string c, bool fi)
        {
            this.color = c;
            this.filled = fi;
        }
         public string Color()
        {
            return color;
        }
        public  bool Filled()
        {
            return filled;
        }
        public override string ToString()
        {
            return "Một hình có màu " + Color() + " Và " + Filled() ;
        }
    }
        class Cricle : Shape
    {

        private double radius = 1.0;

       public Cricle() { }

        public Cricle(string c,bool fi,double r) : base(c,fi)
        {
            this.radius = r;
        }
        public double  GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetPerimeter()
        {
           return 2 * radius * Math.PI;
        }
        public double Setradius()
        {
            return radius;
        }
        public override string ToString()
        {
            return "Một vòng tròn có bán kính là " + Setradius() + "\n Chu vi của nó là " + GetPerimeter() + "\n Diện tích của nó " + GetArea() +"và\n"+ base.ToString();
        }
    }
      class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle() { }

        public Rectangle(double w, double l) 
        {
            this.width = w;
            this.length = l;
        }
        public Rectangle (double w, double l, string c, bool fi, double r) : base(c, fi)
        {
            this.width = w;
            this.length = l;
        }
        public double Width()
        {
            return width;
        }
        public double Length()
        {
            return length;
        }
        public double GetArea()
        {
            return this.width * this.length;
        }
        public double GetPerimeter()
        {
            return 2 * (this.width + this.length);
        }
        public override string ToString()
        {
            return "Rectangle " + " width " + width + " length " + length + " Và " +
            base.ToString();
        }
    }
       class Square : Rectangle
    {
        public Square() { }

        public Square(double side) : base(side , side)
        {

        }
        public Square(double side, string c, bool fi, double r):base(side,side, c, fi,r)
        {

        }
        public double getSide()
        {
            return Width();
        }
        public void Setside(double side)
        {
            Setwi(side);
            Setleg(side);
        }
        public void Setwi(double width)
        {
            Setside(width);
        }
        public void Setleg(double length)
        {
            Setside(length);
        }
        public override string ToString()
        {
            return "Một hình vuông có cạnh =  " + getSide() +  ", là một lớp con của" +  base.ToString();
        }
    }
        
        class Program
        {
            static void Main(string[] args)          
            {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

                Shape cd = new Shape("green",true);
                Console.WriteLine(cd.ToString());


              Cricle ce = new Cricle("red", false, 3.2);
                Console.WriteLine(ce);

            Rectangle ca = new Rectangle(5, 4, "white", true, 1.5);
                          Console.WriteLine(ca);

            Square cs = new Square( 4, "white ", true, 1.5);
            Console.WriteLine(cs);

        }
        }
    }
    
