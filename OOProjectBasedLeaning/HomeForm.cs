using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public partial class HomeForm : Form
    {
        private List<EmployeeModel> employees = new();
        private TimeRecorder recorder;

        public HomeForm()
        {
            InitializeComponent();
        }

        public void AddEmployee(EmployeeModel employee)
        {
            employees.Add(employee);
            listBoxEmployees.Items.Add($"{employee.Id} - {employee.Name}");
        }

        public void DisplayEmployees()
        {
            listBoxEmployees.Items.Clear();
            foreach (var emp in employees)
            {
                listBoxEmployees.Items.Add($"{emp.Id} - {emp.Name}");
            }
        }

        // 従業員リストを外部から取得するための公開メソッド
        public List<EmployeeModel> GetEmployees()
        {
            return employees;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            recorder = new TimeRecorder();
            recorder.BindClock(labelClock);
            recorder.Start();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recorder.Dispose();
        }

        private void changejump_Click(object sender, EventArgs e)
        {
            // ChangeForm に HomeForm のインスタンスを渡す
            ChangeForm changeForm = new ChangeForm(this);
            changeForm.Show();
        }
    }
}