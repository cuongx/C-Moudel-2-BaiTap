using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ExepctCafeDeMo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @$"D:\Moudel 2\ExepctCafeDeMo\ExepctCafeDeMo\intput.json";
            PayLoad payLoad = new PayLoad()
            {
                Numbers = new List<number>()
            };
            using (StreamReader sb = File.OpenText(path))
            {
                var data = sb.ReadToEnd();
                payLoad = JsonConvert.DeserializeObject<PayLoad>(data);

                ResPay resPay = new ResPay()
                {
                    SumTotal = new List<total>()
                };
                foreach (number iteam in payLoad.Numbers)
                {
                    resPay.SumTotal.Add(new total
                    {
                        sum = (iteam.a + iteam.b + iteam.c)
                    });
                }
             
                using (StreamWriter sw = File.CreateText($@"{path}output.json"))
                {
                    data = JsonConvert.SerializeObject(resPay);
                    sw.WriteLine(data);
                }

                ResPay2 resPay2 = new ResPay2()
                {
                    NumbersX2 = new List<numberX2>()
                };


            using (StreamWriter sc = File.CreateText($@"{path}output2"))
                {
                    foreach(var pb in payLoad.Numbers)
                    {
                        resPay2.NumbersX2.Add(new numberX2
                        {
                            aX2 = pb.a * 2,
                            bX2 = pb.b * 2,
                            cX2 = pb.c * 2
                        });
                    }

                    var dete = JsonConvert.SerializeObject(resPay2);
                     sc.WriteLine(dete);
                }

            }
        }
    }
    class PayLoad
    {
        public List<number> Numbers { get; set; }
    }
    class ResPay
    {
        public List<total> SumTotal { get; set; }
    }
    class ResPay2
    {
        public List<numberX2> NumbersX2 { get; set; }
    }
    class number
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
    }
    class total
    {
        public int sum { get; set; }
    }
    class numberX2
    {
        public int aX2 { get; set; }
        public int bX2 { get; set; }
        public int cX2 { get; set; }
    }
}
    

