namespace OOProjectBasedLeaning
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            // ��� HomeForm �����
            HomeForm homeForm = new HomeForm();

            // HomeForm �� EmployeeCreatorForm �ɓn��
            EmployeeCreatorForm creatorForm = new EmployeeCreatorForm(homeForm);

            // �\��
            homeForm.Show();
            creatorForm.Show();

            // ��Ѓt�H�[��
            new CompanyForm().Show();

        }

    }

}
