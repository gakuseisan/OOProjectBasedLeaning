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
        private HomeForm _homeForm;
        public EmployeeModel selectedEmployee; // 選択された従業員を保持するフィールド

        public ChangeForm(HomeForm homeForm)
        {
            InitializeComponent();
            _homeForm = homeForm;

            // ListView の列設定をここで行うのが良いでしょう。
            // Designer.cs で設定されている場合でも、明示的に設定することで意図が明確になります。
            listBoxEmployees.View = View.Details;
            listBoxEmployees.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listBoxEmployees.Columns.Add("氏名", 200, HorizontalAlignment.Left);

            InitializeEmployeeList();
        }

        private void InitializeEmployeeList()
        {
            listBoxEmployees.Items.Clear();

            foreach (var emp in _homeForm.GetEmployees())
            {
                ListViewItem lvi = new ListViewItem(emp.Id.ToString());
                lvi.SubItems.Add(emp.Name);
                lvi.Tag = emp; // ここで EmployeeModel オブジェクト自体を Tag に保存する
                listBoxEmployees.Items.Add(lvi);
            }
        }

        // ListView の選択が変更されたときのイベントハンドラ
        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItems.Count > 0)
            {
                // 選択された最初のアイテムを取得
                ListViewItem selectedItem = listBoxEmployees.SelectedItems[0];
                // Tag に保存しておいた EmployeeModel オブジェクトを取得
                selectedEmployee = selectedItem.Tag as EmployeeModel;

                if (selectedEmployee != null)
                {
                    // 選択された従業員の名前をテキストボックスに表示
                    textBoxEmployeeName.Text = selectedEmployee.Name;
                }
            }
            else
            {
                // 何も選択されていない場合はテキストボックスをクリア
                textBoxEmployeeName.Text = string.Empty;
                selectedEmployee = null;
            }
        }

        // 「名前を確定」ボタンがクリックされたときのイベントハンドラ
        private void btnConfirmChange_Click(object sender, EventArgs e)
        {
            if (selectedEmployee != null)
            {
                // テキストボックスの新しい名前を取得
                string newName = textBoxEmployeeName.Text.Trim();

                if (!string.IsNullOrEmpty(newName))
                {
                    // --- ここを追記/修正 ---
                    // HomeFormの従業員リストを更新
                    _homeForm.UpdateEmployeeName(selectedEmployee.Id, newName);
                    // --- ここまで追記/修正 ---

                    // ListViewの表示を更新
                    InitializeEmployeeList();

                    // テキストボックスをクリア
                    textBoxEmployeeName.Text = string.Empty;
                    selectedEmployee = null; // 選択状態をリセット

                    MessageBox.Show("名前が変更されました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("新しい名前を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("変更する従業員を選択してください。", "選択エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}