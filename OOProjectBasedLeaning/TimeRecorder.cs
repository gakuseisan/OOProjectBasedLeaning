using OOProjectBasedLeaning;
using System;
using System.Text;
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
            timer.Interval = 1000; // 1秒
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

//前提宣言
//private TimeRecorder recorder;
//recorder.start();



//ラベルの書き換えコード実例
//labelActionTime.Text = $"{recorder.CurrentDate} {recorder.CurrentTime}";

/*時計の実装例
private TimeRecorder recorder;

private void Form1_Load(object sender, EventArgs e)
{
    recorder = new TimeRecorder();

    recorder.TimeUpdated += (time) =>
    {
        labelClock.Text = time;
    };

    recorder.DateUpdated += (date) =>
    {
        labelDate.Text = date;
    };

    recorder.Start();
}

private void Form1_FormClosing(object sender, FormClosingEventArgs e)
{
    recorder.Dispose();
}　*/