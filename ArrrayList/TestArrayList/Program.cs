using System;
using System.Collections;
using System.Text;

namespace TestArrayList
{
    class ListDemo {

        ArrayList alo = new ArrayList();
       
      public ListDemo() { }

     public void TestDemo()
        {
            alo.Add(3);
            alo.Add(4);
            alo.Add(6);
            alo.Add(8);
            alo.Add("Hello");
            alo.Add(true);
            alo.Add(false);
            alo.Add(new List() { 
             name  = "Cường",
             age = 18
            });
            alo.Add(new List()
            {
                name = "Tuấn ",
                age = 18
            });

            alo.Add(new List()
            {
                name = "Tèo",
                age = 18
            });

            alo.Add(new List()
            {
                name = "Quang",
                age = 18
            });

            Console.WriteLine();
            Console.WriteLine("danh sách sẵn có");

            foreach(var item in alo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sắp xếp");

            alo.RemoveAt(8);
            foreach (var item in alo)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
   public class List{
   
       public string name { get; set; }
       public int age { get; set; }

        ArrayList alon = new ArrayList();
        public List() { }
        public override string ToString()
        {
            return " name  | " + name + " age " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            ListDemo ace = new ListDemo();
            ace.TestDemo();
            List ac = new List();
            
        }
    }
}
