namespace OOProjectBasedLeaning
{
    partial class ChangeForm
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
            textBoxEmployeeName = new TextBox();
            btnConfirmChange = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.Location = new Point(12, 12);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(411, 426);
            listBoxEmployees.TabIndex = 1;
            listBoxEmployees.UseCompatibleStateImageBehavior = false;
            listBoxEmployees.View = View.Details;
            listBoxEmployees.SelectedIndexChanged += listBoxEmployees_SelectedIndexChanged;
            // 
            // textBoxEmployeeName
            // 
            textBoxEmployeeName.Location = new Point(450, 12);
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(300, 31);
            textBoxEmployeeName.TabIndex = 2;
            // 
            // btnConfirmChange
            // 
            btnConfirmChange.Location = new Point(450, 60);
            btnConfirmChange.Name = "btnConfirmChange";
            btnConfirmChange.Size = new Size(150, 35);
            btnConfirmChange.TabIndex = 3;
            btnConfirmChange.Text = "名前を確定";
            btnConfirmChange.Click += btnConfirmChange_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(638, 403);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 35);
            btnBack.TabIndex = 4;
            btnBack.Text = "戻る";
            btnBack.Click += btnBack_Click;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnConfirmChange);
            Controls.Add(textBoxEmployeeName);
            Controls.Add(listBoxEmployees);
            Name = "ChangeForm";
            Text = "なまえかえるやつ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listBoxEmployees;
        private TextBox textBoxEmployeeName; // テキストボックスのフィールド宣言
        private Button btnConfirmChange; // ボタンのフィールド宣言
        private Button btnBack; // 戻るボタンのフィールド宣言
    }
}