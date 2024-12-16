using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace rar
{
    public partial class Form4 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\михан\Desktop\rar\rar\logins.accdb;";
        private string currentUser;

        public Form4(OleDbConnection conn, string username)
        {
            InitializeComponent();
            currentUser = username;
            LoadDataInternal();
        }

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
                        dataGridViewAdmin.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormAdd formAdd = new FormAdd(new OleDbConnection(connectionString)))
            {
                formAdd.ShowDialog();
            }
            LoadDataInternal();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для редактирования.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewAdmin.SelectedRows[0].Cells["ID"].Value);
            string punktOtkuda = dataGridViewAdmin.SelectedRows[0].Cells["PunktOtkuda"].Value.ToString();
            string punktKuda = dataGridViewAdmin.SelectedRows[0].Cells["PunktKuda"].Value.ToString();
            DateTime data = Convert.ToDateTime(dataGridViewAdmin.SelectedRows[0].Cells["Data"].Value);
            string tipGruzovika = dataGridViewAdmin.SelectedRows[0].Cells["NazvanieTipa"].Value.ToString();

            using (FormEdit formEdit = new FormEdit(new OleDbConnection(connectionString), id, data, punktOtkuda, punktKuda, tipGruzovika))
            {
                formEdit.ShowDialog();
            }
            LoadDataInternal();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            using (FormProfile profileForm = new FormProfile(new OleDbConnection(connectionString), currentUser))
            {
                profileForm.ShowDialog();
            }
        }
    }
}
