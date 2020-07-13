using System;
using System.Collections.Generic;
using System.Text;

namespace Ptb2Deomo
{
    class kethua
    {
        protected double weight;
        protected double height;
        protected double leg;


        public void info()
        {
            Console.WriteLine($"Weight + {weight} Height {height}+ Leg {leg}");
        }
        public kethua() { }
        public kethua(double w, double h, double l)
        {
            this.weight = w;
            this.height = h;
            this.leg = l;
        }
    }
    class Dongvat : kethua
    {
        public Dongvat()
        {

            this.weight = 40;

        }

    }
}

