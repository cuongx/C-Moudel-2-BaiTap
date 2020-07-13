using System;

namespace Tu_Khoa_Static
{
    class Program
    {
     public static void Min(string[] args)
        {
            Car car1 = new Car("Mazda 3", "Skyactiv 3");
            Console.WriteLine(Car.numberOfCars);
            Car car2 = new Car("Mazda 6", "Skyactiv 6");
            Console.WriteLine(Car.numberOfCars);
            Console.ReadLine();
        }
    }
    public class Car
        {

            private string name;
            private string engine;
            public static int numberOfCars;
            public Car(string name, string engine)
            {
                this.name = name;
                this.engine = engine;
                numberOfCars++;
            }
            // getters and setters
        }
      
        }
    
 
