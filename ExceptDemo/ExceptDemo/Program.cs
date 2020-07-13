using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ExceptDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //string path = @"D:\Moudel 2\ExceptDemo\ExceptDemo\matrix.json";
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    var data = sr.ReadToEnd();
            //    var payload = JsonConvert.DeserializeObject<Payload>(data);
            //    foreach(var item in payload.matrix)
            //    {
            //        for(int i = 0; i < item.Count; i++)
            //        {
            //            Console.Write($"{item[i] * 2} ");
            //        }
            //    }
            //}
            //Data payload = new Data()
            //{
            //students = new List<Student>()
            //};
            Data payload = new Data()
            {
                students = new List<Student>()
            };

             string path2 = @"D:\Moudel 2\ExceptDemo\ExceptDemo\student.json";
             using (StreamReader sr = File.OpenText(path2)){
             var data = sr.ReadToEnd();
             payload = JsonConvert.DeserializeObject<Data>(data);
            /* Console.WriteLine($"Id\tFullname\t\t\tGender\t\tDate of birth\t\tAge")*/;
                //Console.WriteLine(payload.students[1].Courses[1].name);
                foreach(var iteam in payload.students)
                {
                    Console.WriteLine(iteam.ToString());
                }
                
            }
        }

        //class Payload
        //{

        //    public List<List<int>> matrix { get; set; }
        //}
    
       
        class Data
        {
            public List<Student> students = new List<Student>();
        }
        class Student
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Gender { get; set; }
            public DateTime DOB { get; set; }
            public List<Course> Courses { get; set; }
            public double Average  => Calculator();
            public int Age => DateTime.Now.Year - DOB.Year;

            public double Calculator()
            {
                double total = 0.0;
                foreach (var iteam in Courses)
                {
                    total += iteam.score;
                    
                }
                return total = total / Courses.Count;
               
             
            }
            public override string ToString()
            {
               string str = $"{Id}\t{FullName}\t\t\t" +
                      $"{Gender}\t\t" +
                      $"{DOB.ToString("dd MMM yyyy")}\t\t" +
                      $"{Age}";
                str = $"{str}\n\tName\n\tScore";

                foreach(var course in Courses)
                {
                    str = $"{str}\n\t{course.ToString()}";
                }
                str = $"{str}\n\t\t Arverage {Average}";
                return str;
            }
          
        }
        class Course
        {
            public string name { get; set; }
            public double score { get; set; }

            public override string ToString()
            {
                return $"\t{name}\t {score}";
            }
        }

    }
}

    
