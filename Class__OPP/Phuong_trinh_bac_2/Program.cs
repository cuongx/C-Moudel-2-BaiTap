using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Phuong_trinh_bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
  
            
            Console.WriteLine("Enter number a:");
            double a = inputnum();
            Console.WriteLine("Enter number b:");
            double b = inputnum();
            Console.WriteLine("Enter number c:");
            double c = inputnum();
            QuadraticEquation pt2 = new QuadraticEquation(a, b, c);
            if (pt2.GetDiscriminant() >=0)
            {
                Console.WriteLine($"PT co nghiem: X1= {pt2.Getroot1()} va X2= {pt2.Getroot2()}");
            } else
            {
                Console.WriteLine($"PT vo nghiem");
            }
            
        }
        public static double inputnum()
        {
            double now = 0;
            bool kiemtra;
            do
            {
                kiemtra = double.TryParse(Console.ReadLine(), out now);
            } while (kiemtra == false);
            return now;
        }
    }
    public class QuadraticEquation
    {


        public double Geta { get; set; }
        public double Getb { get; set; }
        public double Getc { get; set; }

        //public double Geta1
        //{
        //    get => Geta;
        //    set => Geta = value;
        //}

        public QuadraticEquation(double a, double b, double c)
        {
            this.Geta = a;
            this.Getb = b;
            this.Getc = c;
        }

        public double GetDiscriminant()
        {
            return this.Getb * this.Getb - 4 * this.Geta * this.Getc;
        }
        public double Getroot1()
        {
            return (-this.Getb + Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        }
        public double Getroot2()
        {
            return (-this.Getb - Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        }
    }

}


    


