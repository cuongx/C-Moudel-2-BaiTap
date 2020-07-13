using System;
using System.Collections;
namespace DemoArrayList
{
    class ArrayListDemo
    {
        public ArrayList al = new ArrayList();
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}";
            }
        }
        public void Test()
        {
            al.Add(1);
            al.Add('c');
            al.Add(6.7);
            al.Add(true);
           
            al.Add("C0220a");
            al.Add("C0220b");
            al.Add("C0220c");
            al.Add("C0220d");

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine($"Capacity: {al.Capacity}");

            //al.Remove('c');
            //al.RemoveAt(2);

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            al.Add(new Product()
            {
                Id = 1,
                Name = "IP6S"
            });
            al.Add(new Product()
            {
                Id = 1,
                Name = "IP6S"
            });
            al.Add(new Product()
            {
                Id = 4,
                Name = "IP7S"
            });
            al.Add(new Product()
            {
                Id = 2,
                Name = "IP8S"
            });
            al.Add(new Product()
            {
                Id = 3,
                Name = "IP9S"
            });
            al.Sort(new CustomSort());
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }


        public class CustomSort : IComparer
        {
            public int Compare(object x, object y)
            {
            Product p1 = x as Product;
            Product p2 = y as Product;

            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (p1.Id > p2.Id)
                {
                    return 1;
                }
                else if (p1.Id == p2.Id)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }


        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                ArrayListDemo ald = new ArrayListDemo();
                ald.Test();
            }
        }
    }

