﻿namespace OOProjectBasedLeaning
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
            gridBoard = new TableLayoutPanel();
            boardTitleLabel = new Label();
            Confirmed = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(681, 20);
            button1.Margin = new Padding(6, 8, 6, 8);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 0;
            button1.Text = "従業員の作成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateGuestEvent;
            // 
            // gridBoard
            // 
            gridBoard.AllowDrop = true;
            gridBoard.BackColor = Color.Gray;
            gridBoard.ColumnCount = 1;
            gridBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gridBoard.Location = new Point(17, 20);
            gridBoard.Margin = new Padding(4, 5, 4, 5);
            gridBoard.Name = "gridBoard";
            gridBoard.RowCount = 1;
            gridBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridBoard.Size = new Size(654, 1000);
            gridBoard.TabIndex = 1;
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
            // Confirmed
            // 
            Confirmed.Location = new Point(681, 109);
            Confirmed.Margin = new Padding(4, 5, 4, 5);
            Confirmed.Name = "Confirmed";
            Confirmed.Size = new Size(127, 52);
            Confirmed.TabIndex = 1;
            Confirmed.Text = "確定";
            Confirmed.UseVisualStyleBackColor = true;
            Confirmed.Click += Confirmed_Click;
            // 
            // EmployeeCreatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 535);
            Controls.Add(gridBoard);
            Controls.Add(Confirmed);
            Controls.Add(button1);
            Margin = new Padding(6, 8, 6, 8);
            Name = "EmployeeCreatorForm";
            Text = "EmployeeCreatorForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;

        private TableLayoutPanel gridBoard; // PanelからTableLayoutPanelに変更
        private Label boardTitleLabel;
        private Button Confirmed;

    }
}