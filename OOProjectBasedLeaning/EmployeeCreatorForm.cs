using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOProjectBasedLeaning
{
    public partial class EmployeeCreatorForm : DragDropForm
    {
        private Panel kokubanPanel;
        private Label kokubanTitleLabel;
        private int employeeId = 10000;

        public EmployeeCreatorForm()
        {
            InitializeComponent();
            this.AllowDrop = false;
            InitializeKokuban();
        }

        private void InitializeKokuban()
        {
            kokubanPanel = new Panel
            {
                Location = new Point(100, 10),
                Size = new Size(600, 600),
                BackColor = Color.Black,
                AllowDrop = true
            };

            kokubanPanel.DragEnter += Kokuban_DragEnter;
            kokubanPanel.DragDrop += Kokuban_DragDrop;

            kokubanTitleLabel = new Label
            {
                Text = "こくばん",
                ForeColor = Color.White,
                Location = new Point(10, 10),
                AutoSize = true
            };

            kokubanPanel.Controls.Add(kokubanTitleLabel);
            Controls.Add(kokubanPanel);
            kokubanPanel.BringToFront();
        }

        private void Kokuban_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy
                : DragDropEffects.None;
        }

        private void Kokuban_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                MessageBox.Show($"ドロップされたファイル数: {files.Length}", "こくばん");
            }
        }

        private void CreateGuestEvent(object sender, EventArgs e)
        {
            int employeePanelCount = kokubanPanel.Controls.OfType<EmployeePanel>().Count();
            int gap = 10;
            int panelHeight = 50;
            int startY = kokubanTitleLabel.Bottom + gap;
            int panelY = startY + (panelHeight + gap) * employeePanelCount;

            var newEmployee = CreateEmployee();

            EmployeePanel newEmployeePanel = new EmployeePanel(newEmployee)
            {
                Location = new Point(10, panelY),
                Width = kokubanPanel.Width - 20,
                Height = panelHeight,
                BackColor = Color.LightBlue
            };

            kokubanPanel.Controls.Add(newEmployeePanel);
            newEmployeePanel.BringToFront();
        }

        private EmployeeModel CreateEmployee()
        {
            employeeId++;
            return new EmployeeModel(employeeId, "Employee" + employeeId);
        }

        protected override void OnFormDragEnterSerializable(DragEventArgs dragEventArgs)
        {
            dragEventArgs.Effect = DragDropEffects.None;
        }

        protected override void OnFormDragDropSerializable(object? serializableObject, DragEventArgs dragEventArgs)
        {
        }

        // === ネストされた EmployeePanel クラス ===
        public class EmployeePanel : Panel
        {
            private bool dragging = false;
            private Point dragStart;
            private readonly EmployeeModel employee;

            public EmployeePanel(EmployeeModel employee)
            {
                this.employee = employee;

                Label label = new Label
                {
                    Text = $"{employee.Id}: {employee.Name}",
                    AutoSize = true,
                    Location = new Point(5, 5)
                };

                Controls.Add(label);

                this.MouseDown += EmployeePanel_MouseDown;
                this.MouseMove += EmployeePanel_MouseMove;
                this.MouseUp += EmployeePanel_MouseUp;
            }

            private void EmployeePanel_MouseDown(object sender, MouseEventArgs e)
            {
                dragging = true;
                dragStart = e.Location;
                this.BringToFront();
            }

            private void EmployeePanel_MouseMove(object sender, MouseEventArgs e)
            {
                if (dragging)
                {
                    this.Left += e.X - dragStart.X;
                    this.Top += e.Y - dragStart.Y;
                }
            }

            private void EmployeePanel_MouseUp(object sender, MouseEventArgs e)
            {
                dragging = false;
            }
        }
    }
}