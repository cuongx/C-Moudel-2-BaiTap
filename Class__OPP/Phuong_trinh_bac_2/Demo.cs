using System;
using System.Collections.Generic;
using System.Text;

namespace Phuong_trinh_bac_2
{
    class Demo
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            DateTime start = DateTime.Now;
            sw.Start(start.Hour * 3600 + start.Minute * 60 + start.Second);
            Console.WriteLine($"Start Time: {start.TimeOfDay}");
            Console.WriteLine("\nEnter enter to finish:");
            Console.ReadKey();
            DateTime end = DateTime.Now;
            Console.WriteLine($"\nEnd Time: {end.TimeOfDay}");
            sw.End(end.Hour * 3600 + end.Minute * 60 + end.Second);
            Console.WriteLine($"Change time : {sw.GetElapsedTime()} Second");
        }
    }

    class Stopwatch
    {
        private int startTime;
        private int endTime;

        public void Start(int x)
        {
            startTime = x;
        }
        public void End(int x)
        {
            endTime = x;
        }
        public int GetElapsedTime()
        {
            return endTime - startTime;
        }
    }
}
