using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace rar
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\михан\Desktop\rar\rar\logins.accdb;";


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Admin FROM Users WHERE [Login] = @login AND [Password] = @pass";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@pass", password);
                        object result = cmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("Неверный логин или пароль.");
                            return;
                        }

                        int isAdmin = Convert.ToInt32(result);

                        if (isAdmin == 1)
                        {
                            Form4 adminForm = new Form4(conn, login);
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form3 userForm = new Form3(conn, login);
                            userForm.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}");
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();
            registerForm.ShowDialog();
        }
    }
}
