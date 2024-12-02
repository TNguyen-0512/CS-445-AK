
namespace DoAnTH
{
    partial class QLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridQLNuoc = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cbNU = new System.Windows.Forms.ComboBox();
            this.btnDoc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTeSP = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.txtSLuong = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaNU = new System.Windows.Forms.Button();
            this.btnLuuNU = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.dataGridQLNuoc);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 722);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(413, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 49);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quản Lý Sản Phẩm";
            // 
            // dataGridQLNuoc
            // 
            this.dataGridQLNuoc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridQLNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQLNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTen,
            this.colSoLuong,
            this.cloGia,
            this.ChucVu});
            this.dataGridQLNuoc.Location = new System.Drawing.Point(177, 168);
            this.dataGridQLNuoc.Name = "dataGridQLNuoc";
            this.dataGridQLNuoc.ReadOnly = true;
            this.dataGridQLNuoc.RowHeadersWidth = 51;
            this.dataGridQLNuoc.RowTemplate.Height = 24;
            this.dataGridQLNuoc.Size = new System.Drawing.Size(747, 467);
            this.dataGridQLNuoc.TabIndex = 14;
            this.dataGridQLNuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQLNuoc_CellContentClick);
            this.dataGridQLNuoc.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQLNuoc_CellEnter);
            this.dataGridQLNuoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQLNuoc_RowEnter);
            this.dataGridQLNuoc.SelectionChanged += new System.EventHandler(this.dataGridQLNuoc_SelectionChanged);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "TenMon";
            this.colID.HeaderText = "Tên Sản Phẩm";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 120;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "SoLuong";
            this.colTen.HeaderText = "S.Lượng";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Width = 60;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "GiaTien";
            this.colSoLuong.HeaderText = "Giá Tiền";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 80;
            // 
            // cloGia
            // 
            this.cloGia.DataPropertyName = "Ngay";
            this.cloGia.HeaderText = "Ngày ";
            this.cloGia.MinimumWidth = 6;
            this.cloGia.Name = "cloGia";
            this.cloGia.ReadOnly = true;
            this.cloGia.Width = 150;
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 150;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.HotPink;
            this.panel14.Controls.Add(this.cbNU);
            this.panel14.Controls.Add(this.btnDoc);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Location = new System.Drawing.Point(177, 85);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(747, 77);
            this.panel14.TabIndex = 1;
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
            this.cbNU.TabIndex = 1;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDoc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(578, 9);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(115, 55);
            this.btnDoc.TabIndex = 2;
            this.btnDoc.Text = "Đọc Dữ Liệu";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click_1);
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
            this.panel11.Controls.Add(this.lblChucVu);
            this.panel11.Controls.Add(this.txtChucVu);
            this.panel11.Controls.Add(this.lblNgay);
            this.panel11.Controls.Add(this.lblTien);
            this.panel11.Controls.Add(this.lblSL);
            this.panel11.Controls.Add(this.lblTeSP);
            this.panel11.Controls.Add(this.txtngay);
            this.panel11.Controls.Add(this.txtgiatien);
            this.panel11.Controls.Add(this.txtSLuong);
            this.panel11.Controls.Add(this.txtTen);
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(930, 85);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(361, 550);
            this.panel11.TabIndex = 1;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.BackColor = System.Drawing.Color.Linen;
            this.lblChucVu.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.lblChucVu.Location = new System.Drawing.Point(12, 213);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(71, 21);
            this.lblChucVu.TabIndex = 10;
            this.lblChucVu.Text = "Chức Vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(141, 210);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(206, 24);
            this.txtChucVu.TabIndex = 4;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.Color.Linen;
            this.lblNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(12, 173);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(47, 21);
            this.lblNgay.TabIndex = 8;
            this.lblNgay.Text = "Ngày";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.BackColor = System.Drawing.Color.Linen;
            this.lblTien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(12, 121);
            this.lblTien.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(71, 21);
            this.lblTien.TabIndex = 8;
            this.lblTien.Text = "Giá Tiền";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.BackColor = System.Drawing.Color.Linen;
            this.lblSL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(12, 74);
            this.lblSL.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(78, 21);
            this.lblSL.TabIndex = 8;
            this.lblSL.Text = "Số Lượng";
            // 
            // lblTeSP
            // 
            this.lblTeSP.AutoSize = true;
            this.lblTeSP.BackColor = System.Drawing.Color.Linen;
            this.lblTeSP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeSP.Location = new System.Drawing.Point(7, 25);
            this.lblTeSP.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblTeSP.Name = "lblTeSP";
            this.lblTeSP.Size = new System.Drawing.Size(116, 21);
            this.lblTeSP.TabIndex = 8;
            this.lblTeSP.Text = "Tên Sản Phẩm";
            // 
            // txtngay
            // 
            this.txtngay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngay.Location = new System.Drawing.Point(141, 166);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(206, 28);
            this.txtngay.TabIndex = 3;
            // 
            // txtgiatien
            // 
            this.txtgiatien.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiatien.Location = new System.Drawing.Point(141, 114);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(206, 28);
            this.txtgiatien.TabIndex = 2;
            // 
            // txtSLuong
            // 
            this.txtSLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLuong.Location = new System.Drawing.Point(141, 67);
            this.txtSLuong.Name = "txtSLuong";
            this.txtSLuong.Size = new System.Drawing.Size(206, 28);
            this.txtSLuong.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(141, 18);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(206, 28);
            this.txtTen.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btnHuy);
            this.panel16.Controls.Add(this.btnSuaNU);
            this.panel16.Controls.Add(this.btnLuuNU);
            this.panel16.Location = new System.Drawing.Point(3, 289);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(358, 203);
            this.panel16.TabIndex = 5;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = global::DoAnTH.Properties.Resources.window_close1;
            this.btnHuy.Location = new System.Drawing.Point(100, 115);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 55);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = " Thoát";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaNU
            // 
            this.btnSuaNU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaNU.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNU.Image = global::DoAnTH.Properties.Resources.Repair_icon;
            this.btnSuaNU.Location = new System.Drawing.Point(5, 42);
            this.btnSuaNU.Name = "btnSuaNU";
            this.btnSuaNU.Size = new System.Drawing.Size(161, 53);
            this.btnSuaNU.TabIndex = 0;
            this.btnSuaNU.Text = "Sửa Dữ Liệu";
            this.btnSuaNU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNU.UseVisualStyleBackColor = false;
            this.btnSuaNU.Click += new System.EventHandler(this.btnSuaNU_Click);
            // 
            // btnLuuNU
            // 
            this.btnLuuNU.BackColor = System.Drawing.Color.Lime;
            this.btnLuuNU.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNU.Image = global::DoAnTH.Properties.Resources.Save_icon;
            this.btnLuuNU.Location = new System.Drawing.Point(184, 42);
            this.btnLuuNU.Name = "btnLuuNU";
            this.btnLuuNU.Size = new System.Drawing.Size(166, 55);
            this.btnLuuNU.TabIndex = 1;
            this.btnLuuNU.Text = "Lưu Dữ Liệu";
            this.btnLuuNU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuNU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuNU.UseVisualStyleBackColor = false;
            this.btnLuuNU.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // QLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 717);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Sản Phẩm";
            this.Load += new System.EventHandler(this.QLNuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTeSP;
        private System.Windows.Forms.TextBox txtngay;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.TextBox txtSLuong;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnSuaNU;
        private System.Windows.Forms.Button btnLuuNU;
        private System.Windows.Forms.DataGridView dataGridQLNuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
    }
}