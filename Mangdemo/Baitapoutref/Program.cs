using System;
using System.Text;
namespace Baitapoutref
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.UTF8;
            //int a = 1;
            //int b = 2;
            //Console.WriteLine("Trước khi thay đổi");
            //Console.WriteLine("a = {0}, b = {1}", a, b);


            //swap(ref a, ref b);

            //Console.WriteLine("Sau khi thay đổi");
            //Console.WriteLine($"số là {a}   {b}");

            //int value = 5;
            //Console.WriteLine("Value before increase: {0}", value);

            //IncreaseValue(ref value);

            //Console.WriteLine("Value after increase: {0}", value);



            //Console.ReadKey();
            int value = 5;
            Console.WriteLine("Value before increase: {0}", value);
            IncreaseValue( value);
            Console.WriteLine("Value after increase: {0}", value);
            Console.ReadKey();
        }

        //public static void swap(ref int a, ref int b)
        //{

        //    int tmp;
        //    tmp = a;
        //    a = b;
        //    b = tmp;
        //}


        static void IncreaseValue( int value)

        {
            


            value ++;

        }

    }
}