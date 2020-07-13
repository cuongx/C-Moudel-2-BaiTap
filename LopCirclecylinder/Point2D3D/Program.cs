using System;
using System.Text;

namespace Point2D3D
{
    class Point3D
    {

        private float x = 0.2f;
        private float y = 0.2f;


        public Point3D()
        {

        }
        public Point3D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(float x)
        {

        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public float Getx()
        {
            return x;
        }
        public float Gety()
        {
            return y;
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            float[] v = new float[2];
            v[0] = x;
            v[1] = y;
            return v;
        }
        public override string ToString()
        {
            return " X = " + Getx() +  " Y = " + Gety() + "  "+ GetXY();
        }
    }
    class Point2D : Point3D
    {
        private float z = 0.02f;

        public Point2D() { }

        public Point2D(float x, float y, float z) : base(x, y)
        {
            this.z = z;

        }

        public float Getz()
        {
            return z;
        }
        public void Setz(float z)
        {
            this.z = z;
        }
        public void SetXYZ(float x, float y, float z)
        {

        }
        public float[] GetXYZ()
        {
            //float[] c = new float[3];
            //c[0] = x;
            //c[1] = y;
            //c[2] = z;
            //return c;
            float[] v = new float[3];         
            v[2] = z;
            return v;
        }
        public override string ToString()
        {
            return " Z  = " + z + " ; "+ base.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Point2D nc = new Point2D();
            Console.WriteLine(nc.ToString());
        }
    }
}
