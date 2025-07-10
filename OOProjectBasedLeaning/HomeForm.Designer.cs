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
            label_AbsTime = new Label();
            button_rest = new Button();
            label_NowUser = new Label();
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
            button_Delete = new Button();
            listBoxEmployees = new ListBox();
            labelPendingAction = new Label();
            namehenkou = new Button();
            SuspendLayout();
            // 
            // button_atWork
            // 
            button_atWork.Location = new Point(579, 435);
            button_atWork.Name = "button_atWork";
            button_atWork.Size = new Size(86, 50);
            button_atWork.TabIndex = 1;
            button_atWork.Text = "出勤";
            button_atWork.UseVisualStyleBackColor = true;
            button_atWork.Click += button_atWork_Click;
            // 
            // button_leaveWork
            // 
            button_leaveWork.Location = new Point(671, 436);
            button_leaveWork.Name = "button_leaveWork";
            button_leaveWork.Size = new Size(86, 50);
            button_leaveWork.TabIndex = 2;
            button_leaveWork.Text = "退勤";
            button_leaveWork.UseVisualStyleBackColor = true;
            button_leaveWork.Click += button_leaveWork_Click;
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Location = new Point(579, 19);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(102, 25);
            labelClock.TabIndex = 3;
            labelClock.Text = "＊時刻表示";
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(582, 60);
            label_User.Name = "label_User";
            label_User.Size = new Size(207, 25);
            label_User.TabIndex = 4;
            label_User.Text = "現在選択中のユーザー名：";
            // 
            // label_AbsTime
            // 
            label_AbsTime.AutoSize = true;
            label_AbsTime.Location = new Point(582, 297);
            label_AbsTime.Name = "label_AbsTime";
            label_AbsTime.Size = new Size(102, 25);
            label_AbsTime.TabIndex = 6;
            label_AbsTime.Text = "確定時刻：";
            // 
            // button_rest
            // 
            button_rest.Location = new Point(763, 435);
            button_rest.Name = "button_rest";
            button_rest.Size = new Size(111, 50);
            button_rest.TabIndex = 7;
            button_rest.Text = "休憩切替";
            button_rest.UseVisualStyleBackColor = true;
            button_rest.Click += button_rest_Click;
            // 
            // label_NowUser
            // 
            label_NowUser.AutoSize = true;
            label_NowUser.Location = new Point(824, 60);
            label_NowUser.Name = "label_NowUser";
            label_NowUser.Size = new Size(102, 25);
            label_NowUser.TabIndex = 8;
            label_NowUser.Text = "＊ユーザー名";
            // 
            // _NowTime
            // 
            _NowTime.AutoSize = true;
            _NowTime.Location = new Point(824, 297);
            _NowTime.Name = "_NowTime";
            _NowTime.Size = new Size(102, 25);
            _NowTime.TabIndex = 8;
            _NowTime.Text = "＊確定時刻";
            _NowTime.Click += _NowTime_Click;
            // 
            // RestTime
            // 
            RestTime.AutoSize = true;
            RestTime.Location = new Point(582, 248);
            RestTime.Name = "RestTime";
            RestTime.Size = new Size(138, 25);
            RestTime.TabIndex = 6;
            RestTime.Text = "合計休憩時間：";
            // 
            // label_NowRest
            // 
            label_NowRest.AutoSize = true;
            label_NowRest.Location = new Point(824, 248);
            label_NowRest.Name = "label_NowRest";
            label_NowRest.Size = new Size(138, 25);
            label_NowRest.TabIndex = 8;
            label_NowRest.Text = "＊合計休憩時間";
            // 
            // label_leaveTime
            // 
            label_leaveTime.AutoSize = true;
            label_leaveTime.Location = new Point(582, 203);
            label_leaveTime.Name = "label_leaveTime";
            label_leaveTime.Size = new Size(102, 25);
            label_leaveTime.TabIndex = 6;
            label_leaveTime.Text = "退勤時刻：";
            // 
            // label_leaveWorkDisplay
            // 
            label_leaveWorkDisplay.AutoSize = true;
            label_leaveWorkDisplay.Location = new Point(824, 203);
            label_leaveWorkDisplay.Name = "label_leaveWorkDisplay";
            label_leaveWorkDisplay.Size = new Size(102, 25);
            label_leaveWorkDisplay.TabIndex = 8;
            label_leaveWorkDisplay.Text = "＊退勤時刻";
            // 
            // kTime
            // 
            kTime.AutoSize = true;
            kTime.Location = new Point(581, 156);
            kTime.Name = "kTime";
            kTime.Size = new Size(102, 25);
            kTime.TabIndex = 6;
            kTime.Text = "出勤時刻：";
            // 
            // _atWorkDisplay
            // 
            _atWorkDisplay.AutoSize = true;
            _atWorkDisplay.Location = new Point(824, 156);
            _atWorkDisplay.Name = "_atWorkDisplay";
            _atWorkDisplay.Size = new Size(102, 25);
            _atWorkDisplay.TabIndex = 8;
            _atWorkDisplay.Text = "＊出勤時刻";
            // 
            // label_ChooseWork
            // 
            label_ChooseWork.AutoSize = true;
            label_ChooseWork.Location = new Point(582, 105);
            label_ChooseWork.Name = "label_ChooseWork";
            label_ChooseWork.Size = new Size(102, 25);
            label_ChooseWork.TabIndex = 5;
            label_ChooseWork.Text = "勤務状態：";
            label_ChooseWork.Click += label_ChooseWork_Click;
            // 
            // _NowChooseWork
            // 
            _NowChooseWork.AutoSize = true;
            _NowChooseWork.Location = new Point(824, 105);
            _NowChooseWork.Name = "_NowChooseWork";
            _NowChooseWork.Size = new Size(102, 25);
            _NowChooseWork.TabIndex = 8;
            _NowChooseWork.Text = "＊勤務状態";
            // 
            // button_comit
            // 
            button_comit.Location = new Point(880, 436);
            button_comit.Name = "button_comit";
            button_comit.Size = new Size(86, 50);
            button_comit.TabIndex = 2;
            button_comit.Text = "確定";
            button_comit.UseVisualStyleBackColor = true;
            button_comit.Click += button_comit_Click;
            // 
            // listview_Log
            // 
            listview_Log.Location = new Point(579, 492);
            listview_Log.Name = "listview_Log";
            listview_Log.Size = new Size(625, 189);
            listview_Log.TabIndex = 9;
            listview_Log.UseCompatibleStateImageBehavior = false;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(973, 436);
            button_Delete.Margin = new Padding(4, 5, 4, 5);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(86, 50);
            button_Delete.TabIndex = 10;
            button_Delete.Text = "削除";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 25;
            listBoxEmployees.Location = new Point(1, 2);
            listBoxEmployees.Margin = new Padding(4, 5, 4, 5);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(568, 679);
            listBoxEmployees.TabIndex = 11;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // labelPendingAction
            // 
            labelPendingAction.AutoSize = true;
            labelPendingAction.Location = new Point(582, 372);
            labelPendingAction.Margin = new Padding(4, 0, 4, 0);
            labelPendingAction.Name = "labelPendingAction";
            labelPendingAction.Size = new Size(135, 25);
            labelPendingAction.TabIndex = 10;
            labelPendingAction.Text = "＊選択中の状態";
            labelPendingAction.Click += labelPendingAction_Click;
            // 
            // namehenkou
            // 
            namehenkou.Location = new Point(1067, 436);
            namehenkou.Margin = new Padding(4, 5, 4, 5);
            namehenkou.Name = "namehenkou";
            namehenkou.Size = new Size(137, 50);
            namehenkou.TabIndex = 12;
            namehenkou.Text = "ユーザー名変更";
            namehenkou.UseVisualStyleBackColor = true;
            namehenkou.Click += namehenkou_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 678);
            Controls.Add(namehenkou);
            Controls.Add(button_Delete);
            Controls.Add(labelPendingAction);
            Controls.Add(listview_Log);
            Controls.Add(_atWorkDisplay);
            Controls.Add(label_leaveWorkDisplay);
            Controls.Add(label_NowRest);
            Controls.Add(_NowTime);
            Controls.Add(kTime);
            Controls.Add(_NowChooseWork);
            Controls.Add(label_leaveTime);
            Controls.Add(label_NowUser);
            Controls.Add(RestTime);
            Controls.Add(button_rest);
            Controls.Add(label_ChooseWork);
            Controls.Add(label_AbsTime);
            Controls.Add(label_User);
            Controls.Add(labelClock);
            Controls.Add(button_comit);
            Controls.Add(button_leaveWork);
            Controls.Add(button_atWork);
            Controls.Add(listBoxEmployees);
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
        private Label label_AbsTime;
        private Button button_rest;
        private Label label_NowUser;
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
        private Button button_Delete;
        private Label labelPendingAction;
        private ListBox listBoxEmployees;
        private Button namehenkou;
    }
}
