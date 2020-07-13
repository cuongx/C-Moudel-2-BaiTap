using System;

namespace FanConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan kt = new Fan(1, true, 4, "blue");
            kt.ToSring();
            Fan skt = new Fan(2, false, 6, "red");
            skt.ToSring();



        }

    }
    public class Fan
    {
        const int SLOW = 1, MEDIUM = 2, FAST = 3;
        private int speed = 1;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public Fan(int s, bool on, double r, string c)
        {

            this.speed = s;
            this.on = on;
            this.radius = r;
            this.color = c;
        }
        public  void ToSring()
        {
            if (on)
            {
                Console.WriteLine($"Fan is on = Speed {speed} Color = {color} Radius = {radius}");
            }
            else {
                Console.WriteLine($"Fan is off = Speed {speed} Color = {color} Radius = {radius}");
            }

        }
        
    }
}