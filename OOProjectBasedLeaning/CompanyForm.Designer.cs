namespace OOProjectBasedLeaning
{
    partial class CompanyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxEmployees = new ListView();
            listview_Log = new ListView();
            label_CountWorking = new Label();
            label_CountRest = new Label();
            _NowTime = new Label();
            label_NowChooseWork = new Label();
            label_NowWork = new Label();
            label_Rest = new Label();
            label_NowUser = new Label();
            button_rest = new Button();
            label_ChooseWork = new Label();
            label_AbsTime = new Label();
            label_Work = new Label();
            label_User = new Label();
            labelClock = new Label();
            button_comit = new Button();
            _leaveWork = new Button();
            button_atWork = new Button();
            label_cWork = new Label();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Location = new Point(12, 12);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(411, 426);
            listBoxEmployees.TabIndex = 1;
            listBoxEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // listview_Log
            // 
            listview_Log.Location = new Point(437, 299);
            listview_Log.Name = "listview_Log";
            listview_Log.Size = new Size(348, 117);
            listview_Log.TabIndex = 29;
            listview_Log.UseCompatibleStateImageBehavior = false;
            // 
            // label_CountWorking
            // 
            label_CountWorking.AutoSize = true;
            label_CountWorking.Location = new Point(664, 125);
            label_CountWorking.Name = "label_CountWorking";
            label_CountWorking.Size = new Size(102, 25);
            label_CountWorking.TabIndex = 27;
            label_CountWorking.Text = "＊勤務人数";
            // 
            // label_CountRest
            // 
            label_CountRest.AutoSize = true;
            label_CountRest.Location = new Point(664, 150);
            label_CountRest.Name = "label_CountRest";
            label_CountRest.Size = new Size(102, 25);
            label_CountRest.TabIndex = 26;
            label_CountRest.Text = "＊休憩人数";
            // 
            // _NowTime
            // 
            _NowTime.AutoSize = true;
            _NowTime.Location = new Point(664, 175);
            _NowTime.Name = "_NowTime";
            _NowTime.Size = new Size(102, 25);
            _NowTime.TabIndex = 24;
            _NowTime.Text = "＊確定時刻";
            // 
            // label_NowChooseWork
            // 
            label_NowChooseWork.AutoSize = true;
            label_NowChooseWork.Location = new Point(664, 99);
            label_NowChooseWork.Name = "label_NowChooseWork";
            label_NowChooseWork.Size = new Size(102, 25);
            label_NowChooseWork.TabIndex = 23;
            label_NowChooseWork.Text = "＊勤務状態";
            // 
            // label_NowWork
            // 
            label_NowWork.AutoSize = true;
            label_NowWork.Location = new Point(664, 74);
            label_NowWork.Name = "label_NowWork";
            label_NowWork.Size = new Size(102, 25);
            label_NowWork.TabIndex = 28;
            label_NowWork.Text = "＊勤務状態";
            // 
            // label_Rest
            // 
            label_Rest.AutoSize = true;
            label_Rest.Location = new Point(451, 150);
            label_Rest.Name = "label_Rest";
            label_Rest.Size = new Size(135, 25);
            label_Rest.TabIndex = 19;
            label_Rest.Text = "休憩中の人数：";
            // 
            // label_NowUser
            // 
            label_NowUser.AutoSize = true;
            label_NowUser.Location = new Point(664, 49);
            label_NowUser.Name = "label_NowUser";
            label_NowUser.Size = new Size(102, 25);
            label_NowUser.TabIndex = 22;
            label_NowUser.Text = "＊ユーザー名";
            // 
            // button_rest
            // 
            button_rest.Location = new Point(569, 242);
            button_rest.Name = "button_rest";
            button_rest.Size = new Size(112, 34);
            button_rest.TabIndex = 21;
            button_rest.Text = "休憩切替";
            button_rest.UseVisualStyleBackColor = true;
            // 
            // label_ChooseWork
            // 
            label_ChooseWork.AutoSize = true;
            label_ChooseWork.Location = new Point(451, 99);
            label_ChooseWork.Name = "label_ChooseWork";
            label_ChooseWork.Size = new Size(171, 25);
            label_ChooseWork.TabIndex = 16;
            label_ChooseWork.Text = "選択中の勤務状態：";
            // 
            // label_AbsTime
            // 
            label_AbsTime.AutoSize = true;
            label_AbsTime.Location = new Point(451, 175);
            label_AbsTime.Name = "label_AbsTime";
            label_AbsTime.Size = new Size(102, 25);
            label_AbsTime.TabIndex = 18;
            label_AbsTime.Text = "確定時刻：";
            // 
            // label_Work
            // 
            label_Work.AutoSize = true;
            label_Work.Location = new Point(451, 74);
            label_Work.Name = "label_Work";
            label_Work.Size = new Size(153, 25);
            label_Work.TabIndex = 15;
            label_Work.Text = "現在の勤務状態：";
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(451, 49);
            label_User.Name = "label_User";
            label_User.Size = new Size(207, 25);
            label_User.TabIndex = 14;
            label_User.Text = "現在選択中のユーザー名：";
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Location = new Point(451, 12);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(102, 25);
            labelClock.TabIndex = 13;
            labelClock.Text = "＊時刻表示";
            // 
            // button_comit
            // 
            button_comit.Location = new Point(687, 242);
            button_comit.Name = "button_comit";
            button_comit.Size = new Size(60, 34);
            button_comit.TabIndex = 11;
            button_comit.Text = "確定";
            button_comit.UseVisualStyleBackColor = true;
            // 
            // _leaveWork
            // 
            _leaveWork.Location = new Point(503, 242);
            _leaveWork.Name = "_leaveWork";
            _leaveWork.Size = new Size(60, 34);
            _leaveWork.TabIndex = 12;
            _leaveWork.Text = "退勤";
            _leaveWork.UseVisualStyleBackColor = true;
            // 
            // button_atWork
            // 
            button_atWork.Location = new Point(437, 242);
            button_atWork.Name = "button_atWork";
            button_atWork.Size = new Size(60, 34);
            button_atWork.TabIndex = 10;
            button_atWork.Text = "出勤";
            button_atWork.UseVisualStyleBackColor = true;
            // 
            // label_cWork
            // 
            label_cWork.AutoSize = true;
            label_cWork.Location = new Point(451, 125);
            label_cWork.Name = "label_cWork";
            label_cWork.Size = new Size(135, 25);
            label_cWork.TabIndex = 17;
            label_cWork.Text = "勤務中の人数：";
            // 
            // CompanyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listview_Log);
            Controls.Add(label_CountWorking);
            Controls.Add(label_CountRest);
            Controls.Add(_NowTime);
            Controls.Add(label_cWork);
            Controls.Add(label_NowChooseWork);
            Controls.Add(label_NowWork);
            Controls.Add(label_Rest);
            Controls.Add(label_NowUser);
            Controls.Add(button_rest);
            Controls.Add(label_ChooseWork);
            Controls.Add(label_AbsTime);
            Controls.Add(label_Work);
            Controls.Add(label_User);
            Controls.Add(labelClock);
            Controls.Add(button_comit);
            Controls.Add(_leaveWork);
            Controls.Add(button_atWork);
            Controls.Add(listBoxEmployees);
            Name = "CompanyForm";
            Text = "CompanyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listBoxEmployees;
        private ListView listview_Log;
        private Label label_CountWorking;
        private Label label_CountRest;
        private Label _NowTime;
        private Label label_NowChooseWork;
        private Label label_NowWork;
        private Label label_Rest;
        private Label label_NowUser;
        private Button button_rest;
        private Label label_ChooseWork;
        private Label label_AbsTime;
        private Label label_Work;
        private Label label_User;
        private Label labelClock;
        private Button button_comit;
        private Button _leaveWork;
        private Button button_atWork;
        private Label label_cWork;
    }
}