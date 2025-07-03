using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
            this.homeForm = homeForm;

            employeeId = GetMaxEmployeeIdFromDatabase();
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

        //現在のEmployeeIDの最大値を取得
        private int GetMaxEmployeeIdFromDatabase()
        {
            int maxId = 0;
            string connectionString = "\"Server=(LocalDB)\\\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\\\App_Data\\\\OOProjectBasedLeaning.mdf;Integrated Security=True;\"\r\n";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT ISNULL(MAX(EmployeeID), 0) FROM Employees";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        maxId = id;
                    }
                }
            }

            return maxId;
        }

        private EmployeeModel CreateEmployee()
        {
            employeeId++;

            TimeSpan inTime = TimeSpan.FromHours(10);     // 10:00
            TimeSpan outTime = TimeSpan.FromHours(17);    // 17:00
            TimeSpan workSum = outTime - inTime;
            TimeSpan restSum = TimeSpan.FromMinutes(60);  // 昼休憩1時間

            return new EmployeeModel(
                employeeId,
                "Employee" + employeeId,
                workSum,
                1,
                inTime,
                outTime,
                restSum,
                ""
            );
        }


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
            // 🔽 DBに登録
            foreach (var employee in createdEmployees)
            {
                InsertEmployeeToDatabase(employee);
            }

            MessageBox.Show("全従業員をデータベースに登録しました。");


        }

        //データをデータベースに登録
        private void InsertEmployeeToDatabase(EmployeeModel employee)
        {
            string connectionString = "Server=(LocalDB)\\\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\\\App_Data\\\\OOProjectBasedLeaning.mdf;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"
            INSERT INTO Employees (
                EmployeeID, EmployeeName, WorkTime_Sum, WorkDayCount,
                WorkTime_In, WorkTime_Out, WorkTime_RestSum, WorkStatus
            ) VALUES (
                @EmployeeID, @EmployeeName, @WorkTime_Sum, @WorkDayCount,
                @WorkTime_In, @WorkTime_Out, @WorkTime_RestSum, @WorkStatus
            )";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employee.Id);
                    cmd.Parameters.AddWithValue("@EmployeeName", employee.Name);
                    cmd.Parameters.AddWithValue("@WorkTime_Sum", employee.WorkTimeSum);
                    cmd.Parameters.AddWithValue("@WorkDayCount", employee.WorkDayCount);
                    cmd.Parameters.AddWithValue("@WorkTime_In", employee.WorkTimeIn);
                    cmd.Parameters.AddWithValue("@WorkTime_Out", employee.WorkTimeOut);
                    cmd.Parameters.AddWithValue("@WorkTime_RestSum", (object?)employee.WorkTimeRestSum ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@WorkStatus", (object?)employee.WorkStatus ?? DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void gridBoard_Paint(object sender, PaintEventArgs e)
        {

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