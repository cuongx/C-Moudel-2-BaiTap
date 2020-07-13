using System;
using System.Text;
namespace LopCirclecylinder
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Cylinder cd = new Cylinder();
            Console.WriteLine($"{cd.ToString()}");
            Cylinder ca = new Cylinder(4,"white",5);
            Console.WriteLine($"{ca.ToString()}");
        }
    }
}
