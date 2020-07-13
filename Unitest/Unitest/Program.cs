using System;

namespace Unitest
{
    public class Calculator {

        public int Add(int x, int y)
        {
            if (x / 2 + y / 2 >= int.MaxValue / 2)
            {
                throw new Exception("out of range exception");
            }

            if (x / 2 + y / 2 <= int.MinValue / 2)
            {
                throw new Exception("out of range exception");
            }

            return x + y;
        }

    }
}
    class Program
    {

        static void Main(string[] args)
        {
          
        
    }
   }

