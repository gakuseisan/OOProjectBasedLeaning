using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public partial class EmployeeCreatorForm : Form
    {
        private int employeeId = 10000;
        private List<EmployeeModel> createdEmployees = new();
        private HomeForm homeForm;

        public EmployeeCreatorForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;

            this.AllowDrop = false;

            gridBoard.ColumnStyles.Clear();
            gridBoard.RowStyles.Clear();

            gridBoard.ColumnCount = 1;
            gridBoard.RowCount = 10;

            gridBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            for (int i = 0; i < gridBoard.RowCount; i++)
                gridBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, AppConstants.CellSize_height));

            gridBoard.DragEnter += GridBoard_DragEnter;
            gridBoard.DragDrop += GridBoard_DragDrop;
        }

        private void CreateGuestEvent(object sender, EventArgs e)
        {
            var newEmployee = CreateEmployee();
            createdEmployees.Add(newEmployee);

            var newPanel = new EmployeePanel(newEmployee)
            {
                Width = AppConstants.emp_width,
                Height = AppConstants.CellSize_height,
                BackColor = Color.LightBlue,
                Margin = new Padding(AppConstants.Xmargin, AppConstants.Ymargin, 0, 0)
            };

            for (int r = 0; r < gridBoard.RowCount; r++)
            {
                if (gridBoard.GetControlFromPosition(0, r) == null)
                {
                    gridBoard.Controls.Add(newPanel, 0, r);
                    return;
                }
            }

            MessageBox.Show("全てのグリッドセルが埋まっています。");
        }

        private int GetNextEmployeeId()
        {
            var all = homeForm.GetEmployees().Concat(createdEmployees);
            if (!all.Any()) return 10000;
            return all.Max(emp => emp.Id) + 1;
        }


        private EmployeeModel CreateEmployee()
        {
            employeeId = GetNextEmployeeId();

            TimeSpan inTime = TimeSpan.FromHours(10);
            TimeSpan outTime = TimeSpan.FromHours(17);
            TimeSpan workSum = outTime - inTime;
            TimeSpan restSum = TimeSpan.FromMinutes(60);

            return new EmployeeModel(
                employeeId,
                "Employee" + employeeId,
                workSum,
                1,
                inTime,
                outTime,
                restSum,
                ""
            );
        }

        private void GridBoard_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(typeof(EmployeePanel)) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void GridBoard_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(EmployeePanel)) is not EmployeePanel draggedPanel) return;

            Point clientPoint = gridBoard.PointToClient(new Point(e.X, e.Y));
            int dropRow = clientPoint.Y / AppConstants.CellSize_height;

            if (dropRow < 0 || dropRow >= gridBoard.RowCount) return;

            int dropCol = 0;
            Control existing = gridBoard.GetControlFromPosition(dropCol, dropRow);

            if (existing != null && existing != draggedPanel)
            {
                var existingPanel = existing as EmployeePanel;
                var original = gridBoard.GetCellPosition(draggedPanel);

                gridBoard.Controls.Remove(draggedPanel);
                gridBoard.Controls.Remove(existingPanel);

                gridBoard.Controls.Add(existingPanel, original.Column, original.Row);
                gridBoard.Controls.Add(draggedPanel, dropCol, dropRow);
            }
            else
            {
                gridBoard.Controls.Remove(draggedPanel);
                gridBoard.Controls.Add(draggedPanel, dropCol, dropRow);
            }

            gridBoard.Invalidate();
        }

        private void Confirmed_Click(object sender, EventArgs e)
        {
            foreach (var emp in createdEmployees)
            {
                homeForm.AddEmployee(emp);
            }

            homeForm.DisplayEmployees();
            createdEmployees.Clear();

            MessageBox.Show("全従業員を Home に登録しました。");
        }

        private void gridBoard_Paint(object sender, PaintEventArgs e) { }

        public class EmployeePanel : Panel
        {
            private readonly EmployeeModel employee;

            public EmployeeModel EmployeeData => employee;

            public EmployeePanel(EmployeeModel employee)
            {
                this.employee = employee;
                this.DoubleBuffered = true;

                Controls.Add(new Label
                {
                    Text = $"{employee.Id}: {employee.Name}",
                    AutoSize = true,
                    Location = new Point(5, 5)
                });

                this.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        this.BringToFront();
                        this.DoDragDrop(this, DragDropEffects.Move);
                    }
                };
            }
        }
    }

    public static class AppConstants
    {
        public const int Xmargin = 5;
        public const int Ymargin = 5;
        public const int CellSize_height = 60;
        public const int emp_width = 1000;
    }
}
