using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public static class AppConstants
    {
        public const int Xmargin = 70; // 横余白 
        public const int Ymargin = 50; // 上余白 
        public const int CellSize_height = 60; // グリッド間隔
        public const int emp_width = 200; // 従業員パネルの幅
        public const int emp_height = 10; // 従業員パネルの高さ
    }
    public partial class EmployeeCreatorForm : DragDropForm
    {
        private int employeeId = 10000;

        public EmployeeCreatorForm()
        {
            InitializeComponent();
            this.AllowDrop = false;
        }

        private void CreateGuestEvent(object sender, EventArgs e)
        {
            var newEmployee = CreateEmployee();

            //従業員パネルのあれこれ
            EmployeePanel newEmployeePanel = new EmployeePanel(newEmployee)
            {
                Location = new Point(
                    AppConstants.Xmargin, 
                    AppConstants.Ymargin + (employeeId - 10001) * AppConstants.CellSize_height
                    ),
                Width = AppConstants.emp_width,
                Height = AppConstants.CellSize_height - AppConstants.emp_height,
                BackColor = Color.LightBlue
            };

            boardPanel.Controls.Add(newEmployeePanel);
            newEmployeePanel.BringToFront();
        }

        private EmployeeModel CreateEmployee()
        {
            employeeId++;
            return new EmployeeModel(employeeId, "Employee" + employeeId);
        }

        protected override void OnFormDragEnterSerializable(DragEventArgs dragEventArgs)
        {
            dragEventArgs.Effect = DragDropEffects.None;
        }

        public class EmployeePanel : Panel
        {
            private bool dragging = false;
            private Point dragOffset; 
            private readonly EmployeeModel employee;

            public EmployeePanel(EmployeeModel employee)
            {
                this.employee = employee;

                Label label = new Label
                {
                    Text = $"{employee.Id}: {employee.Name}",
                    AutoSize = true,
                    Location = new Point(5, 5)
                };

                Controls.Add(label);

                this.MouseDown += EmployeePanel_MouseDown;
                this.MouseMove += EmployeePanel_MouseMove;
                this.MouseUp += EmployeePanel_MouseUp;
            }

            private void EmployeePanel_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    dragging = true;
                    // ドラッグ開始時のマウス位置とパネルの左上隅のオフセットを記録
                    dragOffset = new Point(e.X, e.Y);
                    this.BringToFront(); // ドラッグ中のパネルを最前面に表示
                }
            }

            private void EmployeePanel_MouseMove(object sender, MouseEventArgs e)
            {
                if (dragging)
                {
                    // 親コントロールのクライアント座標におけるマウスの現在位置
                    Point currentScreenPos = this.Parent.PointToClient(Cursor.Position);

                    // 新しいパネルの左上座標を計算 (水平方向は固定)
                    int newLeft = AppConstants.Xmargin;
                    int newTop = currentScreenPos.Y - dragOffset.Y; // マウス位置からオフセットを引く

                    // 親コントロール (boardPanel) の境界内に制限します
                    if (this.Parent != null)
                    {
                        // 垂直方向の境界チェック
                        // 上端制限: グリッド開始Yオフセットより下には行かせません
                        newTop = Math.Max(AppConstants.Ymargin, newTop);
                        // 下端制限: 親の高さからパネルの高さとグリッド開始Yオフセットを考慮します
                        newTop = Math.Min(newTop, this.Parent.ClientSize.Height - this.Height + AppConstants.Ymargin - AppConstants.CellSize_height);
                    }

                    this.Location = new Point(newLeft, newTop);
                }
            }

            private void EmployeePanel_MouseUp(object sender, MouseEventArgs e)
            {
                if (dragging)
                {
                    dragging = false;

                    // 垂直方向のみグリッドにスナップします
                    // 現在のパネルの上端位置からグリッド開始オフセットを引いて、グリッド原点からの相対位置を求めます
                    int relativeTop = this.Top - AppConstants.Ymargin;

                    // 最も近いグリッドラインにスナップします
                    int snappedRelativeTop = (int)Math.Round((double)relativeTop / AppConstants.CellSize_height) * AppConstants.CellSize_height;

                    // オフセットを再度加算して、最終的なY座標を決定します
                    int snappedTop = snappedRelativeTop + AppConstants.Ymargin;

                    // スナップした位置が親の境界内に収まるように最終調整します
                    if (this.Parent != null)
                    {
                        // 垂直方向の境界チェック
                        snappedTop = Math.Max(AppConstants.Ymargin, snappedTop);
                        snappedTop = Math.Min(snappedTop, this.Parent.ClientSize.Height - this.Height + AppConstants.Ymargin - AppConstants.CellSize_height);
                    }

                    this.Location = new Point(AppConstants.Xmargin, snappedTop); // 固定X座標と計算されたスナップTopを設定します
                }
            }
        }
    }
}