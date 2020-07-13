using System;

namespace Cricle
{
    class Cricle{

        private double radius;
        public string Color;
     public Cricle(double r)
        {
            this.radius = r;
        }         
           public Cricle()
        {
            this.Color = "";
        }
        public string GetColor()
        {
            return "red";
        }
        public double GetRadius()
        {
            return 1.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cricle cica = new Cricle();
            cica.GetColor();
            Console.WriteLine($"Cricle màu {cica.GetColor()} Bán Kính {cica.GetRadius()}");
            Cricle cici = new Cricle();
            Console.WriteLine($"Cricle màu {cica.GetColor()} Bán Kính {cica.GetRadius()}");

        }
    }
}
