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
            button_atWork = new Button();
            button_leaveWork = new Button();
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
            button_Delete = new Button();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Location = new Point(8, 7);
            listBoxEmployees.Margin = new Padding(2, 2, 2, 2);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(289, 300);
            listBoxEmployees.TabIndex = 0;
            listBoxEmployees.UseCompatibleStateImageBehavior = false;
            button_atWork.Location = new Point(308, 158);
            button_atWork.Margin = new Padding(2, 2, 2, 2);
            labelPendingAction = new Label();
            listBoxEmployees = new ListBox();
            labelPendingAction = new Label();
            SuspendLayout();
            // 
            // button_atWork
            //
            button_atWork.Location = new Point(308, 158);
            button_atWork.Margin = new Padding(2);
            button_atWork.Name = "button_atWork";
            button_atWork.Size = new Size(42, 30);
            button_atWork.TabIndex = 1;
            button_atWork.Text = "出勤";
            button_atWork.UseVisualStyleBackColor = true;
            button_atWork.Click += button_atWork_Click;
            // 
            // button_leaveWork
            // 
            button_leaveWork.Location = new Point(360, 158);
            button_leaveWork.Margin = new Padding(2);
            button_leaveWork.Name = "button_leaveWork";
            button_leaveWork.Size = new Size(42, 30);
            button_leaveWork.TabIndex = 2;
            button_leaveWork.Text = "退勤";
            button_leaveWork.UseVisualStyleBackColor = true;
            button_leaveWork.Click += button_leaveWork_Click;
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Location = new Point(300, 10);
            labelClock.Margin = new Padding(2, 0, 2, 0);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(67, 15);
            labelClock.TabIndex = 3;
            labelClock.Text = "＊時刻表示";
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(300, 27);
            label_User.Margin = new Padding(2, 0, 2, 0);
            label_User.Name = "label_User";
            label_User.Size = new Size(137, 15);
            label_User.TabIndex = 4;
            label_User.Text = "現在選択中のユーザー名：";
            // 
            // _Work
            // 
            _Work.AutoSize = true;
            _Work.Location = new Point(300, 45);
            _Work.Margin = new Padding(2, 0, 2, 0);
            _Work.Name = "_Work";
            _Work.Size = new Size(67, 15);
            _Work.TabIndex = 5;
            _Work.Text = "勤務状態：";
            // 
            // label_AbsTime
            // 
            label_AbsTime.AutoSize = true;
            label_AbsTime.Location = new Point(300, 140);
            label_AbsTime.Margin = new Padding(2, 0, 2, 0);
            label_AbsTime.Name = "label_AbsTime";
            label_AbsTime.Size = new Size(67, 15);
            label_AbsTime.TabIndex = 6;
            label_AbsTime.Text = "確定時刻：";
            // 
            // button_rest
            // 
            button_rest.Location = new Point(410, 158);
            button_rest.Margin = new Padding(2, 2, 2, 2);
            button_rest.Name = "button_rest";
            button_rest.Size = new Size(78, 30);
            button_rest.TabIndex = 7;
            button_rest.Text = "休憩切替";
            button_rest.UseVisualStyleBackColor = true;
            button_rest.Click += button_rest_Click;
            // 
            // label_NowUser
            // 
            label_NowUser.AutoSize = true;
            label_NowUser.Location = new Point(440, 27);
            label_NowUser.Margin = new Padding(2, 0, 2, 0);
            label_NowUser.Name = "label_NowUser";
            label_NowUser.Size = new Size(67, 15);
            label_NowUser.TabIndex = 8;
            label_NowUser.Text = "＊ユーザー名";
            // 
            // label_NowWork
            // 
            label_NowWork.AutoSize = true;
            label_NowWork.Location = new Point(440, 45);
            label_NowWork.Margin = new Padding(2, 0, 2, 0);
            label_NowWork.Name = "label_NowWork";
            label_NowWork.Size = new Size(67, 15);
            label_NowWork.TabIndex = 8;
            label_NowWork.Text = "＊勤務状態";
            // 
            // _NowTime
            // 
            _NowTime.AutoSize = true;
            _NowTime.Location = new Point(440, 140);
            _NowTime.Margin = new Padding(2, 0, 2, 0);
            _NowTime.Name = "_NowTime";
            _NowTime.Size = new Size(67, 15);
            _NowTime.TabIndex = 8;
            _NowTime.Text = "＊確定時刻";
            _NowTime.Click += _NowTime_Click;
            // 
            // RestTime
            // 
            RestTime.AutoSize = true;
            RestTime.Location = new Point(300, 120);
            RestTime.Margin = new Padding(2, 0, 2, 0);
            RestTime.Name = "RestTime";
            RestTime.Size = new Size(91, 15);
            RestTime.TabIndex = 6;
            RestTime.Text = "合計休憩時間：";
            // 
            // label_NowRest
            // 
            label_NowRest.AutoSize = true;
            label_NowRest.Location = new Point(440, 120);
            label_NowRest.Margin = new Padding(2, 0, 2, 0);
            label_NowRest.Name = "label_NowRest";
            label_NowRest.Size = new Size(91, 15);
            label_NowRest.TabIndex = 8;
            label_NowRest.Text = "＊合計休憩時間";
            // 
            // label_leaveTime
            // 
            label_leaveTime.AutoSize = true;
            label_leaveTime.Location = new Point(300, 100);
            label_leaveTime.Margin = new Padding(2, 0, 2, 0);
            label_leaveTime.Name = "label_leaveTime";
            label_leaveTime.Size = new Size(67, 15);
            label_leaveTime.TabIndex = 6;
            label_leaveTime.Text = "退勤時刻：";
            // 
            // label_leaveWorkDisplay
            // 
            label_leaveWorkDisplay.AutoSize = true;
            label_leaveWorkDisplay.Location = new Point(440, 100);
            label_leaveWorkDisplay.Margin = new Padding(2, 0, 2, 0);
            label_leaveWorkDisplay.Name = "label_leaveWorkDisplay";
            label_leaveWorkDisplay.Size = new Size(67, 15);
            label_leaveWorkDisplay.TabIndex = 8;
            label_leaveWorkDisplay.Text = "＊退勤時刻";
            // 
            // kTime
            // 
            kTime.AutoSize = true;
            kTime.Location = new Point(300, 80);
            kTime.Margin = new Padding(2, 0, 2, 0);
            kTime.Name = "kTime";
            kTime.Size = new Size(67, 15);
            kTime.TabIndex = 6;
            kTime.Text = "出勤時刻：";
            // 
            // _atWorkDisplay
            // 
            _atWorkDisplay.AutoSize = true;
            _atWorkDisplay.Location = new Point(440, 80);
            _atWorkDisplay.Margin = new Padding(2, 0, 2, 0);
            _atWorkDisplay.Name = "_atWorkDisplay";
            _atWorkDisplay.Size = new Size(67, 15);
            _atWorkDisplay.TabIndex = 8;
            _atWorkDisplay.Text = "＊出勤時刻";
            // 
            // label_ChooseWork
            // 
            label_ChooseWork.AutoSize = true;
            label_ChooseWork.Location = new Point(300, 63);
            label_ChooseWork.Margin = new Padding(2, 0, 2, 0);
            label_ChooseWork.Name = "label_ChooseWork";
            label_ChooseWork.Size = new Size(67, 15);
            label_ChooseWork.TabIndex = 5;
            label_ChooseWork.Text = "勤務状態：";
            // 
            // _NowChooseWork
            // 
            _NowChooseWork.AutoSize = true;
            _NowChooseWork.Location = new Point(440, 63);
            _NowChooseWork.Margin = new Padding(2, 0, 2, 0);
            _NowChooseWork.Name = "_NowChooseWork";
            _NowChooseWork.Size = new Size(67, 15);
            _NowChooseWork.TabIndex = 8;
            _NowChooseWork.Text = "＊勤務状態";
            // 
            // button_comit
            // 
            button_comit.Location = new Point(495, 158);
            button_comit.Margin = new Padding(2, 2, 2, 2);
            button_comit.Name = "button_comit";
            button_comit.Size = new Size(42, 30);
            button_comit.TabIndex = 2;
            button_comit.Text = "確定";
            button_comit.UseVisualStyleBackColor = true;
            button_comit.Click += button_comit_Click;
            // 
            // listview_Log
            // 
            listview_Log.Location = new Point(308, 193);
            listview_Log.Margin = new Padding(2, 2, 2, 2);
            listview_Log.Name = "listview_Log";
            listview_Log.Size = new Size(280, 115);
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
            // button_Delete
            // 
            button_Delete.Location = new Point(545, 158);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(42, 30);
            button_Delete.TabIndex = 10;
            button_Delete.Text = "削除";
            button_Delete.UseVisualStyleBackColor = true;
            //
            // labelPendingAction
            // 
            labelPendingAction.AutoSize = true;
            labelPendingAction.Location = new Point(454, 247);
            labelPendingAction.Name = "labelPendingAction";
            labelPendingAction.Size = new Size(135, 25);
            labelPendingAction.TabIndex = 10;
            labelPendingAction.Text = "＊選択中の状態";
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 25;
            listBoxEmployees.Location = new Point(25, 12);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(399, 404);
            listBoxEmployees.TabIndex = 11;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 450);
            Controls.Add(changejump);
            ClientSize = new Size(614, 311);
            Controls.Add(button_Delete);
            Controls.Add(listBoxEmployees);
            Controls.Add(labelPendingAction);
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
            Controls.Add(button_leaveWork);
            Controls.Add(button_atWork);
            Controls.Add(listBoxEmployees);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_atWork;
        private Button button_leaveWork;
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
        private Button button_Delete;
        private Label labelPendingAction;
        private ListBox listBoxEmployees;
    }
}
