
namespace DoAnTH
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTk = new System.Windows.Forms.TextBox();
            this.btnTaiKhoan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTenHienThi = new System.Windows.Forms.Label();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.btnMK = new System.Windows.Forms.Label();
            this.txbMK = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTk);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 50);
            this.panel1.TabIndex = 0;
            // 
            // txbTk
            // 
            this.txbTk.Location = new System.Drawing.Point(125, 11);
            this.txbTk.Name = "txbTk";
            this.txbTk.ReadOnly = true;
            this.txbTk.Size = new System.Drawing.Size(180, 28);
            this.txbTk.TabIndex = 0;
            this.txbTk.TextChanged += new System.EventHandler(this.txbTk_TextChanged);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.AutoSize = true;
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTaiKhoan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Location = new System.Drawing.Point(10, 14);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(84, 21);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "Tài Khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTenHienThi);
            this.panel2.Controls.Add(this.txtTenHienThi);
            this.panel2.Location = new System.Drawing.Point(12, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnTenHienThi
            // 
            this.btnTenHienThi.AutoSize = true;
            this.btnTenHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTenHienThi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenHienThi.Location = new System.Drawing.Point(10, 14);
            this.btnTenHienThi.Name = "btnTenHienThi";
            this.btnTenHienThi.Size = new System.Drawing.Size(104, 21);
            this.btnTenHienThi.TabIndex = 2;
            this.btnTenHienThi.Text = "Tên Hiển Thị";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(125, 13);
            this.txtTenHienThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.ReadOnly = true;
            this.txtTenHienThi.Size = new System.Drawing.Size(180, 28);
            this.txtTenHienThi.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbHienMK);
            this.panel3.Controls.Add(this.btnMK);
            this.panel3.Controls.Add(this.txbMK);
            this.panel3.Location = new System.Drawing.Point(12, 189);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 83);
            this.panel3.TabIndex = 2;
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(125, 55);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(139, 25);
            this.cbHienMK.TabIndex = 1;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            this.cbHienMK.Click += new System.EventHandler(this.cbHienMK_Click);
            this.cbHienMK.MouseHover += new System.EventHandler(this.cbHienMK_MouseHover);
            // 
            // btnMK
            // 
            this.btnMK.AutoSize = true;
            this.btnMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMK.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMK.Location = new System.Drawing.Point(10, 14);
            this.btnMK.Name = "btnMK";
            this.btnMK.Size = new System.Drawing.Size(80, 21);
            this.btnMK.TabIndex = 2;
            this.btnMK.Text = "Mật Khẩu";
            // 
            // txbMK
            // 
            this.txbMK.Location = new System.Drawing.Point(125, 13);
            this.txbMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMK.Name = "txbMK";
            this.txbMK.ReadOnly = true;
            this.txbMK.Size = new System.Drawing.Size(180, 28);
            this.txbMK.TabIndex = 0;
            this.txbMK.UseSystemPasswordChar = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Image = global::DoAnTH.Properties.Resources.Button_Close_icon2;
            this.btnThoat.Location = new System.Drawing.Point(211, 280);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 43);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(350, 358);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Cá Nhân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Account_FormClosing);
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnTenHienThi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label btnMK;
        private System.Windows.Forms.TextBox txbMK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.TextBox txbTk;
        private System.Windows.Forms.CheckBox cbHienMK;
    }
}