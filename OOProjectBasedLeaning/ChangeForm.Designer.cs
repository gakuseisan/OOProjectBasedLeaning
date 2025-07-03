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
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxEmployees);
            Name = "ChangeForm";
            Text = "なまえかえるやつ";
            ResumeLayout(false);
        }

        #endregion

        private ListView listBoxEmployees;
    }
}