using System;
namespace Ptb2Deomo
{
    class Program
    {
        static void Main(string[] args)

        //        {
        //            Console.InputEncoding = Encoding.UTF8;
        //            Console.OutputEncoding = Encoding.UTF8;
        //            Console.WriteLine("Nhập số a");
        //            double a = Inputnum();
        //            Console.WriteLine("Nhập số b");
        //            double b = Inputnum();
        //            Console.WriteLine("Nhập số c");
        //            double c = Inputnum();

        //            QuadraticEquation kt = new QuadraticEquation(a, b, c);
        //            {
        //                if (kt.GetDiscriminant() >= 0)
        //                {
        //                    Console.WriteLine($"PT có nghiệm là {kt.Getroot1()} Và nghiệm thứ 2 là {kt.Getroot2()}");
        //                }
        //                else
        //                {
        //                    Console.WriteLine($"PT vô nghiệm ");
        //                }
        //            }
        //        }
        //        public static double Inputnum()
        //        {
        //            double num = 0;
        //            bool kiemtra;
        //            do
        //            {
        //                kiemtra = double.TryParse(Console.ReadLine(), out num);
        //            } while (kiemtra == false);
        //            return num;
        //        }

        //    }

        //    public class QuadraticEquation
        //    {

        //        private double Geta { get; set; }
        //        private double Getb { get; set; }
        //        private double Getc { get; set; }


        //        public QuadraticEquation(double a, double b, double c)
        //        {

        //            this.Geta = a;
        //            this.Getb = b;
        //            this.Getc = c;
        //        }
        //        public double GetDiscriminant()
        //        {

        //            return this.Getb * this.Getb - 4 * this.Geta * this.Getc;
        //        }
        //        public double Getroot1()
        //        {
        //            return (-this.Getb + -Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        //        }
        //        public double Getroot2()
        //        {
        //            return (-this.Getb - -Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        //        }

        //    }


        //}
        {
            Console.WriteLine("Enter number a:");
            double a = inputNum();
            Console.WriteLine("Enter number b:");
            double b = inputNum();
            Console.WriteLine("Enter number c:");
            double c = inputNum();
            QuadraticEquation quadraticEquation = new QuadraticEquation(a, b, c);
            Console.Clear();
            Console.WriteLine($"Phương trình là  :  {quadraticEquation.Geta1}X^2 + {quadraticEquation.Getb1}X + {quadraticEquation.Getc1} = 0");
            Console.WriteLine("denta cua pt bac 2 vua tao la: " + quadraticEquation.GetDiscriminant());
            if (quadraticEquation.GetDiscriminant() < 0)
            {
                Console.WriteLine("PT  vô ngiệm");
            }
            else
            {
                Console.WriteLine($"PT có nghiệm là X1= {quadraticEquation.GetRoot1()} và X2= {quadraticEquation.GetRoot2()} ");
            }
        }
        public static double inputNum()
        {
            double num = 0;
            bool result;
            do
            {
                result = double.TryParse(Console.ReadLine(), out num);
            } while (result == false);
            return num;
        }
    }
    public class QuadraticEquation
    {
        private double Geta;
        private double Getb;
        private double Getc;
        public double Geta1
        {
            get => Geta;
            set => Geta = value;
        }
        public double Getb1
        {
            get => Getb;
            set => Getb = value;
        }
        public double Getc1
        {
            get => Getc;
            set => Getc = value;
        }
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
        public double GetRoot1()
        {
            return (-this.Getb + Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        }
        public double GetRoot2()
        {
            return (-this.Getb - Math.Sqrt(GetDiscriminant())) / (2 * this.Geta);
        }
    }
}