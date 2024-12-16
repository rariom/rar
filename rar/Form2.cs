using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace rar
{
    public partial class Form2 : Form
    {
        private string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\михан\Desktop\rar\rar\logins.accdb;Persist Security Info=True;Mode=Share Deny None;";

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            bool isAdmin = checkBoxAdmin.Checked; // Считываем значение чекбокса

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE [Login] = @login";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@login", login);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Такой логин уже существует.");
                        return;
                    }
                }

                string insertQuery = "INSERT INTO Users ([Login], [Password], [Admin]) VALUES (@login, @password, @isAdmin)";
                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@login", login);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.Parameters.AddWithValue("@isAdmin", isAdmin ? 1 : 0); // Устанавливаем 1, если администратор, иначе 0
                    insertCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Регистрация успешна.");
                this.Close();
            }
        }
    }
}
