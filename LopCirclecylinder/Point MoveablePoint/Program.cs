using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Point_MoveablePoint
{
    class Point
    {
        private float x = 0.0f;
        private float y = 0.0f;
        
       public Point() { }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float Getx()
        {
            return x;
        }
        public void Setx(float x)
        {
            this.x = x;
        }
        public float Gety()
        {
            return y;
        }
        public void Sety(float y)
        {
            this.y = y;
        }
        public void Setxy(float x , float y)
        {
            
        }
        public float [] Getxy()
        {
            float[] ac = new float[2];
            ac[0] = x;
            ac[1] = y;
            return ac;
        }
        public override string ToString()
        {
            return " X = " + Getx() + ";  Y  = " + Gety();
        }
       
    }
    class MoveablePoint : Point
    {
        public float xSpeed = 0.0f;
        public float ySpeed = 0.0f;
        public MoveablePoint() { }
        public MoveablePoint(float x, float y, float xSpeed, float ySpeed) : base(x, y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public MoveablePoint(float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public float GetxSpeed()
        {
            return xSpeed;
        }
        public void SetxSpeed(float xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public float GetySpeed()
        {
            return ySpeed;
        }
        public void SetySpeed(float ySpeed)
        {
            this.ySpeed = ySpeed;
        }
        public float[] GetXY()
        {
            float[] ad = new float[4];
            ad[2] = xSpeed;
            ad[3] = ySpeed;
            return ad;
        }
        public override string ToString()
        {
            return "XSpeed " + xSpeed + " ySpeed " + ySpeed +"  x=" +Getx() + "   y=" + Gety() + base.ToString();
        }
        public void Move()
        {
            Setx(Getx() + GetxSpeed());
            Sety(Gety() + GetySpeed());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Point kq = new Point();
            Console.WriteLine(kq.ToString());
            MoveablePoint moveable = new MoveablePoint(1, 1);
            moveable.Move();
            Console.WriteLine(moveable.ToString());
        }
    }
}
