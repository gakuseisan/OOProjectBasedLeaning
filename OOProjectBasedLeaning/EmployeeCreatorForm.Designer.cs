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
            gridBoard = new TableLayoutPanel(); // boardPanelをgridBoardに変更し、型をTableLayoutPanelに変更
            boardTitleLabel = new Label();
            gridBoard.SuspendLayout(); // boardPanelをgridBoardに変更
            Confirmed = new Button();
            button1.Location = new Point(619, 14);  
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 0;
            button1.Text = "従業員の作成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateGuestEvent;

            gridBoard.AllowDrop = true;
            gridBoard.BackColor = Color.Gray;
            // TableLayoutPanelの列と行を設定します。必要に応じて調整してください。
            gridBoard.ColumnCount = 1; // 仮の列数
            gridBoard.RowCount = 1;    // 仮の行数
            gridBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // 列のスタイル
            gridBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));       // 行のスタイル
            gridBoard.Location = new Point(12, 12);
            gridBoard.Name = "gridBoard"; // NameをgridBoardに変更
            gridBoard.Size = new Size(600, 600);
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
            // EmployeeCreatorForm
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 627);
            Controls.Add(button1);
            Controls.Add(gridBoard);
            // 
            // Confirmed
            // 
            Confirmed.Location = new Point(614, 96);
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
            ClientSize = new Size(759, 523);
            Controls.Add(Confirmed);
            Controls.Add(button1);

            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeeCreatorForm";
            Text = "EmployeeCreatorForm";
            gridBoard.ResumeLayout(false); // boardPanelをgridBoardに変更
            ResumeLayout(false);
        }

        #endregion

        private Button button1;

        private TableLayoutPanel gridBoard; // PanelからTableLayoutPanelに変更
        private Label boardTitleLabel;
        private Button Confirmed;

    }
}