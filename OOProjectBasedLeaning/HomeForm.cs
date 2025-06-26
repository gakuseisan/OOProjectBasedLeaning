using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public partial class HomeForm : Form
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        private TimeRecorder recorder;  // TimeRecorder を使う

        public HomeForm()
        {
            InitializeComponent();
        }

        public void AddEmployee(EmployeeModel employee)
        {
            employees.Add(employee);
            MessageBox.Show($"追加された社員: {employee.Name}");
        }

        public void DisplayEmployees()
        {
            listBoxEmployees.Items.Clear();
            foreach (var emp in employees)
            {
                listBoxEmployees.Items.Add($"{emp.Id} - {emp.Name}");
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // TimeRecorder 初期化
            recorder = new TimeRecorder();

            // 時計用ラベルにバインド（自動更新される）
            recorder.BindClock(labelClock);

            // タイマー開始
            recorder.Start();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recorder.Dispose();
        }

    }
}
