using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOProjectBasedLeaning
{
    public class TableExporter
    {
        public static void ExportToSql(string tableName, string filePath)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OOProjectBasedLeaning;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {tableName}", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    while (reader.Read())
                    {
                        string[] values = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            object val = reader.GetValue(i);
                            values[i] = val is string || val is DateTime
                                ? $"'{val.ToString().Replace("'", "''")}'"
                                : val.ToString();
                        }
                        string insert = $"INSERT INTO {tableName} VALUES ({string.Join(", ", values)});";
                        writer.WriteLine(insert);
                    }
                }
            }
        }

        public static void ExportToCsv(string tableName, string filePath)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OOProjectBasedLeaning;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM {tableName}", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Header
                    string[] headers = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                        headers[i] = reader.GetName(i);
                    writer.WriteLine(string.Join(",", headers));

                    // Rows
                    while (reader.Read())
                    {
                        string[] values = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                            values[i] = reader[i].ToString().Replace(",", ""); // CSVのカンマ対策
                        writer.WriteLine(string.Join(",", values));
                    }
                }
            }
        }
        private void btnExportSql_Click(object sender, EventArgs e)
        {
            string tableName = "Employees";
            string filePath = "EmployeesData.sql";
            TableExporter.ExportToSql(tableName, filePath);
            MessageBox.Show("SQLファイルを書き出しました: " + filePath);
        }
    }
}
