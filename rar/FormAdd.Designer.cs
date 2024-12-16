namespace rar
{
    partial class FormAdd
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxPunktOtkuda;
        private System.Windows.Forms.TextBox textBoxPunktKuda;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.ComboBox comboBoxTipGruzovika;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1, label2, label3, label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxPunktOtkuda = new System.Windows.Forms.TextBox();
            this.textBoxPunktKuda = new System.Windows.Forms.TextBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipGruzovika = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Labels and Controls for Form
            this.label1.Text = "Дата:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.dateTimePickerData.Location = new System.Drawing.Point(120, 20);

            this.label2.Text = "Откуда:";
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.textBoxPunktOtkuda.Location = new System.Drawing.Point(120, 60);

            this.label3.Text = "Куда:";
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.textBoxPunktKuda.Location = new System.Drawing.Point(120, 100);

            this.label4.Text = "Тип грузовика:";
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.comboBoxTipGruzovika.Location = new System.Drawing.Point(120, 140);
            this.comboBoxTipGruzovika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Location = new System.Drawing.Point(20, 180);
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // FormAdd
            this.ClientSize = new System.Drawing.Size(300, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPunktOtkuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPunktKuda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTipGruzovika);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormAdd";
            this.Text = "Добавить маршрут";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
