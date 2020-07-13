using System;
using System.Collections.Generic;
using System.Text;

namespace Kethuaclass
{
    public class Animal
    {
        //public int weight { get => weight; set => weight = value; }
        //public int height { get => height; set => height = value; }

        public int weight { get; set; }
        public int height { get; set; }

        public Animal(int w, int h)
        {
            this.weight = w;
            this.height = h;

        }
        public virtual void Interfor() { }
    }
        class Heo : Animal
        {

        //public string name { get => name; set => name = value; }
        //public string Sub { get => Sub; set => Sub = value; }

        public string name { get; set; }
        public string Sub { get; set; }

        public Heo(string n, string s, int w, int h) : base(w, h)
            {
                this.name = n;
                this.Sub = s;
            }
            public override void Interfor()
            {
                Console.WriteLine("Name" + this.name + "Sở thich" + this.Sub + "Cân Nặng " + this.weight + " Chiều cao " + this.height);
            }
        }

    
    }

