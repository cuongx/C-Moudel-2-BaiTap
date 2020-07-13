using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    public abstract class Fruit:Edible
    {
        public abstract string howtoEat();
        
    }
    public class Orange : Fruit
    {
        public override string howtoEat()
        {
            return "Fruit kk ";
        }
     
    }
    public class Apple : Fruit
    {
        public override string howtoEat()
        {
            return "APPPLE";
        }
    }
  class paraguay {
        static void Main(string[] args)
        {
            Fruit[] ifu = new Fruit[2];
            ifu[0] = new Orange();
            ifu[1] = new Apple();

            foreach (Fruit ani in ifu) {
                Console.WriteLine(ani.howtoEat());
                    }
        }
    }

}

