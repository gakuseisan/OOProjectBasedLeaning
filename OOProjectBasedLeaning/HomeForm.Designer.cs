namespace OOProjectBasedLeaning
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxEmployees = new ListView();
            button_atWork = new Button();
            _leaveWork = new Button();
            labelClock = new Label();
            label_User = new Label();
            _Work = new Label();
            label_AbsTime = new Label();
            button_rest = new Button();
            label_NowUser = new Label();
            label_NowWork = new Label();
            _NowTime = new Label();
            RestTime = new Label();
            label_NowRest = new Label();
            label_leaveTime = new Label();
            label_leaveWorkDisplay = new Label();
            kTime = new Label();
            _atWorkDisplay = new Label();
            label_ChooseWork = new Label();
            _NowChooseWork = new Label();
            button_comit = new Button();
            listview_Log = new ListView();
            changejump = new Button();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Location = new Point(12, 12);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(411, 426);
            listBoxEmployees.TabIndex = 0;
            listBoxEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // button_atWork
            // 
            button_atWork.Location = new Point(440, 264);
            button_atWork.Name = "button_atWork";
            button_atWork.Size = new Size(60, 34);
            button_atWork.TabIndex = 1;
            button_atWork.Text = "出勤";
            button_atWork.UseVisualStyleBackColor = true;
            // 
            // _leaveWork
            // 
            _leaveWork.Location = new Point(506, 264);
            _leaveWork.Name = "_leaveWork";
            _leaveWork.Size = new Size(60, 34);
            _leaveWork.TabIndex = 2;
            _leaveWork.Text = "退勤";
            _leaveWork.UseVisualStyleBackColor = true;
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Location = new Point(454, 34);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(102, 25);
            labelClock.TabIndex = 3;
            labelClock.Text = "＊時刻表示";
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(454, 71);
            label_User.Name = "label_User";
            label_User.Size = new Size(207, 25);
            label_User.TabIndex = 4;
            label_User.Text = "現在選択中のユーザー名：";
            // 
            // _Work
            // 
            _Work.AutoSize = true;
            _Work.Location = new Point(454, 96);
            _Work.Name = "_Work";
            _Work.Size = new Size(102, 25);
            _Work.TabIndex = 5;
            _Work.Text = "勤務状態：";
            // 
            // label_AbsTime
            // 
            label_AbsTime.AutoSize = true;
            label_AbsTime.Location = new Point(454, 222);
            label_AbsTime.Name = "label_AbsTime";
            label_AbsTime.Size = new Size(102, 25);
            label_AbsTime.TabIndex = 6;
            label_AbsTime.Text = "確定時刻：";
            // 
            // button_rest
            // 
            button_rest.Location = new Point(572, 264);
            button_rest.Name = "button_rest";
            button_rest.Size = new Size(112, 34);
            button_rest.TabIndex = 7;
            button_rest.Text = "休憩切替";
            button_rest.UseVisualStyleBackColor = true;
            // 
            // label_NowUser
            // 
            label_NowUser.AutoSize = true;
            label_NowUser.Location = new Point(667, 71);
            label_NowUser.Name = "label_NowUser";
            label_NowUser.Size = new Size(102, 25);
            label_NowUser.TabIndex = 8;
            label_NowUser.Text = "＊ユーザー名";
            // 
            // label_NowWork
            // 
            label_NowWork.AutoSize = true;
            label_NowWork.Location = new Point(667, 96);
            label_NowWork.Name = "label_NowWork";
            label_NowWork.Size = new Size(102, 25);
            label_NowWork.TabIndex = 8;
            label_NowWork.Text = "＊勤務状態";
            // 
            // _NowTime
            // 
            _NowTime.AutoSize = true;
            _NowTime.Location = new Point(667, 222);
            _NowTime.Name = "_NowTime";
            _NowTime.Size = new Size(102, 25);
            _NowTime.TabIndex = 8;
            _NowTime.Text = "＊確定時刻";
            // 
            // RestTime
            // 
            RestTime.AutoSize = true;
            RestTime.Location = new Point(454, 197);
            RestTime.Name = "RestTime";
            RestTime.Size = new Size(138, 25);
            RestTime.TabIndex = 6;
            RestTime.Text = "合計休憩時間：";
            // 
            // label_NowRest
            // 
            label_NowRest.AutoSize = true;
            label_NowRest.Location = new Point(667, 197);
            label_NowRest.Name = "label_NowRest";
            label_NowRest.Size = new Size(138, 25);
            label_NowRest.TabIndex = 8;
            label_NowRest.Text = "＊合計休憩時間";
            // 
            // label_leaveTime
            // 
            label_leaveTime.AutoSize = true;
            label_leaveTime.Location = new Point(454, 172);
            label_leaveTime.Name = "label_leaveTime";
            label_leaveTime.Size = new Size(102, 25);
            label_leaveTime.TabIndex = 6;
            label_leaveTime.Text = "退勤時刻：";
            // 
            // label_leaveWorkDisplay
            // 
            label_leaveWorkDisplay.AutoSize = true;
            label_leaveWorkDisplay.Location = new Point(667, 172);
            label_leaveWorkDisplay.Name = "label_leaveWorkDisplay";
            label_leaveWorkDisplay.Size = new Size(102, 25);
            label_leaveWorkDisplay.TabIndex = 8;
            label_leaveWorkDisplay.Text = "＊退勤時刻";
            // 
            // kTime
            // 
            kTime.AutoSize = true;
            kTime.Location = new Point(454, 147);
            kTime.Name = "kTime";
            kTime.Size = new Size(102, 25);
            kTime.TabIndex = 6;
            kTime.Text = "出勤時刻：";
            // 
            // _atWorkDisplay
            // 
            _atWorkDisplay.AutoSize = true;
            _atWorkDisplay.Location = new Point(667, 147);
            _atWorkDisplay.Name = "_atWorkDisplay";
            _atWorkDisplay.Size = new Size(102, 25);
            _atWorkDisplay.TabIndex = 8;
            _atWorkDisplay.Text = "＊出勤時刻";
            // 
            // label_ChooseWork
            // 
            label_ChooseWork.AutoSize = true;
            label_ChooseWork.Location = new Point(454, 121);
            label_ChooseWork.Name = "label_ChooseWork";
            label_ChooseWork.Size = new Size(102, 25);
            label_ChooseWork.TabIndex = 5;
            label_ChooseWork.Text = "勤務状態：";
            // 
            // _NowChooseWork
            // 
            _NowChooseWork.AutoSize = true;
            _NowChooseWork.Location = new Point(667, 121);
            _NowChooseWork.Name = "_NowChooseWork";
            _NowChooseWork.Size = new Size(102, 25);
            _NowChooseWork.TabIndex = 8;
            _NowChooseWork.Text = "＊勤務状態";
            // 
            // button_comit
            // 
            button_comit.Location = new Point(690, 264);
            button_comit.Name = "button_comit";
            button_comit.Size = new Size(60, 34);
            button_comit.TabIndex = 2;
            button_comit.Text = "確定";
            button_comit.UseVisualStyleBackColor = true;
            // 
            // listview_Log
            // 
            listview_Log.Location = new Point(440, 321);
            listview_Log.Name = "listview_Log";
            listview_Log.Size = new Size(348, 117);
            listview_Log.TabIndex = 9;
            listview_Log.UseCompatibleStateImageBehavior = false;
            // 
            // changejump
            // 
            changejump.Location = new Point(756, 264);
            changejump.Name = "changejump";
            changejump.Size = new Size(112, 34);
            changejump.TabIndex = 10;
            changejump.Text = "お名前変更";
            changejump.UseVisualStyleBackColor = true;
            changejump.Click += changejump_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(changejump);
            Controls.Add(listview_Log);
            Controls.Add(_atWorkDisplay);
            Controls.Add(label_leaveWorkDisplay);
            Controls.Add(label_NowRest);
            Controls.Add(_NowTime);
            Controls.Add(kTime);
            Controls.Add(_NowChooseWork);
            Controls.Add(label_NowWork);
            Controls.Add(label_leaveTime);
            Controls.Add(label_NowUser);
            Controls.Add(RestTime);
            Controls.Add(button_rest);
            Controls.Add(label_ChooseWork);
            Controls.Add(label_AbsTime);
            Controls.Add(_Work);
            Controls.Add(label_User);
            Controls.Add(labelClock);
            Controls.Add(button_comit);
            Controls.Add(_leaveWork);
            Controls.Add(button_atWork);
            Controls.Add(listBoxEmployees);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listBoxEmployees;
        private Button button_atWork;
        private Button _leaveWork;
        private Label labelClock;
        private Label label_User;
        private Label _Work;
        private Label label_AbsTime;
        private Button button_rest;
        private Label label_NowUser;
        private Label label_NowWork;
        private Label _NowTime;
        private Label RestTime;
        private Label label_NowRest;
        private Label label_leaveTime;
        private Label label_leaveWorkDisplay;
        private Label kTime;
        private Label _atWorkDisplay;
        private Label label_ChooseWork;
        private Label _NowChooseWork;
        private Button button_comit;
        private ListView listview_Log;
        private Button changejump;
    }
}
