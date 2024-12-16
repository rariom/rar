namespace rar
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonProfile;

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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();

            // dataGridViewAdmin
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAdmin.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";

            // buttonRefresh
            this.buttonRefresh.Location = new System.Drawing.Point(12, 380);
            this.buttonRefresh.Size = new System.Drawing.Size(100, 30);
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.Click += new System.EventHandler(this.LoadData);

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(130, 380);
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // buttonEdit
            this.buttonEdit.Location = new System.Drawing.Point(250, 380);
            this.buttonEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);

            // buttonProfile
            this.buttonProfile.Location = new System.Drawing.Point(370, 380);
            this.buttonProfile.Size = new System.Drawing.Size(100, 30);
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);

            // Form4
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonProfile);
            this.Name = "Form4";
            this.Text = "Администратор";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
