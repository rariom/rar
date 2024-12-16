using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace rar
{
    public partial class Form3 : Form
    {
        private string connectionString; // Строка подключения
        private string currentUser;      // Текущий пользователь

        public Form3(OleDbConnection conn, string username)
        {
            InitializeComponent();
            connectionString = conn.ConnectionString;
            currentUser = username;

            LoadDataInternal();
        }

        // Метод для обновления данных
        private void LoadData(object sender, EventArgs e)
        {
            LoadDataInternal();
        }

        private void LoadDataInternal()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Marshruty.ID, Marshruty.Data, Marshruty.PunktOtkuda, 
                                            Marshruty.PunktKuda, 
                                            IIF(TipiGruzovikov.NazvanieTipa IS NULL, 'Не указан', TipiGruzovikov.NazvanieTipa) AS NazvanieTipa
                                     FROM Marshruty
                                     LEFT JOIN TipiGruzovikov ON Marshruty.TipGruzovikaID = TipiGruzovikov.ID";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            using (FormProfile profileForm = new FormProfile(new OleDbConnection(connectionString), currentUser))
            {
                profileForm.ShowDialog();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
