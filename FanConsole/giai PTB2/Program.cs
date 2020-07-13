using System;
using System.Dynamic;
using System.Globalization;
using System.Text;
namespace Laptrinhdoituong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số a");
            double a = Inputnum();
            Console.WriteLine("Nhập số b");
            double b = Inputnum();
            Console.WriteLine("Nhập số c");
            double c = Inputnum();

            Console.Clear();
            QuadraticEquation kt = new QuadraticEquation(a, b, c);
            {
            
                Console.WriteLine($"dental la {kt.GetDiscriminant()}");

                if (kt.GetDiscriminant() > 0)
                {
                    Console.WriteLine($"Pt thứ nhất là {kt.Getroot1()} Pt thứ 2 là {kt.Getroot2()}");
                }
                else if (kt.GetDiscriminant() == 0)
                {

                    Console.WriteLine($" Pt 1 nghiem la LÀ {kt.Getroot3()}");
                }
                else
                {
                    Console.WriteLine("Phương Trình VN");
                }
            }

        }
        public static double Inputnum()
        {
            double num = 0;
            bool kiemtra;
            do
            {
                kiemtra = double.TryParse(Console.ReadLine(), out num);

            } while (kiemtra == false);
            return num;
        }
    }
    public class QuadraticEquation
    {

        //private double Geta { get => Geta; set => Geta = value; }
        //private double Getb { get => Getb; set => Getb = value; }
        //private double Getc { get => Getc; set => Getc = value; }


        private double Geta { get; set; }
        private double Getb { get; set; }
        private double Getc { get; set; }

        public QuadraticEquation(double a, double b, double c)
        {
            this.Geta = a;
            this.Getb = b;
            this.Getc = c;
        }

        public QuadraticEquation()
        {
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
        public double Getroot3()
        {
            return -this.Getb / 2 * this.Geta;
        }
    }
}
