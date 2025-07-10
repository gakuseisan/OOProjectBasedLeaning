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

        // ListBox�̑I��ύX�C�x���g 
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
                label_NowUser.Text = "�]�ƈ����I��";
                _NowChooseWork.Text = "";
                // �폜��ɑI�����������ꂽ�ꍇ���\�����N���A
                _atWorkDisplay.Text = "";
                label_leaveWorkDisplay.Text = "";
            }
        }

        private void UpdateStatusDisplay(EmployeeModel employee)
        {
            if (employee == null) return;

            bool atWork = company.IsAtWork(employee);
            _NowChooseWork.Text = atWork ? "�Ζ���" : "�ދΒ�";
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
            // Company �� TimeTracker �������� 
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
            // �s�v�Ȃ�폜 
        }

        // �m��{�^�������ŕۗ����̑�������s 
        private void button_comit_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("�]�ƈ���I�����Ă��������B");
                return;
            }

            try
            {
                switch (pendingAction)
                {
                    case PendingAction.ClockIn:
                        company.ClockIn(selectedEmployee);
                        _atWorkDisplay.Text = DateTime.Now.ToString("HH:mm:ss");  // �o�Ύ�����\�� 
                        MessageBox.Show($"{selectedEmployee.Name} ���񂪏o�΂��܂����B");
                        break;

                    case PendingAction.ClockOut:
                        company.ClockOut(selectedEmployee);
                        label_leaveWorkDisplay.Text = DateTime.Now.ToString("HH:mm:ss");  // �ދΎ�����\�� 
                        MessageBox.Show($"{selectedEmployee.Name} ���񂪑ދ΂��܂����B");
                        break;

                    default:
                        MessageBox.Show("���삪�I������Ă��܂���B");
                        break;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("�G���[: " + ex.Message);
            }
            finally
            {
                pendingAction = PendingAction.none;
                labelPendingAction.Text = "";  // �ۗ���ԃ��x�����Z�b�g
                UpdateStatusDisplay(selectedEmployee);
            }
        }

        // �o�΃{�^�� 
        private void button_atWork_Click(object sender, EventArgs e)
        {
            pendingAction = PendingAction.ClockIn;
            labelPendingAction.Text = "�o�Ώ������I������܂���";
            MessageBox.Show("�o�Ώ������m�肵�Ă��������B");
        }

        // �ދ΃{�^�� 
        private void button_leaveWork_Click(object sender, EventArgs e)
        {
            pendingAction = PendingAction.ClockOut;
            labelPendingAction.Text = "�ދΏ������I������܂���";
            MessageBox.Show("�ދΏ������m�肵�Ă��������B");
        }

        // �x�e�{�^���i�������̂��߃��b�Z�[�W�\���̂݁j 
        private void button_rest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�x�e�@�\�͌��ݖ������ł��B");
        }

        private void labelPendingAction_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("�폜����]�ƈ���I�����Ă��������B", "�폜�G���[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �m�F�_�C�A���O�̕\��
            DialogResult result = MessageBox.Show(
                $"{selectedEmployee.Name} ������폜���Ă���낵���ł����H",
                "�]�ƈ��̍폜�m�F",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string deletedEmployeeName = selectedEmployee.Name; // �폜����]�ƈ������ꎞ�I�ɕێ�

                // employees���X�g����폜
                employees.Remove(selectedEmployee);

                // ListBox�̕\�����X�V
                DisplayEmployees();

                // �I����Ԃ��N���A
                selectedEmployee = null;
                listBoxEmployees.ClearSelected(); // ListBox�̑I��������

                // �֘A����\�������Z�b�g
                label_NowUser.Text = "�]�ƈ����I��";
                _NowChooseWork.Text = "";
                _atWorkDisplay.Text = "";
                label_leaveWorkDisplay.Text = "";
                labelPendingAction.Text = "";
                pendingAction = PendingAction.none;

                // MessageBox.Show��selectedEmployee��null�ɂȂ�O�Ɉړ�
                MessageBox.Show($"{deletedEmployeeName} ������폜���܂����B", "�폜����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void namehenkou_Click(object sender, EventArgs e)
        {
            if(selectedEmployee == null)
                {
                MessageBox.Show("���[�U�[����ύX����]�ƈ���I�����Ă��������B");
                return;
            }

            string currentName = selectedEmployee.Name;
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "�V�������[�U�[������͂��Ă��������F",
                "���[�U�[���ύX",
                currentName);

            if (!string.IsNullOrWhiteSpace(input))
            {
                selectedEmployee.Name = input;

                // ListBox �\���X�V
                DisplayEmployees();

                // �đI�����ď����X�V
                listBoxEmployees.SelectedIndex = employees.IndexOf(selectedEmployee);

                MessageBox.Show("���[�U�[����ύX���܂����B");
            }
            else
            {
                MessageBox.Show("���[�U�[���̕ύX�̓L�����Z������܂����B");
            }
        }
    }
}
