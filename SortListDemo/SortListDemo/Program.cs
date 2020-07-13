using System;
using System.Collections;
namespace SortListDemo
{
    class Sort {

        SortedList ace = new SortedList();

        public void Show()
        {
            ace.Add(1, "A");
            ace.Add(4, "B");
            ace.Add(5, "C");
            ace.Add(7, "D");
            ace.Add(2, "E");
            ace.Add(6, "F");
            ace.Add(9, "G");
            ace.Add(10,"H");
            foreach (DictionaryEntry item in ace.Keys)
            {
                Console.WriteLine(ace[item]);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sort az = new Sort();
            az.Show();
        }
    }
}
