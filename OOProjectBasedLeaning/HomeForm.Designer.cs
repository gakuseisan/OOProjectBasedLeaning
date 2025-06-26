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
            button_atWork.Location = new Point(449, 301);
            button_atWork.Name = "button_atWork";
            button_atWork.Size = new Size(112, 34);
            button_atWork.TabIndex = 1;
            button_atWork.Text = "出勤";
            button_atWork.UseVisualStyleBackColor = true;
            // 
            // _leaveWork
            // 
            _leaveWork.Location = new Point(567, 301);
            _leaveWork.Name = "_leaveWork";
            _leaveWork.Size = new Size(112, 34);
            _leaveWork.TabIndex = 2;
            _leaveWork.Text = "退勤";
            _leaveWork.UseVisualStyleBackColor = true;
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Location = new Point(476, 88);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(102, 25);
            labelClock.TabIndex = 3;
            labelClock.Text = "＊時刻表示";
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Location = new Point(469, 142);
            label_User.Name = "label_User";
            label_User.Size = new Size(207, 25);
            label_User.TabIndex = 4;
            label_User.Text = "現在選択中のユーザー名：";
            // 
            // _Work
            // 
            _Work.AutoSize = true;
            _Work.Location = new Point(476, 194);
            _Work.Name = "_Work";
            _Work.Size = new Size(102, 25);
            _Work.TabIndex = 5;
            _Work.Text = "勤務状態：";
            // 
            // label_AbsTime
            // 
            label_AbsTime.AutoSize = true;
            label_AbsTime.Location = new Point(476, 245);
            label_AbsTime.Name = "label_AbsTime";
            label_AbsTime.Size = new Size(156, 25);
            label_AbsTime.TabIndex = 6;
            label_AbsTime.Text = "出退勤確定時刻：";
            // 
            // button_rest
            // 
            button_rest.Location = new Point(685, 301);
            button_rest.Name = "button_rest";
            button_rest.Size = new Size(112, 34);
            button_rest.TabIndex = 7;
            button_rest.Text = "休憩切替";
            button_rest.UseVisualStyleBackColor = true;
            // 
            // label_NowUser
            // 
            label_NowUser.AutoSize = true;
            label_NowUser.Location = new Point(685, 142);
            label_NowUser.Name = "label_NowUser";
            label_NowUser.Size = new Size(102, 25);
            label_NowUser.TabIndex = 8;
            label_NowUser.Text = "＊ユーザー名";
            // 
            // label_NowWork
            // 
            label_NowWork.AutoSize = true;
            label_NowWork.Location = new Point(685, 194);
            label_NowWork.Name = "label_NowWork";
            label_NowWork.Size = new Size(102, 25);
            label_NowWork.TabIndex = 8;
            label_NowWork.Text = "＊勤務状態";
            // 
            // _NowTime
            // 
            _NowTime.AutoSize = true;
            _NowTime.Location = new Point(686, 245);
            _NowTime.Name = "_NowTime";
            _NowTime.Size = new Size(102, 25);
            _NowTime.TabIndex = 8;
            _NowTime.Text = "＊勤務状態";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_NowTime);
            Controls.Add(label_NowWork);
            Controls.Add(label_NowUser);
            Controls.Add(button_rest);
            Controls.Add(label_AbsTime);
            Controls.Add(_Work);
            Controls.Add(label_User);
            Controls.Add(labelClock);
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
    }
}
