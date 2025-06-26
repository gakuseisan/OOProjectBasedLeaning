namespace OOProjectBasedLeaning
{
    partial class EmployeeCreatorForm
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
            button1 = new Button();
            boardPanel = new Panel();
            boardTitleLabel = new Label();
            boardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(619, 14);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 0;
            button1.Text = "従業員の作成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateGuestEvent;
            // 
            // boardPanel
            // 
            boardPanel.AllowDrop = true;
            boardPanel.BackColor = Color.Gray;
            boardPanel.Controls.Add(boardTitleLabel);
            boardPanel.Location = new Point(12, 12);
            boardPanel.Name = "boardPanel";
            boardPanel.Size = new Size(600, 600);
            boardPanel.TabIndex = 1;
            // 
            // boardTitleLabel
            // 
            boardTitleLabel.AutoSize = true;
            boardTitleLabel.ForeColor = Color.White;
            boardTitleLabel.Location = new Point(10, 10);
            boardTitleLabel.Name = "boardTitleLabel";
            boardTitleLabel.Size = new Size(52, 25);
            boardTitleLabel.TabIndex = 0;
            boardTitleLabel.Text = "ボード";
            // 
            // EmployeeCreatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 627);
            Controls.Add(button1);
            Controls.Add(boardPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeeCreatorForm";
            Text = "EmployeeCreatorForm";
            boardPanel.ResumeLayout(false);
            boardPanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Button button1;
        private Panel boardPanel;
        private Label boardTitleLabel;
    }
}