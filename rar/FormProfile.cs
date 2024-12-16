using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace rar
{
    public partial class FormProfile : Form
    {
        private OleDbConnection connection;
        private string currentUser;

        public FormProfile(OleDbConnection conn, string username)
        {
            InitializeComponent();
            connection = conn;
            currentUser = username;

            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                connection.Open();
                string query = "SELECT [Login], [Admin] FROM Users WHERE [Login] = @login";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", currentUser);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            labelUsername.Text = $"Логин: {reader["Login"]}";
                            string role = Convert.ToInt32(reader["Admin"]) == 1 ? "Администратор" : "Пользователь";
                            labelRole.Text = $"Роль: {role}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки профиля: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
