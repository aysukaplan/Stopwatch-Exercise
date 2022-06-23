using System;

namespace exercise1
{
    public class program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            //startTime and stopTime objects are TimeSpan type of objects
            var startTime = stopWatch.Start();
            var stopTime = stopWatch.Stop();
            //Duration displays the duration on the console.
            stopWatch.Duration(startTime, stopTime);
    
        }
    }
    public class StopWatch
    {
        public static int _num = 0;

        public TimeSpan Start()
        {
            if(_num != 0 )
                throw new InvalidOperationException("InvalidOperationException occured");

            var StartTime = DateTime.Now.TimeOfDay;   
            _num = 1;
            return StartTime;
        }

        public TimeSpan Stop()
        {
            var FinishTime = DateTime.Now.TimeOfDay;
            _num=0;
            return FinishTime;
        }
        
        public void Duration(TimeSpan start, TimeSpan stop)
        {
            var duration = stop-start;
            System.Console.WriteLine("Duration between start and stop is {0}" ,duration);
        }
    }
}
