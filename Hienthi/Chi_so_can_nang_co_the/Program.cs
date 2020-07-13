using System;
using System.Reflection.Metadata;
using System.Text;

namespace Chi_so_can_nang_co_the
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

         
            double weight;
            double height;

            Console.WriteLine("Nhập vào cân nặng");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều cao");
            height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);
            
            

            if (bmi < 18)
            {
                Console.WriteLine("Thiếu cân");
            }
            else if (bmi < 25.0)
            {

                Console.WriteLine("Bình thường");
            }
            else if (bmi < 30.0)
            {
                
                Console.WriteLine("Thừa Cân");
            }
            else
            {

                Console.WriteLine("Béo Phì");
            }
            Console.ReadKey();
        }
    }
}
