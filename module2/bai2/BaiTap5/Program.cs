using System;

namespace BaiTap5
{
    public class StopWatch
    {
        private long startTime;
        private long endTime;

        public StopWatch()
        {

        }

        public long StartTime { get => startTime; set => startTime = value; }
        public long EndTime { get => endTime; set => endTime = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
