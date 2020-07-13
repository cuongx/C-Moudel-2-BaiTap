using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TaoClassStudent
{
    class Nhap
    {
      

        public int Id1 { get => Id1;  set => Id1 = value; }
        public string name { get => name; set => name = value; }
        public string diachi { get => diachi; set => diachi = value; }
        public int age { get => age; set => age = value; }

     public Nhap() { }
        public Nhap(int id, string n, string dc, int a)
        {
            this.Id1 = id;
            this.name = n;
            this.diachi = dc;
            this.age = a;
        }
        public int Aidia(int Id1)
        {
            return this.Id1;
        }
        public string Name(string name)
        {
            return this.name;

        }
        public string Diachi(string diachi)
        {
            return this.diachi;
        }
        public int Age(int Age)
        {
            return this.age;
        }
        public override string ToString()
        {
            return "Id" + Id1 + "name" + name + "Địa chỉ" + diachi + "Age" + age;
        }
    }
    
}
