using System;
using System.Collections;
using System.Collections.Generic;

namespace ListDemo
{
    class ListDe
    {
        public List<int> ints = new List<int>();
        public List<Employee> employee = new List<Employee>()
        {
          new Employee()
          {
              ID = 1,
              Name = "Cường" ,
              Email = "xuanc25@gmail.com"
          }
       };
        public List<Employee> emp;
        
        public ListDe()
        {
            emp = new List<Employee>()
            {
                new Employee()
                {
               ID = 1,
              Name = "tUÁN" ,
              Email = "xuanc45@gmail.com"
                }
            };
        }
        public void Show()
        {
            emp = new List<Employee>();
            emp.Add(new Employee());
            emp[0].Email = "b";
        }
        public override string ToString()
        {
            employee.Add(new Employee());
            employee[0].Email = "a";
            return "a";
        }
        public void Result()
        {
            Console.WriteLine(emp[0].Email);
            Console.WriteLine(employee[0].Email);

        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
