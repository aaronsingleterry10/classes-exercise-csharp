using System;

namespace ClassesExercise
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _duration;
        private bool _hasStarted = false;

        public void StartTime()
        {
            if (!_hasStarted)
            {
                _startTime = DateTime.Now;
                _hasStarted = true;
            }
            //else if (_stopTime > DateTime.MinValue)
            //{
            //    _startTime = DateTime.Now;
            //}
            else
            {
                throw new InvalidOperationException("stopwatch started already");
            }
            
        }

        public void StopTime()
        {
            if (_hasStarted)
            {
                _stopTime = DateTime.Now;
                _hasStarted = false;
            }
            else
            {
                throw new InvalidOperationException("stopwatch started already");
            }
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
