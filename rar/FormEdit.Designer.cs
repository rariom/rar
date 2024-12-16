namespace rar
{
    partial class FormEdit
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
            // 
            // textBoxPunktOtkuda
            // 
            this.textBoxPunktOtkuda.Location = new System.Drawing.Point(120, 60);
            this.textBoxPunktOtkuda.Name = "textBoxPunktOtkuda";
            this.textBoxPunktOtkuda.Size = new System.Drawing.Size(100, 20);
            this.textBoxPunktOtkuda.TabIndex = 3;
            // 
            // textBoxPunktKuda
            // 
            this.textBoxPunktKuda.Location = new System.Drawing.Point(120, 100);
            this.textBoxPunktKuda.Name = "textBoxPunktKuda";
            this.textBoxPunktKuda.Size = new System.Drawing.Size(100, 20);
            this.textBoxPunktKuda.TabIndex = 5;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(120, 20);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerData.TabIndex = 1;
            // 
            // comboBoxTipGruzovika
            // 
            this.comboBoxTipGruzovika.Location = new System.Drawing.Point(120, 140);
            this.comboBoxTipGruzovika.Name = "comboBoxTipGruzovika";
            this.comboBoxTipGruzovika.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipGruzovika.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(20, 180);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Откуда:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Куда:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип грузовика:";
            // 
            // FormEdit
            // 
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
            this.Name = "FormEdit";
            this.Text = "Редактировать маршрут";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
