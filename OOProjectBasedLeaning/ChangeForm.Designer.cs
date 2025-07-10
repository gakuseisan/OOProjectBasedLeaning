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
            textBoxEmployeeName = new TextBox(); // テキストボックスを追加
            btnConfirmChange = new Button(); // ボタンを追加
            SuspendLayout();
            //
            // listBoxEmployees
            //
            listBoxEmployees.Location = new Point(12, 12);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(411, 426);
            listBoxEmployees.TabIndex = 1;
            listBoxEmployees.UseCompatibleStateImageBehavior = false;
            listBoxEmployees.View = View.Details; // 詳細表示モードに設定
            listBoxEmployees.Columns.Add("ID", 50, HorizontalAlignment.Left); // ID列
            listBoxEmployees.Columns.Add("氏名", 200, HorizontalAlignment.Left); // 氏名列
            // ListView の選択イベントを追加
            listBoxEmployees.SelectedIndexChanged += new EventHandler(this.listBoxEmployees_SelectedIndexChanged);
            //
            // textBoxEmployeeName
            //
            textBoxEmployeeName.Location = new Point(450, 12); // 適当な位置に配置
            textBoxEmployeeName.Name = "textBoxEmployeeName";
            textBoxEmployeeName.Size = new Size(300, 31);
            textBoxEmployeeName.TabIndex = 2; // タブオーダー
            //
            // btnConfirmChange
            //
            btnConfirmChange.Location = new Point(450, 60); // テキストボックスの下に配置
            btnConfirmChange.Name = "btnConfirmChange";
            btnConfirmChange.Size = new Size(150, 35);
            btnConfirmChange.TabIndex = 3; // タブオーダー
            btnConfirmChange.Text = "名前を確定";
            // ボタンのクリックイベントを追加
            btnConfirmChange.Click += new EventHandler(this.btnConfirmChange_Click);
            //
            // ChangeForm
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmChange); // ボタンをフォームに追加
            Controls.Add(textBoxEmployeeName); // テキストボックスをフォームに追加
            Controls.Add(listBoxEmployees);
            Name = "ChangeForm";
            Text = "なまえかえるやつ";
            ResumeLayout(false);
            PerformLayout(); // レイアウトを再計算するために追加
        }

        #endregion

        private ListView listBoxEmployees;
        private TextBox textBoxEmployeeName; // テキストボックスのフィールド宣言
        private Button btnConfirmChange; // ボタンのフィールド宣言
    }
}