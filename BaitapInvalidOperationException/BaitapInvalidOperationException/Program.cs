using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BaitapInvalidOperationException
{
    class Person {
      public  List<Person> List = new List<Person>(); 
        public string name;
        public string age;

     public Person(string n,string a)
        {
            this.name = n;
            this.age = a;

        }
        public void Text()
        {
            List.Add(new List { 
            
                name = "Cuong",

            
            })
        }
    }

    internal class List : Person
    {
        public string name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person add = new Person();
            foreach(AddingNewEventArgs pb in )
          
          
        }
    }
}
