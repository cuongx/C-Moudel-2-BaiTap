using System;

namespace DivideByZeroExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int a = 0;
            
            try
            {
                int result = n / a;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("helo");
            }
        }
    }
}
