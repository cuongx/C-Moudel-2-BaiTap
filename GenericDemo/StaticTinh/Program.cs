using System;

namespace StaticTinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Change();//calling change method
                             //creating objects
            Student s1 = new Student(111, "Hoang");
            Student s2 = new Student(222, "Khanh");
            Student s3 = new Student(333, "Nam");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
            Console.WriteLine($"{Student.Change()}");
         
             
        }
    }
        public class Student
        {
            private int rollno;
            private string name;
            private static string college = "BBDIT";

            //constructor to initialize the variable
            public Student(int r, string n)
            {
                rollno = r;
                name = n;
            }

            //static method to change the value of static variable

            public static string Change()
            {
               return college = "CODEGYM";
            }

            //method to display values
            public void Display()
            {
                Console.WriteLine(rollno + " " + name + " " + college);
            }
        }
    }

