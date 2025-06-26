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
            Confirmed = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(614, 20);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(127, 52);
            button1.TabIndex = 0;
            button1.Text = "従業員の作成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateGuestEvent;
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
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Confirmed;
    }
}