
namespace DoAnTH
{
    partial class QLBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBan));
            this.label6 = new System.Windows.Forms.Label();
            this.TGCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvBanAn = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtNgayCN = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnLuuBA = new System.Windows.Forms.Button();
            this.btnSuaBA = new System.Windows.Forms.Button();
            this.btnThoatBA = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(347, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 49);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quản  Lý Bàn";
            // 
            // TGCapNhat
            // 
            this.TGCapNhat.HeaderText = "Thời Gian Cập Nhật";
            this.TGCapNhat.MinimumWidth = 6;
            this.TGCapNhat.Name = "TGCapNhat";
            this.TGCapNhat.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 110;
            // 
            // IDBan
            // 
            this.IDBan.HeaderText = "Số Bàn";
            this.IDBan.MinimumWidth = 6;
            this.IDBan.Name = "IDBan";
            this.IDBan.Width = 110;
            // 
            // dtgvBanAn
            // 
            this.dtgvBanAn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBan,
            this.TrangThai,
            this.TGCapNhat});
            this.dtgvBanAn.Location = new System.Drawing.Point(188, 78);
            this.dtgvBanAn.Name = "dtgvBanAn";
            this.dtgvBanAn.RowHeadersWidth = 51;
            this.dtgvBanAn.RowTemplate.Height = 24;
            this.dtgvBanAn.Size = new System.Drawing.Size(547, 411);
            this.dtgvBanAn.TabIndex = 3;
            this.dtgvBanAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBanAn_CellClick);
            this.dtgvBanAn.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBanAn_CellEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label5.Location = new System.Drawing.Point(22, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Bàn";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txtID.Location = new System.Drawing.Point(127, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 28);
            this.txtID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày C.Nhật";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label5);
            this.panel17.Controls.Add(this.txtID);
            this.panel17.Location = new System.Drawing.Point(3, 29);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(356, 38);
            this.panel17.TabIndex = 0;
            // 
            // txtNgayCN
            // 
            this.txtNgayCN.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txtNgayCN.Location = new System.Drawing.Point(130, 6);
            this.txtNgayCN.Name = "txtNgayCN";
            this.txtNgayCN.Size = new System.Drawing.Size(229, 28);
            this.txtNgayCN.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.txtNgayCN);
            this.panel13.Location = new System.Drawing.Point(3, 142);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(369, 38);
            this.panel13.TabIndex = 2;
            // 
            // btnLuuBA
            // 
            this.btnLuuBA.BackColor = System.Drawing.Color.Lime;
            this.btnLuuBA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuBA.Image = global::DoAnTH.Properties.Resources.Save_icon;
            this.btnLuuBA.Location = new System.Drawing.Point(189, 26);
            this.btnLuuBA.Name = "btnLuuBA";
            this.btnLuuBA.Size = new System.Drawing.Size(127, 52);
            this.btnLuuBA.TabIndex = 1;
            this.btnLuuBA.Text = "Lưu";
            this.btnLuuBA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuBA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuBA.UseVisualStyleBackColor = false;
            this.btnLuuBA.Click += new System.EventHandler(this.btnLuuBA_Click);
            // 
            // btnSuaBA
            // 
            this.btnSuaBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaBA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBA.Image = global::DoAnTH.Properties.Resources.Repair_icon;
            this.btnSuaBA.Location = new System.Drawing.Point(11, 26);
            this.btnSuaBA.Name = "btnSuaBA";
            this.btnSuaBA.Size = new System.Drawing.Size(129, 52);
            this.btnSuaBA.TabIndex = 0;
            this.btnSuaBA.Text = "Sửa";
            this.btnSuaBA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaBA.UseVisualStyleBackColor = false;
            this.btnSuaBA.Click += new System.EventHandler(this.btnSuaBA_Click);
            // 
            // btnThoatBA
            // 
            this.btnThoatBA.BackColor = System.Drawing.Color.Red;
            this.btnThoatBA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatBA.Image = global::DoAnTH.Properties.Resources.Button_Close_icon1;
            this.btnThoatBA.Location = new System.Drawing.Point(105, 92);
            this.btnThoatBA.Name = "btnThoatBA";
            this.btnThoatBA.Size = new System.Drawing.Size(128, 48);
            this.btnThoatBA.TabIndex = 2;
            this.btnThoatBA.Text = "Thoát";
            this.btnThoatBA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatBA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoatBA.UseVisualStyleBackColor = false;
            this.btnThoatBA.Click += new System.EventHandler(this.btnThoatBA_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnLuuBA);
            this.panel18.Controls.Add(this.btnSuaBA);
            this.panel18.Controls.Add(this.btnThoatBA);
            this.panel18.Location = new System.Drawing.Point(28, 211);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(316, 148);
            this.panel18.TabIndex = 3;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txtTrangThai.Location = new System.Drawing.Point(127, 7);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(176, 28);
            this.txtTrangThai.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Linen;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng Thái";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.txtTrangThai);
            this.panel19.Controls.Add(this.label8);
            this.panel19.Location = new System.Drawing.Point(3, 85);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(356, 38);
            this.panel19.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel12.Controls.Add(this.panel19);
            this.panel12.Controls.Add(this.panel18);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(740, 78);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(375, 411);
            this.panel12.TabIndex = 2;
            // 
            // QLBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1180, 575);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvBanAn);
            this.Controls.Add(this.panel12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLBan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLBan_FormClosing);
            this.Load += new System.EventHandler(this.QLBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBan;
        private System.Windows.Forms.DataGridView dtgvBanAn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtNgayCN;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnLuuBA;
        private System.Windows.Forms.Button btnSuaBA;
        private System.Windows.Forms.Button btnThoatBA;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel12;
    }
}