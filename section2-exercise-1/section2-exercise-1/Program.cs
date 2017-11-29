using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace section2_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var stopwatch = new Stopwatch();


            Console.WriteLine("Press ESC to start and stop stopwatch!");

            do
            {
               

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            stopwatch.Start();



        }
    }
}
