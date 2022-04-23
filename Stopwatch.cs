using System;

namespace ClassesExercise
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _duration;

        public void StartTime()
        {
            if (_startTime == DateTime.MinValue)
            {
                _startTime = DateTime.Now;
            }
            else if (_stopTime > DateTime.MinValue)
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
}
