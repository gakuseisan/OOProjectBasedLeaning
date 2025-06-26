using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public partial class HomeForm : Form
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        private TimeRecorder recorder;  // TimeRecorder ���g��

        public HomeForm()
        {
            InitializeComponent();
        }

        public void AddEmployee(EmployeeModel employee)
        {
            employees.Add(employee);
            MessageBox.Show($"�ǉ����ꂽ�Ј�: {employee.Name}");
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
            // TimeRecorder ������
            recorder = new TimeRecorder();

            // ���v�p���x���Ƀo�C���h�i�����X�V�����j
            recorder.BindClock(labelClock);

            // �^�C�}�[�J�n
            recorder.Start();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recorder.Dispose();
        }

    }
}
