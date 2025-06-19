namespace OOProjectBasedLeaning
{

    public partial class EmployeeRest : Form
    {

        public EmployeeRest()
        {

            InitializeComponent();

            // è]ã∆àıÇÃçÏê¨
            new EmployeeCreatorForm().Show();

            // â∆
            new HomeForm().Show();

            // âÔé–
            new CompanyForm().Show();

        }

    }

}
