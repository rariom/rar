namespace rar
{
    partial class FormProfile
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Button buttonClose;

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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(20, 20);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(80, 20);
            this.labelUsername.Text = "Логин:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(20, 50);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(80, 20);
            this.labelRole.Text = "Роль:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(20, 90);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormProfile
            // 
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormProfile";
            this.Text = "Профиль";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
