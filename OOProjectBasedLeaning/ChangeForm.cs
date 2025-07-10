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
    public partial class ChangeForm : Form
    {
        private HomeForm _homeForm; // HomeForm のインスタンスを保持するフィールド

        // HomeForm のインスタンスを受け取るコンストラクタ
        public ChangeForm(HomeForm homeForm)
        {
            InitializeComponent();
            _homeForm = homeForm; // 渡された HomeForm のインスタンスを保存

            listBoxEmployees.View = View.Details;
            listBoxEmployees.Columns.Add("ID", 150, HorizontalAlignment.Left); // ID列
            listBoxEmployees.Columns.Add("氏名", 250, HorizontalAlignment.Left); // 氏名列

            // HomeForm から従業員リストを取得して表示
            InitializeEmployeeList();
        }

        private void InitializeEmployeeList()
        {
            listBoxEmployees.Items.Clear(); // 既存のアイテムをクリア

            foreach (var emp in _homeForm.GetEmployees())
            {
                // ListViewItem を作成し、各サブアイテムを追加
                ListViewItem lvi = new ListViewItem(emp.Id.ToString()); // 最初の列 (ID)
                lvi.SubItems.Add(emp.Name); // 2番目の列 (氏名)

                listBoxEmployees.Items.Add(lvi); // ListView にアイテムを追加
            }
        }

        private void btnConfirmChange_Click(object sender, EventArgs e)
        {

        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}