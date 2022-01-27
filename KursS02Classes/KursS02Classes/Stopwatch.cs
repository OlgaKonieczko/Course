using System;
using System.Collections.Generic;
using System.Text;


namespace KursS02Classes
{
    public class Stopwatch

    {
        private DateTime _startTime = new DateTime();
        private DateTime _endTime = new DateTime();
        private TimeSpan _timeResult = new TimeSpan();
        private bool _isStarted;

        public bool IsStarted { get => _isStarted; set => _isStarted = value; }
        

        public void Start()
        {
            if (IsStarted == false)
            {
                _startTime = DateTime.Now;
                IsStarted = true;
            }

            else
            {
                throw new InvalidOperationException("Zatrzymaj program");
            }
        }

        public TimeSpan Stop()
        {
            _endTime = DateTime.Now;
            _timeResult = (_endTime - _startTime);
            IsStarted = false;

            return _timeResult;
        }
    }
}
