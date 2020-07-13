using Inter;
using System;

namespace Inter
{
    public abstract class Animal
    {
        public abstract string MakeSound();
      
    }
   public class Chicken : Animal
    {
        public override string MakeSound()
        {
            return "Helo mình Là Gà ";
        }
    }
    public  class Tiger : Animal
    {
        public override string MakeSound()
        {
            return ToString();
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal[] animals = new Animal[3];
    //        animals[0] = new Chicken();
    //        animals[1] = new Tiger();
    //        animals[2] = new Ga();

    //        foreach (Animal animal in animals)
    //        {
    //            Console.WriteLine(animal.howtoEat());
    //            Console.WriteLine(animal.MakeSound());

    //            if (animal is Ga)
    //            {
    //                Edible edibler = (Ga)animal;
    //                Console.WriteLine(edibler.howtoEat());

    //            }
    //        }
    //  }
    //}
}
