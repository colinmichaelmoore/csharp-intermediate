using System;

namespace section2_exercise_1
{
    public class Stopwatch
    {
        public TimeSpan duration;
        private DateTime start;
        public DateTime stop;

        public void Start()
        {
            start = DateTime.Now;
            do
            {


            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Stop();
        }

        public void Stop()
        {
            stop = DateTime.Now;
            duration = stop - start;
            Console.WriteLine(duration);
            do
            {


            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Start();
        }
        
        
    }
}