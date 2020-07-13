using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LopCirclecylinder
{
    class Circle
    {
        public double radius = 2.3;
        private string color = "blue";
        //private double dientich;

        public Circle()
        {

        }
        public Circle(double r)
        {
            this.radius = r;
        }
        public Circle(double r, string c)
        {
            this.radius = r;
            this.color = c;
        }

        public double getBankinh()
        {
            return radius;
        }
        public void setBankinh(double r)
        {
            this.radius = r;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string c)
        {
            this.color = c;
        }
        //public double getDientich()
        //{
        //    return Math.PI * radius * radius;
        //}
        public override string ToString()
        {
            return " Bán kính là " + getBankinh() + " Màu sắc là " + getColor();
        }
    }
    class Cylinder : Circle
    {

        private double height = 23;

        public Cylinder()
        {

        }
        public Cylinder(double r, string c, double hei) : base(r, c)
        {
            this.height = hei;

        }
        public double setHeight()
        {

            return height;

        }
        public Cylinder(double hei)
        {
            this.height = hei;
        }
        public double Volume()
        {
            return Math.PI * height * radius;
        }
        public override string ToString()
        {
            return " Chiều cao là " + setHeight() + " Thể tích " + Volume() + base.ToString();
        }
    }
}
