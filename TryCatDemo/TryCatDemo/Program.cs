using System;

namespace TryCatDemo
{
    class Program
    {
        class Bela
        {
            int result;
            Bela()
            {
                result = 0;
            }
            public void phepChia(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Bat Exception: {0}", ex);
                }
                finally
                {
                    Console.WriteLine("Ket qua: {0}", result);
                }
            }


            static void Main(string[] args)
            {
                //try
                //{
                //    decimal price = 169.32m;
                //    Console.WriteLine("The cost is {0.2}.", price);
                //}
                //catch (System.FormatException ex)
                //{
                //    //System.Console.WriteLine(ex );
                //    Console.WriteLine("Hello",ex);
                //}
                Bela d = new Bela();
                d.phepChia(25, 5);
                Console.ReadKey();
            }
        }
    }
}

