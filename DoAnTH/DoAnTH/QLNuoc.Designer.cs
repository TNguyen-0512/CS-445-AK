
namespace DoAnTH
{
    partial class QLNuoc
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridQLNuoc = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnDoc = new System.Windows.Forms.Button();
            this.cbNU = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnXoaNU = new System.Windows.Forms.Button();
            this.btnSuaNU = new System.Windows.Forms.Button();
            this.btnHuyNU = new System.Windows.Forms.Button();
            this.btnLuuNU = new System.Windows.Forms.Button();
            this.btnThemNU = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQLNuoc)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridQLNuoc);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 722);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(399, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 49);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quản  Lý Nước";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(11, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 236);
            this.panel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("VNI-Truck", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 86);
            this.label2.TabIndex = 11;
            this.label2.Text = "QV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(1, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quán";
            // 
            // dataGridQLNuoc
            // 
            this.dataGridQLNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQLNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTen,
            this.colSoLuong,
            this.cloGia});
            this.dataGridQLNuoc.Location = new System.Drawing.Point(177, 168);
            this.dataGridQLNuoc.Name = "dataGridQLNuoc";
            this.dataGridQLNuoc.RowHeadersWidth = 51;
            this.dataGridQLNuoc.RowTemplate.Height = 24;
            this.dataGridQLNuoc.Size = new System.Drawing.Size(646, 467);
            this.dataGridQLNuoc.TabIndex = 14;
            this.dataGridQLNuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQLNuoc_CellContentClick);
            this.dataGridQLNuoc.SelectionChanged += new System.EventHandler(this.dataGridQLNuoc_SelectionChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.Width = 80;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "TenMon";
            this.colTen.HeaderText = "Tên ";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.Width = 130;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 80;
            // 
            // cloGia
            // 
            this.cloGia.DataPropertyName = "GiaTien";
            this.cloGia.HeaderText = "Giá Tiền";
            this.cloGia.MinimumWidth = 6;
            this.cloGia.Name = "cloGia";
            this.cloGia.Width = 120;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.HotPink;
            this.panel14.Controls.Add(this.cbNU);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Location = new System.Drawing.Point(177, 85);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(646, 77);
            this.panel14.TabIndex = 12;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(158, 142);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(96, 48);
            this.btnDoc.TabIndex = 6;
            this.btnDoc.Text = "Đọc Dữ Liệu";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click_1);
            // 
            // cbNU
            // 
            this.cbNU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNU.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNU.FormattingEnabled = true;
            this.cbNU.Items.AddRange(new object[] {
            "Coffee",
            "Trà Sữa"});
            this.cbNU.Location = new System.Drawing.Point(274, 26);
            this.cbNU.Name = "cbNU";
            this.cbNU.Size = new System.Drawing.Size(258, 29);
            this.cbNU.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Danh Mục Sản Phẩm";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.lblSoLuong);
            this.panel11.Controls.Add(this.lblTenMon);
            this.panel11.Controls.Add(this.lblID);
            this.panel11.Controls.Add(this.txtGia);
            this.panel11.Controls.Add(this.txtSoLuong);
            this.panel11.Controls.Add(this.txtTenMon);
            this.panel11.Controls.Add(this.txtID);
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(829, 168);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(336, 468);
            this.panel11.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá Tiền";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Linen;
            this.lblSoLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(18, 120);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(78, 21);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.BackColor = System.Drawing.Color.Linen;
            this.lblTenMon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(18, 73);
            this.lblTenMon.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(74, 21);
            this.lblTenMon.TabIndex = 8;
            this.lblTenMon.Text = "Tên Món";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Linen;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(18, 24);
            this.lblID.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 21);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(118, 166);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(206, 28);
            this.txtGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(118, 114);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(206, 28);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(118, 67);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(206, 28);
            this.txtTenMon.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(118, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(206, 28);
            this.txtID.TabIndex = 6;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnDoc);
            this.panel16.Controls.Add(this.btnXoaNU);
            this.panel16.Controls.Add(this.btnSuaNU);
            this.panel16.Controls.Add(this.btnHuyNU);
            this.panel16.Controls.Add(this.btnLuuNU);
            this.panel16.Controls.Add(this.btnThemNU);
            this.panel16.Location = new System.Drawing.Point(30, 244);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(273, 193);
            this.panel16.TabIndex = 5;
            // 
            // btnXoaNU
            // 
            this.btnXoaNU.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnXoaNU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaNU.Location = new System.Drawing.Point(23, 80);
            this.btnXoaNU.Name = "btnXoaNU";
            this.btnXoaNU.Size = new System.Drawing.Size(96, 48);
            this.btnXoaNU.TabIndex = 2;
            this.btnXoaNU.Text = "Xóa";
            this.btnXoaNU.UseVisualStyleBackColor = false;
            this.btnXoaNU.Click += new System.EventHandler(this.btnXoaNU_Click_1);
            // 
            // btnSuaNU
            // 
            this.btnSuaNU.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSuaNU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaNU.Location = new System.Drawing.Point(158, 15);
            this.btnSuaNU.Name = "btnSuaNU";
            this.btnSuaNU.Size = new System.Drawing.Size(96, 46);
            this.btnSuaNU.TabIndex = 1;
            this.btnSuaNU.Text = "Sửa";
            this.btnSuaNU.UseVisualStyleBackColor = false;
            this.btnSuaNU.Click += new System.EventHandler(this.btnSuaNU_Click);
            // 
            // btnHuyNU
            // 
            this.btnHuyNU.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnHuyNU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyNU.Location = new System.Drawing.Point(23, 142);
            this.btnHuyNU.Name = "btnHuyNU";
            this.btnHuyNU.Size = new System.Drawing.Size(96, 48);
            this.btnHuyNU.TabIndex = 0;
            this.btnHuyNU.Text = "Hủy";
            this.btnHuyNU.UseVisualStyleBackColor = false;
            this.btnHuyNU.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnLuuNU
            // 
            this.btnLuuNU.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnLuuNU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuNU.Location = new System.Drawing.Point(158, 80);
            this.btnLuuNU.Name = "btnLuuNU";
            this.btnLuuNU.Size = new System.Drawing.Size(96, 48);
            this.btnLuuNU.TabIndex = 0;
            this.btnLuuNU.Text = "Lưu";
            this.btnLuuNU.UseVisualStyleBackColor = false;
            this.btnLuuNU.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnThemNU
            // 
            this.btnThemNU.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnThemNU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemNU.Location = new System.Drawing.Point(23, 15);
            this.btnThemNU.Name = "btnThemNU";
            this.btnThemNU.Size = new System.Drawing.Size(96, 48);
            this.btnThemNU.TabIndex = 0;
            this.btnThemNU.Text = "Thêm";
            this.btnThemNU.UseVisualStyleBackColor = false;
            this.btnThemNU.Click += new System.EventHandler(this.btnThemNU_Click_1);
            // 
            // QLNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 717);
            this.Controls.Add(this.panel1);
            this.Name = "QLNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Sản Phẩm";
            this.Load += new System.EventHandler(this.QLNuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQLNuoc)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.ComboBox cbNU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnXoaNU;
        private System.Windows.Forms.Button btnSuaNU;
        private System.Windows.Forms.Button btnLuuNU;
        private System.Windows.Forms.Button btnThemNU;
        private System.Windows.Forms.DataGridView dataGridQLNuoc;
        private System.Windows.Forms.Button btnHuyNU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloGia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}