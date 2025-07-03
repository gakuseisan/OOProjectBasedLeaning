using System;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    // 時刻表示を管理するクラス。フォーム上のラベルと連動可能。
    internal class TimeRecorder : IDisposable
    {
        // 一定間隔で処理を実行するためのタイマー
        private System.Windows.Forms.Timer timer;

        // 現在の日時を保持するプロパティ（読み取り専用）
        public string CurrentDateTime { get; private set; }

        // 更新対象となるラベルを保持（時計表示用）
        private Label boundTimeLabel;

        // コンストラクタ：タイマーを初期化し、1秒ごとにイベントを発生させる
        public TimeRecorder()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1秒ごとにイベント発火
            timer.Tick += OnTimedEvent; // Tickイベントにメソッドを登録
            UpdateTime(); // 最初に現在時刻を取得
        }

        // 1秒ごとに呼び出されるイベントハンドラ
        private void OnTimedEvent(object sender, EventArgs e)
        {
            UpdateTime(); // 現在時刻を更新
            UpdateBoundLabel(); // ラベルに表示を反映
        }

        // 現在の日時を文字列で更新（フォーマット指定付き）
        private void UpdateTime()
        {
            DateTime now = DateTime.Now;
            CurrentDateTime = now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        // ラベルをバインド（連動）させるためのメソッド
        public void BindClock(Label timeLabel)
        {
            boundTimeLabel = timeLabel;
            if (boundTimeLabel != null)
                boundTimeLabel.Text = CurrentDateTime; // 現在時刻を即時表示
        }

        // バインドされたラベルがあれば、そこに最新の時刻を表示
        private void UpdateBoundLabel()
        {
            if (boundTimeLabel != null)
                boundTimeLabel.Text = CurrentDateTime;
        }

        // タイマーの開始
        public void Start() => timer.Start();

        // タイマーの停止
        public void Stop() => timer.Stop();

        // タイマーのリソース解放（IDisposableの実装）
        public void Dispose()
        {
            timer.Dispose();
        }
    }
}

//--------------------------------------------------
// 以下は TimeRecorder の使い方例（コメントアウト形式）
//--------------------------------------------------

// 前提宣言（フォームクラスのフィールドに TimeRecorder を定義）
//private TimeRecorder recorder; 

// タイマー開始処理（たとえば Load イベント内など）
//recorder.Start(); 

// ラベルの書き換えコード実例（CurrentDate や CurrentTime プロパティがある前提）
//labelActionTime.Text = $"{recorder.CurrentDate} {recorder.CurrentTime}"; 
// ※上記は旧設計の例。現行の CurrentDateTime を使うなら以下のようにする：
//labelActionTime.Text = recorder.CurrentDateTime;

/* 時計の実装例（イベント駆動の拡張例）
private TimeRecorder recorder; 
 
private void Form1_Load(object sender, EventArgs e) 
{ 
    recorder = new TimeRecorder(); 
 
    // 時刻が更新されるたびに labelClock に反映（イベントが実装されている前提）
    recorder.TimeUpdated += (time) => 
    { 
        labelClock.Text = time; 
    }; 
 
    // 日付が更新されるたびに labelDate に反映（イベントが実装されている前提）
    recorder.DateUpdated += (date) => 
    { 
        labelDate.Text = date; 
    }; 
 
    recorder.Start(); // 時計を開始
} 
 
private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
{ 
    recorder.Dispose(); // リソース解放
} 
*/
