using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{

    public partial class EmployeeCreatorForm : DragDropForm
    {

        private int employeeId = 10000;
        private List<EmployeeModel> createdEmployees = new List<EmployeeModel>();
        private HomeForm homeForm;

        public EmployeeCreatorForm(HomeForm homeForm)
        {

            InitializeComponent();
            this.homeForm = homeForm;
            this.homeForm = homeForm;
        }

        private void CreateGuestEvent(object sender, EventArgs e)
        {
            var employee = CreateEmployee();

            createdEmployees.Add(employee);

            Controls.Add(new EmployeePanel(employee)
            {
                Location = new Point(10, 10 + Controls.Count * 30),
                Width = 300,
            });

        }


//      private Employee CreateEmployee()
        private EmployeeModel CreateEmployee()
        {

            employeeId++;

            return new EmployeeModel(employeeId, "Employee" + employeeId);

        }
        protected override void OnFormDragEnterSerializable(DragEventArgs dragEventArgs)
        {

            dragEventArgs.Effect = DragDropEffects.Move;

        }

        protected override void OnFormDragDropSerializable(object? serializableObject, DragEventArgs dragEventArgs)
        {

            if (serializableObject is DragDropPanel)
            {

                (serializableObject as DragDropPanel).AddDragDropForm(this, PointToClient(new Point(dragEventArgs.X, dragEventArgs.Y)));

            }

        }

        //確定ボタンが押された時データをhomeFormに移動させる
        private void Confirmed_Click(object sender, EventArgs e)
        {
            foreach (var emp in createdEmployees)
            {
                homeForm.AddEmployee(emp);
            }

            homeForm.DisplayEmployees();

        }
    }

}
