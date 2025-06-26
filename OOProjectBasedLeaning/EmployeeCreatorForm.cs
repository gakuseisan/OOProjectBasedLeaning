using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{

    public partial class EmployeeCreatorForm : DragDropForm
    {

        private int employeeId = 10000;
        private List<EmployeeModel> createdEmployees = new List<EmployeeModel>();
        private HomeForm homeForm;

        public EmployeeCreatorForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;

            employeeId = GetMaxEmployeeIdFromDatabase();
        }

        private void CreateGuestEvent(object sender, EventArgs e)
        {
            var employee = CreateEmployee();

            createdEmployees.Add(employee);

            Controls.Add(new EmployeePanel(employee)
            {
                Location = new Point(10, 10 + Controls.Count * 30),
                Width = 300,
            });

        }

        //現在のEmployeeIDの最大値を取得
        private int GetMaxEmployeeIdFromDatabase()
        {
            int maxId = 0;
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OOProjectBasedLeaning;Trusted_Connection=True;";

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

        protected override void OnFormDragEnterSerializable(DragEventArgs dragEventArgs)
        {

            dragEventArgs.Effect = DragDropEffects.Move;

        }

        protected override void OnFormDragDropSerializable(object? serializableObject, DragEventArgs dragEventArgs)
        {

            if (serializableObject is DragDropPanel)
            {

                (serializableObject as DragDropPanel).AddDragDropForm(this, PointToClient(new Point(dragEventArgs.X, dragEventArgs.Y)));

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
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OOProjectBasedLeaning;Trusted_Connection=True;";

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

    }

}
