using System;
using System.Collections.Generic;
using System.Text;

namespace FileDemo2
{
    class FileDemo3
    {
        static void Main(string[] args)
        {
            try
            {
                throw new NullReferenceException("C");
                Console.WriteLine("A");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("B");
            }
        }
    }
}