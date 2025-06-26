namespace OOProjectBasedLeaning
{

    public partial class HomeForm : Form
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        public HomeForm()
        {

            InitializeComponent();

        }

        // ���̃��\�b�h��EmployeeCreatorForm����Ăяo��
        public void AddEmployee(EmployeeModel employee)
        {
            employees.Add(employee);
            // �\�����@��K�X�J�X�^�}�C�Y���Ă�������
            MessageBox.Show($"�ǉ����ꂽ�Ј�: {employee.Name}");
        }

        // ���ׂĂ̏]�ƈ�����\���i��FListBox�Ȃǂɕ\������ꍇ�j
        public void DisplayEmployees()
        {
            // ��FListBox�ɒǉ�
            listBoxEmployees.Items.Clear();
            foreach (var emp in employees)
            {
                listBoxEmployees.Items.Add($"{emp.Id} - {emp.Name}");
            }
        }

    }

}
