using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace BaitapAnhKhoa
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
            TinhXepLoai();
        }
       public static string path = $@"D:\Moudel 2\ExceptDemo\BaitapAnhKhoa\";

        public static PayLoad payload = new PayLoad()
        {
            students = new List<Students>()
        };
        public static void ReadFile()
        {         
            using (StreamReader sr = File.OpenText($@"{path}Data.json"))
            {
                var data = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<PayLoad>(data);
            }
        }
        public static ResDTB resDTB = new ResDTB()
        {
            resstudent = new List<ResStudent>()
        };
        public static void TinhXepLoai()
        {
            foreach (Students student in payload.students)
            {
                double average = DTB(student.SubjectList, out string XepLoai);
                resDTB.resstudent.Add(new ResStudent()
                {
                    MaHS = student.MaHS,
                    HoTen = student.HoTen,
                    GioiTinh = student.GioiTinh,
                    DTB = average,
                    XepLoai = XepLoai
                });
            }
            resDTB.resstudent.Sort(new Customsort());
            using (StreamWriter sw = File.CreateText($@"{path}OutCome.json"))
            {
                var data = JsonConvert.SerializeObject(resDTB);
                sw.WriteLine(data);
               

            }
        }
        public static double DTB(Subject subject, out string Xeploai)
        {
            double average = (subject.Toan + subject.Ly + subject.Hoa) / 3;
            Xeploai = "";
            if (average >= 9)
            {
                Xeploai = "Xuất sắc";
            }
            else if (average >= 8)
            {
                Xeploai = "Gioi";
            }
            else if (average >= 7)
            {
                Xeploai = "Khá";
            }
            else if (average >= 6.5)
            {
                Xeploai = "TBK";
            }
            else if (average >= 5)
            {
                Xeploai = "Trung Bình";
            }
            else if (average >= 3.5)
            {
                Xeploai = "Yếu";
            }
            else
            {
                Xeploai = "Kém";
            }
            return average;
        }


    }
    class PayLoad
    {
        public List<Students> students { get; set; }
    }
    class Students
    {
        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public Subject SubjectList = new Subject();
    }
    class Subject
    {
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
    }
    class ResDTB
    {
        public List<ResStudent> resstudent { get; set; }
    }
    class ResStudent
    {
        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public double DTB { get; set; }
        public string XepLoai { get; set; }
    }
    class Customsort : IComparer<ResStudent>
    {
        public int Compare([AllowNull] ResStudent x, [AllowNull] ResStudent y)
        {
            return (int)y.DTB - (int)x.DTB;
        }
    }

}
