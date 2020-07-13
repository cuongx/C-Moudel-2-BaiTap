using System;
using System.Collections;
namespace ClassListDemo
{
    class MyList<T>
    {
        private int Capacity { get; set; }
        private Object[] iteam;
       public MyList()
        {
            iteam = new Object[10];
        }

        private void EnsureCapacity()
        {
            int newSize = iteam.Length * 2;
            Array.Copy(iteam, iteam, newSize);
        }

        public void Add(T data)
        {
            if (Capacity == iteam.Length)
            {
                EnsureCapacity();
            }

            iteam[Capacity++] = data;
        }
        public T GetData(int idx)
        {
            if (idx >= Capacity || idx < 0)
            {
                throw new IndexOutOfRangeException("Index: " + idx + ", Capacity: " + Capacity);
            }

            return (T)iteam[idx];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> listInteger = new MyList<int>();
            listInteger.Add(10);
            listInteger.Add(15);
            listInteger.Add(20);
            listInteger.Add(30);
            listInteger.Add(50);
            Console.WriteLine("Item 1: " + listInteger.GetData(1));
            Console.WriteLine("Item 4: " + listInteger.GetData(3));
            Console.WriteLine("Item 2: " + listInteger.GetData(2));
            listInteger.GetData(6);
            Console.WriteLine("Item -1: " + listInteger.GetData(-1));
        }
    }
    }

