using System;

namespace FormatExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                decimal price = 2.25m;
                Console.WriteLine("The cost is {0:Q2}.", price);
			}
			catch (FormatException ex)
			{
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("hELLO");
            }
        }
    }
}
