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
    public partial class DBte_buru : Form
    {
        public DBte_buru()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tableName = "Employees";
            string filePath = "EmployeesData.sql";
            TableExporter.ExportToSql(tableName, filePath);
            MessageBox.Show("SQLファイルを書き出しました: " + filePath);
        }
    }
}
