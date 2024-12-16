using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace rar
{
    public partial class FormEdit : Form
    {
        private OleDbConnection connection;
        private int recordId;

        public FormEdit(OleDbConnection conn, int id, DateTime data, string punktOtkuda, string punktKuda, string selectedType)
        {
            InitializeComponent();
            connection = conn;
            recordId = id;

            textBoxPunktOtkuda.Text = punktOtkuda;
            textBoxPunktKuda.Text = punktKuda;
            dateTimePickerData.Value = data;

            LoadComboBox(selectedType);
        }

        private void LoadComboBox(string selectedType)
        {
            var truckTypes = new[]
            {
                new { Text = "Седельный тягач", Value = 1 },
                new { Text = "Бортовой грузовик", Value = 2 },
                new { Text = "Фургон", Value = 3 },
                new { Text = "Самосвал", Value = 4 },
                new { Text = "Цистерна", Value = 5 },
                new { Text = "Рефрижератор", Value = 6 },
                new { Text = "Платформа", Value = 7 }
            };

            comboBoxTipGruzovika.Items.Clear();
            comboBoxTipGruzovika.DisplayMember = "Text";
            comboBoxTipGruzovika.ValueMember = "Value";

            foreach (var truck in truckTypes)
            {
                comboBoxTipGruzovika.Items.Add(truck);
            }

            foreach (var item in comboBoxTipGruzovika.Items)
            {
                if (((dynamic)item).Text == selectedType)
                {
                    comboBoxTipGruzovika.SelectedItem = item;
                    break;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Marshruty SET Data = @data, PunktOtkuda = @punktOtkuda, " +
                               "PunktKuda = @punktKuda, TipGruzovikaID = @tipID WHERE ID = @id";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@data", dateTimePickerData.Value);
                    cmd.Parameters.AddWithValue("@punktOtkuda", textBoxPunktOtkuda.Text);
                    cmd.Parameters.AddWithValue("@punktKuda", textBoxPunktKuda.Text);
                    cmd.Parameters.AddWithValue("@tipID", ((dynamic)comboBoxTipGruzovika.SelectedItem).Value);
                    cmd.Parameters.AddWithValue("@id", recordId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно обновлена!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
