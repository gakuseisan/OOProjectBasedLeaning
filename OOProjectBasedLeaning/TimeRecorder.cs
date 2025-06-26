using System;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    internal class TimeRecorder : IDisposable
    {
        private System.Windows.Forms.Timer timer;

        public string CurrentTime { get; private set; }
        public string CurrentDate { get; private set; }

        public event Action<string> TimeUpdated;
        public event Action<string> DateUpdated;

        public TimeRecorder()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1秒ごと
            timer.Tick += OnTimedEvent;

            UpdateTime();
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            DateTime now = DateTime.Now;

            CurrentTime = now.ToString("HH:mm:ss");
            CurrentDate = now.ToString("yyyy/MM/dd (ddd)");

            TimeUpdated?.Invoke(CurrentTime);
            DateUpdated?.Invoke(CurrentDate);
        }

        public void Start() => timer.Start();
        public void Stop() => timer.Stop();

        public void Dispose()
        {
            timer.Dispose();
        }
    }
}
