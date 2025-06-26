using System;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    internal class TimeRecorder : IDisposable
    {
        private System.Windows.Forms.Timer timer;
        public string CurrentDateTime { get; private set; }

        private Label boundTimeLabel;

        public TimeRecorder()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += OnTimedEvent;
            UpdateTime();
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            UpdateTime();
            UpdateBoundLabel();
        }

        private void UpdateTime()
        {
            DateTime now = DateTime.Now;
            CurrentDateTime = now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        public void BindClock(Label timeLabel)
        {
            boundTimeLabel = timeLabel;
            if (boundTimeLabel != null)
                boundTimeLabel.Text = CurrentDateTime;
        }

        private void UpdateBoundLabel()
        {
            if (boundTimeLabel != null)
                boundTimeLabel.Text = CurrentDateTime;
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