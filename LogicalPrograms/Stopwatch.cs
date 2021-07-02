using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    class StopWatch
    {
        public static void Stopwatch()
        {
            StopwatchMeasure();
        }

        private static void StopwatchMeasure()
        {
            //creating instance for stopwatch class
            Stopwatch stopwatch = new Stopwatch();


            
            stopwatch.Start();//to start the stopwatch

            
            Thread.Sleep(500);//used to make the program sleep for 500ms=0.5sec

            
            stopwatch.Stop();//used to stop the stopwatch

            //timespan used to store time intervals
            TimeSpan timespan = stopwatch.Elapsed;

            //printing using string interpolation
            Console.WriteLine(timespan);
            Console.WriteLine($"Time Elapsed {timespan.Hours} hrs {timespan.Minutes} mins {timespan.Seconds} secs {timespan.Milliseconds} ms");

        }
    }
}
