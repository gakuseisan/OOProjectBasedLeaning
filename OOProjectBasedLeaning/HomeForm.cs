using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public partial class HomeForm : Form
    {
        private Company company;
        private TimeTracker timeTracker;

        private EmployeeModel selectedEmployee;
        private enum PendingAction { none, ClockIn, ClockOut }
        private PendingAction pendingAction = PendingAction.none;

        private List<EmployeeModel> employees = new();
        private TimeRecorder recorder;

        public HomeForm()
        {
            InitializeComponent();
        }

        // ListBoxの選択変更イベント 
        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBoxEmployees.SelectedIndex;
            if (idx >= 0 && idx < employees.Count)
            {
                selectedEmployee = employees[idx];
                label_NowUser.Text = selectedEmployee.Name;
                UpdateStatusDisplay(selectedEmployee);
            }
            else
            {
                selectedEmployee = null;
                label_NowUser.Text = "従業員未選択";
                _NowChooseWork.Text = "";
            }
        }

        private void UpdateStatusDisplay(EmployeeModel employee)
        {
            if (employee == null) return;

            bool atWork = company.IsAtWork(employee);
            _NowChooseWork.Text = atWork ? "勤務中" : "退勤中";
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

        public List<EmployeeModel> GetEmployees()
        {
            return employees;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Company と TimeTracker を初期化 
            company = new CompanyModel("MyCompany");
            timeTracker = new TimeTrackerModel(company);

            recorder = new TimeRecorder();
            recorder.BindClock(labelClock);
            recorder.Start();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recorder.Dispose();
        }

        private void _NowTime_Click(object sender, EventArgs e)
        {
            // 不要なら削除 
        }

        // 確定ボタン押下で保留中の操作を実行 
        private void button_comit_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("従業員を選択してください。");
                return;
            }

            try
            {
                switch (pendingAction)
                {
                    case PendingAction.ClockIn:
                        company.ClockIn(selectedEmployee);
                        _atWorkDisplay.Text = DateTime.Now.ToString("HH:mm:ss");  // 出勤時刻を表示 
                        MessageBox.Show($"{selectedEmployee.Name} さんが出勤しました。");
                        break;

                    case PendingAction.ClockOut:
                        company.ClockOut(selectedEmployee);
                        label_leaveWorkDisplay.Text = DateTime.Now.ToString("HH:mm:ss");  // 退勤時刻を表示 
                        MessageBox.Show($"{selectedEmployee.Name} さんが退勤しました。");
                        break;

                    default:
                        MessageBox.Show("操作が選択されていません。");
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("エラー: " + ex.Message);
            }
            finally
            {
                pendingAction = PendingAction.none;
                labelPendingAction.Text = "";  // 保留状態ラベルリセット
                UpdateStatusDisplay(selectedEmployee);
            }
        }

        // 出勤ボタン 
        private void button_atWork_Click(object sender, EventArgs e)
        {
            pendingAction = PendingAction.ClockIn;
            labelPendingAction.Text = "出勤処理が選択されました";
            MessageBox.Show("出勤処理を確定してください。");
        }

        // 退勤ボタン 
        private void button_leaveWork_Click(object sender, EventArgs e)
        {
            pendingAction = PendingAction.ClockOut;
            labelPendingAction.Text = "退勤処理が選択されました";
            MessageBox.Show("退勤処理を確定してください。");
        }

        // 休憩ボタン（未実装のためメッセージ表示のみ） 
        private void button_rest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("休憩機能は現在未実装です。");
        }

        private void labelPendingAction_Click(object sender, EventArgs e)
        {

        }
    }
}
