namespace OOProjectBasedLeaning
{

    public partial class HomeForm : Form
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>();

        public HomeForm()
        {

            InitializeComponent();

        }

        // このメソッドをEmployeeCreatorFormから呼び出す
        public void AddEmployee(EmployeeModel employee)
        {
            employees.Add(employee);
            // 表示方法を適宜カスタマイズしてください
            MessageBox.Show($"追加された社員: {employee.Name}");
        }

        // すべての従業員情報を表示（例：ListBoxなどに表示する場合）
        public void DisplayEmployees()
        {
            // 例：ListBoxに追加
            listBoxEmployees.Items.Clear();
            foreach (var emp in employees)
            {
                listBoxEmployees.Items.Add($"{emp.Id} - {emp.Name}");
            }
        }

    }

}
