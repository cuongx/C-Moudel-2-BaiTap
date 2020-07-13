using System;
using System.Text;
namespace Tu_Khoa_Static
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số a");
            double a = Inputnum();
            Console.WriteLine("Nhập số b");
            double b = Inputnum();
            Console.WriteLine("Nhập số c");
            double c = Inputnum();

            QuadraticEquation kt = new QuadraticEquation(a, b, c);
            {
                if (kt.GetDiscriminant()>=0){
                Console.WriteLine($"PT có nghiệm là {kt.Getroot1()} Và nghiệm thứ 2 là {kt.Getroot2()}");
            }
            else
            {
                Console.WriteLine($"PT vô nghiệm ");
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

        private double Geta { get; set; }
        private double Getb { get; set; }
        private double Getc { get; set; }


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
            return (-this.Getb + -Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        } 
        public double Getroot2()
        {
            return (-this.Getb - -Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        }
            
    }
  

}

