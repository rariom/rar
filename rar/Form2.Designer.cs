namespace rar
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAdmin; // Чекбокс для выбора роли администратора

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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox(); // Инициализация чекбокса
            this.SuspendLayout();

            // label1 (Логин)
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Text = "Логин:";

            // textBoxLogin
            this.textBoxLogin.Location = new System.Drawing.Point(100, 20);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);

            // label2 (Пароль)
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Text = "Пароль:";

            // textBoxPassword
            this.textBoxPassword.Location = new System.Drawing.Point(100, 60);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);

            // checkBoxAdmin
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(100, 100);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(120, 20);
            this.checkBoxAdmin.TabIndex = 3;
            this.checkBoxAdmin.Text = "Администратор";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;

            // buttonRegister
            this.buttonRegister.Location = new System.Drawing.Point(20, 140);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(150, 30);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);

            // Form2
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxAdmin); // Добавляем чекбокс на форму
            this.Controls.Add(this.buttonRegister);
            this.Name = "Form2";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
