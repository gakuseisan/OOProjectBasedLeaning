namespace OOProjectBasedLeaning
{

    public partial class EmployeeRest : Form
    {

        public EmployeeRest()
        {

            InitializeComponent();

            // �]�ƈ��̍쐬
            new EmployeeCreatorForm().Show();

            // ��
            new HomeForm().Show();

            // ���
            new CompanyForm().Show();

        }

    }

}
