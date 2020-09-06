using System;

namespace ClassExercises
{
    public class StopWatch
    {
        public TimeSpan Duration { get; set; }
        private DateTime Started;
        private DateTime Stopped;
        private bool _on = false;

        public void Start()
        {
            if (!_on)
            {
                this._on = true;
                this.Started = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("stop watch already running!");
            }
        }

        public void Stop()
        {
            this._on = false;
            this.Stopped = DateTime.Now;
            this.Duration = Stopped - Started;
        }
    }
}
