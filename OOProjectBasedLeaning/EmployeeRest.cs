namespace OOProjectBasedLeaning
{

    public partial class EmployeeRest : Form
    {

        public EmployeeRest()
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
