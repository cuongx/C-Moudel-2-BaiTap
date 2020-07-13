using System;
using System.Threading;

namespace ThredingDemo
{
    public class Car
    {
        public static int DISTANCE = 100;
        public static int STEP = 2;
        // Khai báo Tên của xe đua
        private String name;

        public Car(String name)
        {
            this.name = name;
        }

        public void Run()
        {
            // Khởi tạo điểm start(hay km ban đầu)
            int runDistance = 0;
            // Khởi tạo time bắt đầu cuộc đua
            var startTime = System.DateTime.Now;

            // Kiểm tra chừng nào còn xe chưa kết thúc quãng đường đua thì xe vẫn tiếp tục chạy
            while (runDistance < DISTANCE)
            {
                try
                {
                    // Random Speed KM/H
                    int speed = (new Random()).Next(20);
                    // Calculate traveled distance
                    runDistance += speed;
                    // Build result graphic
                    String log = "|";
                    int percentTravel = (runDistance * 100) / DISTANCE;
                    for (int i = 0; i < DISTANCE; i += STEP)
                    {
                        if (percentTravel >= i + STEP)
                        {
                            log += "=";
                        }
                        else if (percentTravel >= i && percentTravel < i + STEP)
                        {
                            log += "o";
                        }
                        else
                        {
                            log += "-";
                        }
                    }
                    log += "|";
                    Console.WriteLine("Car" + this.name + ": " + log + " " + Math.Min(DISTANCE, runDistance) + "KM");
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine("Car" + this.name + " broken...");
                    break;
                }
            }
            var endTime = System.DateTime.Now;
            Console.WriteLine("Car" + this.name + " Finish in " + (endTime - startTime) + "s");
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            Car carA = new Car("A");
            Car carB = new Car("B");
            Car carC = new Car("C");

            Thread thread1 = new Thread(carA.Run);
            Thread thread2 = new Thread(carB.Run);
            Thread thread3 = new Thread(carC.Run);
            thread3.Priority = ThreadPriority.Highest;
            Console.WriteLine("Distance: 100KM");
            thread1.Start();
            thread2.Start();

            thread3.Start();

            Console.ReadLine();
        }
    }
}
