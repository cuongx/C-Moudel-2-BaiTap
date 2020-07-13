using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Schema;

namespace Baitap2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
          ReadFile();
            //  Classification();
        }

        public static string path = $@"D:\Moudel 2\ExceptDemo\Baitap2Demo\";

        public static PayLoad payload = new PayLoad()
        {
            students = new List<Students>()
        };
        public static void ReadFile()
        {
            using (StreamReader sr = File.OpenText($@"{path}data.json"))
            {
                var data = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<PayLoad>(data);
            }
        }

        
        public static Reguale reguale = new Reguale()
        {
            reuges = new List<Reuge>()
        };
        public static void Classification()
        {
            foreach (var pb in payload.students)
            {
                double Arvega = DTB(pb.MonHoc, out string xeploai);
                reguale.reuges.Add(new Reuge
                {
                    MaHS = pb.MaHS,
                    HoTen = pb.HoTen,
                    GioiTinh = pb.GioiTinh,
                    Lop = pb.Lop,
                    DTB = Arvega,
                    xeploai = xeploai
                });
            }
            reguale.reuges.Sort(new Customsort());
            using (StreamWriter sw = File.CreateText(@$"{path}OutCome.json"))
            {
                var dete = JsonConvert.SerializeObject(reguale);
                sw.WriteLine(dete);
            };
        }
        public static double DTB(Subjects subjects, out string Xeploai)
        {
            double Arvega = (subjects.Toan + subjects.Li + subjects.Hoa) / 3;
            Xeploai = "";
            if (Arvega >= 9)
            {
                Xeploai = "Xuất sắc";
            }
            else if (Arvega >= 8)
            {
                Xeploai = "Gioi";
            }
            else if (Arvega >= 7)
            {
                Xeploai = "Khá";
            }
            else if (Arvega >= 6.5)
            {
                Xeploai = "Trung Bình Khá";
            }
            else if (Arvega >= 5)
            {
                Xeploai = "Trung Bình";
            }
            else if (Arvega >= 3)
            {
                Xeploai = "Yếu";
            }
            else
            {
                Xeploai = "Kém";
            }
            return Arvega;
        }
    }
    class PayLoad
    {
        public List<Students> students { get; set; }
    }
    class Data
        {
            public List<Subjects> MonHoc { get; set; }
        }
         class Students
        {
            public int MaHS { get; set; }
            public string HoTen { get; set; }
            public string GioiTinh { get; set; }
            public int Lop { get; set; }

            public Subjects MonHoc = new Subjects();

        };

       class Reguale
        {
            public List<Reuge> reuges { get; set; }
        }

         class Reuge
        {

            public int MaHS { get; set; }
            public string HoTen { get; set; }
            public string GioiTinh { get; set; }
            public int Lop { get; set; }
            public double DTB { get; set; }
            public string xeploai { get; set; }

        }

         class Subjects
        {
            public double Toan { get; set; }
            public double Li { get; set; }
            public double Hoa { get; set; }

        }
    class Customsort : IComparer<Reuge>
    {
        public int Compare([AllowNull] Reuge x, [AllowNull] Reuge y)
        {
            return (int)x.DTB - (int)y.DTB;
        }
    }
}
