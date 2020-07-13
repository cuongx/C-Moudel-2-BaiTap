using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
namespace Baitap1DeMo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @$"D:\Moudel 2\ExceptDemo\Baitap1DeMo\input.json";


            PayLoad payload = new PayLoad()
            {
                courses = new List<Course>()
            };

            using (StreamReader sr = File.OpenText(path))
            {
                var data = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<PayLoad>(data);


            
               
                foreach (Course pb in payload.courses)
                {
                    Console.WriteLine($"{pb.van} {pb.su} {pb.dia}");                
                }
            }

            Repay repay = new Repay()
                {
                    Sumtotal = new List<total>()
                };


                foreach (Course pb in payload.courses)
                {
                    repay.Sumtotal.Add(new total { sum = pb.van + pb.su + pb.dia });                
                 }
         

            using (StreamWriter sw = File.CreateText($@"{path}output.json"))
                {
                    var pay = JsonConvert.SerializeObject(repay);
                    sw.WriteLine(pay);
                }


        
            
           
           
            using (StreamWriter swr = File.CreateText($@"{path}output2.json"))
            {
                Tichxx repay2 = new Tichxx()
                {
                    number = new List<Tichx>()
                };
                 foreach(Course pb in payload.courses)
                {
                    repay2.number.Add(new Tichx()
                    {

                        xvan = pb.van *2,
                        xsu = pb.su * 2,
                        xdia = pb.dia *2

                    });
                }
            var hala = JsonConvert.SerializeObject(repay2);
            swr.WriteLine(hala);
           }

            ResData resdata = new ResData()
            {
                tich = new List<Data>()
            };
            using (StreamWriter swr = File.CreateText($@"{path}output3.json"))
            {
               
                foreach (Course pb in payload.courses)
                {
                    resdata.tich.Add(new Data()
                    {
                        a = pb.van * 3,
                        b = pb.su * 3,
                        c = pb.dia * 3

                    });
                }
                var hala = JsonConvert.SerializeObject(resdata);
                swr.WriteLine(hala);
            }

        }

        }
    }
    class Tichxx{
        public List<Tichx> number { get; set; }
    }
        class Repay
        {
            public List<total> Sumtotal { get; set; }
        }
        class PayLoad
        {
            public List<Course> courses { get; set; }
        }
        class Course
        {       
            public int van { get; set; }
            public int su { get; set; }
            public int dia { get; set; }                  
        }
    class Tichx
    {
        public int xvan { get; set; }
        public int xsu { get; set; }
        public int xdia { get; set; }
    }
    class total
        {
            public int sum { get; set; }
        }
    class ResData
    {
        public List<Data> tich{ get; set; }

    }

    class Data
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
    }


    

