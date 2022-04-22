using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassesExercise
{
    public class Stopwatch
    {
        private Nullable<DateTime> _startTime;
        private DateTime _stopTime;
        private TimeSpan _duration;

        public void StartTime()
        {
            if (_stopTime > DateTime.MinValue)
            {
                _startTime = null;
                _startTime = DateTime.Now;
            }
            else if (_startTime == DateTime.MinValue)
            {
                _startTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("stopwatch started already");
            }
            
        }

        public void StopTime()
        {
            //if (_stopTime > DateTime.MinValue)
            //{
            //    _stopTime = DateTime.Now;
            //} 
            //else
            //{
                _stopTime = DateTime.Now;
            //}
        }

        public TimeSpan Duration
        {
            get
            {
                _duration = _stopTime.Subtract((DateTime)_startTime);
                return _duration;
            }
        }
    }
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
            var time = new Stopwatch();
            time.StartTime();
            time.StopTime();
            Console.WriteLine("First time: " + time.Duration);
            time.StartTime();
            time.StopTime();
            Console.WriteLine("Second time: " + time.Duration);



        }
    }
}
