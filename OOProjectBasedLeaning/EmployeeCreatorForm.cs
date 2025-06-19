using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public partial class EmployeeCreatorForm : DragDropForm
    {
        private Panel kokubanPanel;
        private int employeeId = 10000;

        public EmployeeCreatorForm()
        {
            InitializeComponent();
            // フォームのドラッグ＆ドロップを無効化（黒板パネルだけが有効）
            this.AllowDrop = false;
            InitializeKokuban();
        }

        private void InitializeKokuban()
        {
            // 黒板パネルの初期化（ドラッグ＆ドロップ有効）
            kokubanPanel = new Panel
            {
                Location = new Point(100, 10),
                Size = new Size(600, 600),
                BackColor = Color.Black,
                AllowDrop = true
            };

            // 黒板パネル上でのみ DragEnter/DragDrop イベントを発生させる
            kokubanPanel.DragEnter += Kokuban_DragEnter;
            kokubanPanel.DragDrop += Kokuban_DragDrop;

            // 黒板のタイトルラベル
            Label titleLabel = new Label
            {
                Text = "こくばん",
                ForeColor = Color.White,
                Location = new Point(10, 10),
                AutoSize = true
            };

            kokubanPanel.Controls.Add(titleLabel);
            Controls.Add(kokubanPanel);
            kokubanPanel.BringToFront();
        }

        // 黒板パネル上で、ファイルがドラッグされている場合のみ操作を許可
        private void Kokuban_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // 黒板パネル上のドロップ処理（例として、ドロップされたファイル数を表示）
        private void Kokuban_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                MessageBox.Show($"ドロップされたファイル数: {files.Length}", "こくばん");
            }
        }

        // 社員パネル追加（黒板パネル上に少し間隔をあけて順番に並べる）
        private void CreateGuestEvent(object sender, EventArgs e)
        {
            // 黒板パネル上の社員パネルの数を、タイトルラベルを除いてカウントする
            int employeePanelCount = kokubanPanel.Controls.OfType<EmployeePanel>().Count();
            int gap = 10;
            int panelHeight = 50;
            // タイトルラベルの下（最初のコントロール）からパネルを配置する
            int startY = ((Label)kokubanPanel.Controls[0]).Bottom + gap;
            int panelY = startY + (panelHeight + gap) * employeePanelCount;

            EmployeePanel newEmployeePanel = new EmployeePanel(CreateEmployee())
            {
                Location = new Point(10, panelY),
                Width = kokubanPanel.Width - 20,  // 黒板内で左右に余裕をもたせる
                Height = panelHeight,
                BackColor = Color.LightBlue
            };

            kokubanPanel.Controls.Add(newEmployeePanel);
            newEmployeePanel.BringToFront();
        }

        private Employee CreateEmployee()
        {
            employeeId++;
            return new EmployeeModel(employeeId, "Employee" + employeeId);
        }

        // DragDropForm から継承しているフォーム全体のドラッグ＆ドロップ処理は、ここで無効化
        protected override void OnFormDragEnterSerializable(DragEventArgs dragEventArgs)
        {
            // フォームでの dragenter イベントは影響させない
            dragEventArgs.Effect = DragDropEffects.None;
        }

        protected override void OnFormDragDropSerializable(object? serializableObject, DragEventArgs dragEventArgs)
        {
            // フォームでの drop イベントも無効化
        }
    }
}