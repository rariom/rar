namespace rar
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLogout;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Size = new System.Drawing.Size(760, 350);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 380);
            this.buttonRefresh.Size = new System.Drawing.Size(100, 30);
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.Click += new System.EventHandler(this.LoadData);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(150, 380);
            this.buttonProfile.Size = new System.Drawing.Size(100, 30);
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(280, 380);
            this.buttonLogout.Size = new System.Drawing.Size(100, 30);
            this.buttonLogout.Text = "Выход";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonLogout);
            this.Text = "Пользователь";
            this.ResumeLayout(false);
        }
    }
}
