namespace OOProjectBasedLeaning
{

    public partial class EmployeeRest : Form
    {

        public EmployeeRest()
        {

            InitializeComponent();

            // 先に HomeForm を作る
            HomeForm homeForm = new HomeForm();

            // HomeForm を EmployeeCreatorForm に渡す
            EmployeeCreatorForm creatorForm = new EmployeeCreatorForm(homeForm);

            // 表示
            homeForm.Show();
            creatorForm.Show();

            // 会社フォーム
            new CompanyForm().Show();

        }

    }

}
