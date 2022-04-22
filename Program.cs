using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassesExercise
{
    //public class Stopwatch
    //{
    //    private DateTime _startTime;
    //    private DateTime _endTime;

    //    public DateTime StartTime
    //    {
    //        get { return _startTime; }
    //        set
    //        {
    //            if (_startTime != null)
    //            {

    //            }
    //        }
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *  Exercise 1: Design a Stopwatch
                Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
                provide two methods: Start and Stop. We call the start method first, and the stop method next.
                Then we ask the stopwatch about the duration between start and stop. Duration should be a
                value in TimeSpan. Display the duration on the console.
                We should also be able to use a stopwatch multiple times. So we may start and stop it and then
                start and stop it again. Make sure the duration value each time is calculated properly.
                We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
                start time). So the class should throw an InvalidOperationException if its started twice. 

                Educational tip: The aim of this exercise is to make you understand that a class should be
                always in a valid state. We use encapsulation and information hiding to achieve that. The class
                should not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the
                outside, you should not be able to misuse a class because you shouldn’t be able to see the
                implementation detail
             */
            var timeStamp = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //Console.WriteLine("Minute: " + timeStamp.Minutes);
            //Console.WriteLine("Seconds: " + timeStamp.Seconds);
            var start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            Console.WriteLine("Minute: " + start.Minute);
            Console.WriteLine("Seconds: " + start.Second);
            //var minute = DateTime.Now.Minute.ToString();
            //Console.WriteLine(minute);
            //Console.WriteLine(start);
            var now = DateTime.Now;
            
            var rightNow = new DateTime();
            var min = rightNow.Minute;
            //Console.WriteLine(min);
            //Console.WriteLine(now.Minute + ":" + now.Second + ":" + now.Millisecond);
            //Console.WriteLine(timeStamp.Duration());
            //Console.WriteLine(timeStamp.Duration());

        }
    }
}
