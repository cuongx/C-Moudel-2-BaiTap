using System;
using System.Collections;
using System.Text;
namespace ArrrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //ArrayList al = new ArrayList();

            //Console.WriteLine("Adding some numbers:");
            //al.Add(45);
            //al.Add(78);
            //al.Add(33);
            //al.Add(56);
            //al.Add(12);
            //al.Add(23);
            //al.Add(9);

            //Console.WriteLine("Capacity: {0} ", al.Capacity);
            //Console.WriteLine("Count: {0}", al.Count);

            //Console.Write("Content: ");
            //foreach (int i in al)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();
            //Console.Write("Sorted Content: ");
            //al.Sort();
            //al.RemoveAt(1);
            //foreach (int i in al)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.Read();

            ArrayList alon = new ArrayList();
         
            alon.Add(2);
            alon.Add(5);
            alon.Add(8);
            alon.Add(4);
            alon.Add(3);
            alon.Add(9);
            alon.Add(10);
            alon.Add(6);

            Console.Write("Danh sách phần tử " + "\n");
            foreach (int i in alon)
            {
                Console.Write(i + " ");
            }

          
            Console.Read();

            Console.WriteLine("Count " + alon.Count);
            Console.WriteLine();
            Console.WriteLine("Capacity " + alon.Capacity);

            Console.WriteLine("Sắp xếp lại");
            alon.Sort();
            foreach (int a in alon)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Đảo ngược");
            alon.Reverse();
            foreach (int a in alon)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();


            Console.WriteLine();



            Console.WriteLine();

            Console.WriteLine("Xoa phần tử đầu tiên");
            alon.RemoveAt(0);
            foreach (int a in alon)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Xoa phần tử số 5");
            alon.Remove(5);
            foreach (int a in alon)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Vị tria cuối cùng");
            alon.LastIndexOf(alon);
            foreach (int a in alon)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Thêm số 5 vào vị trí 3");
            alon.Insert(3, 5);

            foreach (int a in alon)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();
        }
    }
}