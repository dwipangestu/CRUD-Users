namespace InventoryToko
{
    partial class ManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseTb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.FullNameTxt = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.NamaLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.TeleponLabel = new System.Windows.Forms.Label();
            this.TelephoneTxt = new System.Windows.Forms.TextBox();
            this.AddBt = new System.Windows.Forms.Button();
            this.EditBt = new System.Windows.Forms.Button();
            this.DelBt = new System.Windows.Forms.Button();
            this.HomeBt = new System.Windows.Forms.Button();
            this.UsersGv = new System.Windows.Forms.DataGridView();
            this.clearBt = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdUserTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CloseTb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(224, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Barang Toko";
            // 
            // CloseTb
            // 
            this.CloseTb.BackColor = System.Drawing.Color.Crimson;
            this.CloseTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseTb.FlatAppearance.BorderSize = 0;
            this.CloseTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseTb.ForeColor = System.Drawing.SystemColors.Info;
            this.CloseTb.Location = new System.Drawing.Point(728, 12);
            this.CloseTb.Name = "CloseTb";
            this.CloseTb.Size = new System.Drawing.Size(52, 33);
            this.CloseTb.TabIndex = 14;
            this.CloseTb.Text = "X";
            this.CloseTb.UseVisualStyleBackColor = false;
            this.CloseTb.Click += new System.EventHandler(this.CloseTb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(10, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen User";
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BackColor = System.Drawing.Color.White;
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UserNameTxt.Location = new System.Drawing.Point(16, 240);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(179, 25);
            this.UserNameTxt.TabIndex = 1;
            // 
            // FullNameTxt
            // 
            this.FullNameTxt.BackColor = System.Drawing.Color.White;
            this.FullNameTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FullNameTxt.Location = new System.Drawing.Point(16, 292);
            this.FullNameTxt.Name = "FullNameTxt";
            this.FullNameTxt.Size = new System.Drawing.Size(179, 25);
            this.FullNameTxt.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 216);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 21);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // NamaLabel
            // 
            this.NamaLabel.AutoSize = true;
            this.NamaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLabel.Location = new System.Drawing.Point(12, 268);
            this.NamaLabel.Name = "NamaLabel";
            this.NamaLabel.Size = new System.Drawing.Size(123, 21);
            this.NamaLabel.TabIndex = 4;
            this.NamaLabel.Text = "Nama Panjang";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 320);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 21);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.White;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordTxt.Location = new System.Drawing.Point(16, 344);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(179, 25);
            this.PasswordTxt.TabIndex = 5;
            // 
            // TeleponLabel
            // 
            this.TeleponLabel.AutoSize = true;
            this.TeleponLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleponLabel.Location = new System.Drawing.Point(12, 374);
            this.TeleponLabel.Name = "TeleponLabel";
            this.TeleponLabel.Size = new System.Drawing.Size(98, 21);
            this.TeleponLabel.TabIndex = 8;
            this.TeleponLabel.Text = "No Telepon";
            // 
            // TelephoneTxt
            // 
            this.TelephoneTxt.BackColor = System.Drawing.Color.White;
            this.TelephoneTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TelephoneTxt.Location = new System.Drawing.Point(16, 398);
            this.TelephoneTxt.Name = "TelephoneTxt";
            this.TelephoneTxt.Size = new System.Drawing.Size(179, 25);
            this.TelephoneTxt.TabIndex = 7;
            // 
            // AddBt
            // 
            this.AddBt.BackColor = System.Drawing.Color.LimeGreen;
            this.AddBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBt.FlatAppearance.BorderSize = 0;
            this.AddBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBt.ForeColor = System.Drawing.SystemColors.Info;
            this.AddBt.Location = new System.Drawing.Point(16, 478);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(83, 23);
            this.AddBt.TabIndex = 9;
            this.AddBt.Text = "Tambah";
            this.AddBt.UseVisualStyleBackColor = false;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // EditBt
            // 
            this.EditBt.BackColor = System.Drawing.Color.Olive;
            this.EditBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBt.FlatAppearance.BorderSize = 0;
            this.EditBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBt.ForeColor = System.Drawing.SystemColors.Info;
            this.EditBt.Location = new System.Drawing.Point(16, 507);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(83, 23);
            this.EditBt.TabIndex = 10;
            this.EditBt.Text = "Ubah";
            this.EditBt.UseVisualStyleBackColor = false;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // DelBt
            // 
            this.DelBt.BackColor = System.Drawing.Color.Red;
            this.DelBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBt.FlatAppearance.BorderSize = 0;
            this.DelBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBt.ForeColor = System.Drawing.SystemColors.Info;
            this.DelBt.Location = new System.Drawing.Point(112, 507);
            this.DelBt.Name = "DelBt";
            this.DelBt.Size = new System.Drawing.Size(83, 23);
            this.DelBt.TabIndex = 11;
            this.DelBt.Text = "Hapus";
            this.DelBt.UseVisualStyleBackColor = false;
            this.DelBt.Click += new System.EventHandler(this.DelBt_Click);
            // 
            // HomeBt
            // 
            this.HomeBt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HomeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBt.FlatAppearance.BorderSize = 0;
            this.HomeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBt.ForeColor = System.Drawing.SystemColors.Info;
            this.HomeBt.Location = new System.Drawing.Point(16, 439);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(179, 33);
            this.HomeBt.TabIndex = 12;
            this.HomeBt.Text = "Beranda";
            this.HomeBt.UseVisualStyleBackColor = false;
            // 
            // UsersGv
            // 
            this.UsersGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UsersGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsersGv.Location = new System.Drawing.Point(257, 165);
            this.UsersGv.Name = "UsersGv";
            this.UsersGv.RowHeadersWidth = 50;
            this.UsersGv.RowTemplate.Height = 30;
            this.UsersGv.Size = new System.Drawing.Size(508, 397);
            this.UsersGv.TabIndex = 13;
            this.UsersGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGv_CellContentClick);
            // 
            // clearBt
            // 
            this.clearBt.BackColor = System.Drawing.Color.Firebrick;
            this.clearBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBt.FlatAppearance.BorderSize = 0;
            this.clearBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBt.ForeColor = System.Drawing.SystemColors.Info;
            this.clearBt.Location = new System.Drawing.Point(112, 478);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(83, 23);
            this.clearBt.TabIndex = 15;
            this.clearBt.Text = "Bersihkan";
            this.clearBt.UseVisualStyleBackColor = false;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.LimeGreen;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.Info;
            this.refresh.Location = new System.Drawing.Point(682, 113);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(83, 23);
            this.refresh.TabIndex = 16;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID User";
            // 
            // IdUserTxt
            // 
            this.IdUserTxt.BackColor = System.Drawing.Color.White;
            this.IdUserTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUserTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.IdUserTxt.Location = new System.Drawing.Point(16, 189);
            this.IdUserTxt.Name = "IdUserTxt";
            this.IdUserTxt.Size = new System.Drawing.Size(179, 25);
            this.IdUserTxt.TabIndex = 17;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdUserTxt);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersGv);
            this.Controls.Add(this.HomeBt);
            this.Controls.Add(this.DelBt);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.TeleponLabel);
            this.Controls.Add(this.TelephoneTxt);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.NamaLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.FullNameTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ManageUsers_Load(object sender, System.EventArgs e)
        {
            populate();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox FullNameTxt;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label NamaLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label TeleponLabel;
        private System.Windows.Forms.TextBox TelephoneTxt;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.Button DelBt;
        private System.Windows.Forms.Button HomeBt;
        private System.Windows.Forms.DataGridView UsersGv;
        private System.Windows.Forms.Button CloseTb;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdUserTxt;
    }
}