using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace rar
{
    public partial class FormAdd : Form
    {
        private OleDbConnection connection;

        public FormAdd(OleDbConnection conn)
        {
            InitializeComponent();
            connection = conn;
            LoadComboBox();
        }

        // Заполняем ComboBox типами грузовиков
        private void LoadComboBox()
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

            // Устанавливаем первый элемент по умолчанию
            if (comboBoxTipGruzovika.Items.Count > 0)
                comboBoxTipGruzovika.SelectedIndex = 0;
        }

        // Сохранение новой записи
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Проверка заполнения полей
            if (string.IsNullOrWhiteSpace(textBoxPunktOtkuda.Text) ||
                string.IsNullOrWhiteSpace(textBoxPunktKuda.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                // SQL-запрос на добавление новой записи
                string query = "INSERT INTO Marshruty (Data, PunktOtkuda, PunktKuda, TipGruzovikaID) " +
                               "VALUES (@data, @punktOtkuda, @punktKuda, @tipID)";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    connection.Open();

                    // Приведение параметров к правильным типам данных
                    cmd.Parameters.Add("@data", OleDbType.Date).Value = dateTimePickerData.Value;
                    cmd.Parameters.Add("@punktOtkuda", OleDbType.VarChar).Value = textBoxPunktOtkuda.Text;
                    cmd.Parameters.Add("@punktKuda", OleDbType.VarChar).Value = textBoxPunktKuda.Text;
                    cmd.Parameters.Add("@tipID", OleDbType.Integer).Value = ((dynamic)comboBoxTipGruzovika.SelectedItem).Value;

                    // Выполнение запроса
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Маршрут успешно добавлен!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
