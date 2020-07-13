using System;
using System.Threading;

namespace Lap_trinh_doi_tuong2
{
    class Program
    {
        static void Main(string[] args)
       {

            Stopwatch kt = new Stopwatch();
            DateTime start = DateTime.Now;
            kt.Start(start.Hour * 3600 + start.Minute * 60 + start.Second);
            Console.WriteLine($"Start Time {start.TimeOfDay}");
            Console.ReadKey();
            DateTime end = DateTime.Now;
            kt.End(end.Hour * 3600 + end.Minute * 60 + end.Second);
            Console.WriteLine($"End Time {end.TimeOfDay}");
       Console.WriteLine($"Time {kt.GetElapsedTime()}");
        }
    }

    class Stopwatch
    {

        private int startTime;
        private int endTime;

        public void Start(int s)
        {
            startTime = s;

        }
        public void End(int e)
        {
            endTime = e;
        }
        public int GetElapsedTime()
        {
            return endTime - startTime;
        }


    }
}

