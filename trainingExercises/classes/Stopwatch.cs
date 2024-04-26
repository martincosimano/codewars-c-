namespace Practice
{
    class Stopwatch
    {
        private DateTime? _startTime;
        private TimeSpan _duration;
        private bool _isRunning;

        public TimeSpan Duration => _duration;

        public void Start()
        {
            if (!_isRunning)
            {
                _startTime = DateTime.Now;
                _isRunning = true;
                Console.WriteLine("Start");
            }
            else
            {
                Console.WriteLine("Already running");
            }

        }
        public void Stop()
        {
            if (_isRunning)
            {
                _duration += DateTime.Now - _startTime.Value;
                _isRunning = false;
                Console.WriteLine("Stop");
            }
            else
            {
                Console.WriteLine("Not running");
            }

        }
    }
}