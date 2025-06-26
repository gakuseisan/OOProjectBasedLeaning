using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OOProjectBasedLeaning
{

    public partial class EmployeeCreatorForm : Form
    {
        private int employeeId = 10000;
        private List<EmployeeModel> createdEmployees = new List<EmployeeModel>();
        private HomeForm homeForm;

        public EmployeeCreatorForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.AllowDrop = false;

            gridBoard.ColumnStyles.Clear();
            gridBoard.RowStyles.Clear();

            gridBoard.ColumnCount = 1;//列数(横)
            gridBoard.RowCount = 10;  //行数(縦)

            gridBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            for (int i = 0; i < gridBoard.RowCount; i++)
                gridBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, AppConstants.CellSize_height));

            gridBoard.DragEnter += GridBoard_DragEnter;
            gridBoard.DragDrop += GridBoard_DragDrop;

        }

        private void CreateGuestEvent(object sender, EventArgs e)
        {
            var newEmployee = CreateEmployee();
            var newPanel = new EmployeePanel(newEmployee)
            {
                Width = AppConstants.emp_width,           
                Height = AppConstants.CellSize_height,   
                BackColor = Color.LightBlue,             
                Margin = new Padding(AppConstants.Xmargin, AppConstants.Ymargin, 0, 0)
            };

            for (int r = 0; r < gridBoard.RowCount; r++)
            {
                if (gridBoard.GetControlFromPosition(0, r) == null)
                {
                    gridBoard.Controls.Add(newPanel, 0, r);
                    return; 
                }
            }

            // 全てのグリッドセルが埋まっている場合にメッセージを表示
            MessageBox.Show("全てのグリッドセルが埋まっています。");
        }

         private EmployeeModel CreateEmployee() =>
            new EmployeeModel(++employeeId, $"Employee{employeeId}");


       private void GridBoard_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(EmployeePanel)) ? DragDropEffects.Move : DragDropEffects.None;
        }

         private void GridBoard_DragDrop(object sender, DragEventArgs e)
        {
             if (e.Data.GetData(typeof(EmployeePanel)) is not EmployeePanel draggedPanel) return;

            Point clientPoint = gridBoard.PointToClient(new Point(e.X, e.Y));
            int dropRow = clientPoint.Y / AppConstants.CellSize_height;

            if (dropRow < 0 || dropRow >= gridBoard.RowCount) return;

            // ドロップ先の列は常に0（1列グリッドのため）
            int dropCol = 0;
            Control existing = gridBoard.GetControlFromPosition(dropCol, dropRow);

            //パネルの入れ替え
            if (existing != null && existing != draggedPanel)
            {
                var existingPanel = existing as EmployeePanel;
                var original = gridBoard.GetCellPosition(draggedPanel);

                gridBoard.Controls.Remove(draggedPanel);
                gridBoard.Controls.Remove(existingPanel);

                gridBoard.Controls.Add(existingPanel, original.Column, original.Row);
                gridBoard.Controls.Add(draggedPanel, dropCol, dropRow);
            }
            // 単なる移動
            else
            {
                // gridBoardからドラッグされたパネルを一度削除
                gridBoard.Controls.Remove(draggedPanel);
                // ドラッグされたパネルをドロップ先の新しい位置に追加
                gridBoard.Controls.Add(draggedPanel, dropCol, dropRow);
            }

            gridBoard.Invalidate(); // gridBoardを再描画して変更を反映
        }

        public class EmployeePanel : Panel
        {
            private readonly EmployeeModel employee;

            public EmployeeModel EmployeeData => employee;

            public EmployeePanel(EmployeeModel employee)
            {
                this.employee = employee;  
                this.DoubleBuffered = true;  
 
                Controls.Add(new Label
                {
                    Text = $"{employee.Id}: {employee.Name}", // 表示テキスト（"10001: Employee10001"）
                    AutoSize = true,
                    Location = new Point(5, 5)
                });

                this.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        this.BringToFront(); // パネルを最前面に表示
                        // ドラッグ＆ドロップ操作を開始。移動許可
                        this.DoDragDrop(this, DragDropEffects.Move);
                    }
                };
            }
        }

        //確定ボタンが押された時データをhomeFormに移動させる
        private void Confirmed_Click(object sender, EventArgs e)
        {
            foreach (var emp in createdEmployees)
            {
                homeForm.AddEmployee(emp);
            }

            homeForm.DisplayEmployees();

        }
    }

    public static class AppConstants
    {
        public const int Xmargin = 5; // X軸方向のマージン
        public const int Ymargin = 5; // Y軸方向のマージン
        public const int CellSize_height = 60; // グリッドセルの高さ
        public const int emp_width = 1000; // 従業員パネルの幅
    }

}