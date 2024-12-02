
namespace DoAnTH
{
    partial class QLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHoaDon));
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtHinhThuc = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.cbxTopping = new System.Windows.Forms.ComboBox();
            this.datimeNgayMua = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHoaDon = new System.Windows.Forms.CheckBox();
            this.cbTenSP = new System.Windows.Forms.CheckBox();
            this.CBTopping = new System.Windows.Forms.CheckBox();
            this.cbSoLuong = new System.Windows.Forms.CheckBox();
            this.cbGia = new System.Windows.Forms.CheckBox();
            this.cbHinhThuc = new System.Windows.Forms.CheckBox();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.cbngay = new System.Windows.Forms.CheckBox();
            this.txtNguoiBan = new System.Windows.Forms.TextBox();
            this.cbnguoiban = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblGiamDan = new System.Windows.Forms.Button();
            this.btnsapxep = new System.Windows.Forms.Button();
            this.cbbSapXep = new System.Windows.Forms.ComboBox();
            this.lblSapXep = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThanhToan
            // 
            this.dgvThanhToan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHoaDon,
            this.TenMon,
            this.Topping,
            this.SoLuong,
            this.GiaTien,
            this.colHinhThuc,
            this.TrangThai,
            this.NgayMua,
            this.NguoiBan});
            this.dgvThanhToan.GridColor = System.Drawing.Color.Plum;
            this.dgvThanhToan.Location = new System.Drawing.Point(1, 93);
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.ReadOnly = true;
            this.dgvThanhToan.RowHeadersWidth = 51;
            this.dgvThanhToan.RowTemplate.Height = 24;
            this.dgvThanhToan.Size = new System.Drawing.Size(1100, 655);
            this.dgvThanhToan.TabIndex = 1;
            this.dgvThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellClick);
            this.dgvThanhToan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellContentClick);
            this.dgvThanhToan.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_CellEnter);
            this.dgvThanhToan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhToan_RowEnter);
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.DataPropertyName = "ID";
            this.IDHoaDon.HeaderText = "ID Hóa Đơn";
            this.IDHoaDon.MinimumWidth = 6;
            this.IDHoaDon.Name = "IDHoaDon";
            this.IDHoaDon.ReadOnly = true;
            this.IDHoaDon.Width = 90;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenSanPham";
            this.TenMon.HeaderText = "Tên Sản Phẩm";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 130;
            // 
            // Topping
            // 
            this.Topping.DataPropertyName = "Topping";
            this.Topping.HeaderText = "Topping";
            this.Topping.MinimumWidth = 6;
            this.Topping.Name = "Topping";
            this.Topping.ReadOnly = true;
            this.Topping.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "S.Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 70;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "Gia";
            this.GiaTien.HeaderText = "Giá";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.Width = 70;
            // 
            // colHinhThuc
            // 
            this.colHinhThuc.DataPropertyName = "HinhThuc";
            this.colHinhThuc.HeaderText = "Hình Thức";
            this.colHinhThuc.MinimumWidth = 6;
            this.colHinhThuc.Name = "colHinhThuc";
            this.colHinhThuc.ReadOnly = true;
            this.colHinhThuc.Width = 120;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 120;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "Ngay";
            this.NgayMua.HeaderText = "Ngày Mua";
            this.NgayMua.MinimumWidth = 6;
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.ReadOnly = true;
            this.NgayMua.Width = 170;
            // 
            // NguoiBan
            // 
            this.NguoiBan.HeaderText = "Người Bán";
            this.NguoiBan.MinimumWidth = 6;
            this.NguoiBan.Name = "NguoiBan";
            this.NguoiBan.ReadOnly = true;
            this.NguoiBan.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Turquoise;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(506, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(403, 55);
            this.label9.TabIndex = 29;
            this.label9.Text = "Quản Lý Hóa Đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Trạng Thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hình Thức";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày Mua";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Người Bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá Tiền";
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDon.Location = new System.Drawing.Point(141, 99);
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(271, 26);
            this.txtHoaDon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(141, 140);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(271, 26);
            this.txtTenSP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Topping";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(141, 217);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(271, 26);
            this.txtSoLuong.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(141, 259);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(271, 26);
            this.txtGia.TabIndex = 7;
            // 
            // txtHinhThuc
            // 
            this.txtHinhThuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhThuc.Location = new System.Drawing.Point(141, 302);
            this.txtHinhThuc.Name = "txtHinhThuc";
            this.txtHinhThuc.Size = new System.Drawing.Size(271, 26);
            this.txtHinhThuc.TabIndex = 8;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(141, 345);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(271, 26);
            this.txtTrangThai.TabIndex = 9;
            // 
            // cbxTopping
            // 
            this.cbxTopping.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTopping.FormattingEnabled = true;
            this.cbxTopping.Location = new System.Drawing.Point(141, 176);
            this.cbxTopping.Name = "cbxTopping";
            this.cbxTopping.Size = new System.Drawing.Size(271, 26);
            this.cbxTopping.TabIndex = 5;
            this.cbxTopping.SelectedIndexChanged += new System.EventHandler(this.cbxTopping_SelectedIndexChanged);
            // 
            // datimeNgayMua
            // 
            this.datimeNgayMua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datimeNgayMua.Location = new System.Drawing.Point(141, 390);
            this.datimeNgayMua.Name = "datimeNgayMua";
            this.datimeNgayMua.Size = new System.Drawing.Size(271, 26);
            this.datimeNgayMua.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbHoaDon
            // 
            this.cbHoaDon.AutoSize = true;
            this.cbHoaDon.Location = new System.Drawing.Point(418, 103);
            this.cbHoaDon.Name = "cbHoaDon";
            this.cbHoaDon.Size = new System.Drawing.Size(18, 17);
            this.cbHoaDon.TabIndex = 17;
            this.cbHoaDon.UseVisualStyleBackColor = true;
            this.cbHoaDon.CheckedChanged += new System.EventHandler(this.cbHoaDon_CheckedChanged);
            // 
            // cbTenSP
            // 
            this.cbTenSP.AutoSize = true;
            this.cbTenSP.Location = new System.Drawing.Point(418, 146);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(18, 17);
            this.cbTenSP.TabIndex = 18;
            this.cbTenSP.UseVisualStyleBackColor = true;
            this.cbTenSP.CheckedChanged += new System.EventHandler(this.cbTenSP_CheckedChanged);
            // 
            // CBTopping
            // 
            this.CBTopping.AutoSize = true;
            this.CBTopping.Location = new System.Drawing.Point(418, 182);
            this.CBTopping.Name = "CBTopping";
            this.CBTopping.Size = new System.Drawing.Size(18, 17);
            this.CBTopping.TabIndex = 19;
            this.CBTopping.UseVisualStyleBackColor = true;
            this.CBTopping.CheckedChanged += new System.EventHandler(this.CBTopping_CheckedChanged);
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.AutoSize = true;
            this.cbSoLuong.Location = new System.Drawing.Point(418, 223);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(18, 17);
            this.cbSoLuong.TabIndex = 20;
            this.cbSoLuong.UseVisualStyleBackColor = true;
            this.cbSoLuong.CheckedChanged += new System.EventHandler(this.cbSoLuong_CheckedChanged);
            // 
            // cbGia
            // 
            this.cbGia.AutoSize = true;
            this.cbGia.Location = new System.Drawing.Point(418, 265);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(18, 17);
            this.cbGia.TabIndex = 21;
            this.cbGia.UseVisualStyleBackColor = true;
            this.cbGia.CheckedChanged += new System.EventHandler(this.cbGia_CheckedChanged);
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.AutoSize = true;
            this.cbHinhThuc.Location = new System.Drawing.Point(418, 308);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(18, 17);
            this.cbHinhThuc.TabIndex = 22;
            this.cbHinhThuc.UseVisualStyleBackColor = true;
            this.cbHinhThuc.CheckedChanged += new System.EventHandler(this.cbHinhThuc_CheckedChanged);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Location = new System.Drawing.Point(418, 350);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(18, 17);
            this.cbTrangThai.TabIndex = 23;
            this.cbTrangThai.UseVisualStyleBackColor = true;
            this.cbTrangThai.CheckedChanged += new System.EventHandler(this.cbTrangThai_CheckedChanged);
            // 
            // cbngay
            // 
            this.cbngay.AutoSize = true;
            this.cbngay.Location = new System.Drawing.Point(418, 396);
            this.cbngay.Name = "cbngay";
            this.cbngay.Size = new System.Drawing.Size(18, 17);
            this.cbngay.TabIndex = 24;
            this.cbngay.UseVisualStyleBackColor = true;
            this.cbngay.CheckedChanged += new System.EventHandler(this.cbngay_CheckedChanged);
            // 
            // txtNguoiBan
            // 
            this.txtNguoiBan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiBan.Location = new System.Drawing.Point(141, 430);
            this.txtNguoiBan.Multiline = true;
            this.txtNguoiBan.Name = "txtNguoiBan";
            this.txtNguoiBan.Size = new System.Drawing.Size(271, 26);
            this.txtNguoiBan.TabIndex = 11;
            // 
            // cbnguoiban
            // 
            this.cbnguoiban.AutoSize = true;
            this.cbnguoiban.Location = new System.Drawing.Point(418, 437);
            this.cbnguoiban.Name = "cbnguoiban";
            this.cbnguoiban.Size = new System.Drawing.Size(18, 17);
            this.cbnguoiban.TabIndex = 25;
            this.cbnguoiban.UseVisualStyleBackColor = true;
            this.cbnguoiban.CheckedChanged += new System.EventHandler(this.cbnguoiban_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.lblGiamDan);
            this.panel1.Controls.Add(this.btnsapxep);
            this.panel1.Controls.Add(this.cbbSapXep);
            this.panel1.Controls.Add(this.cbnguoiban);
            this.panel1.Controls.Add(this.txtNguoiBan);
            this.panel1.Controls.Add(this.cbngay);
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.cbHinhThuc);
            this.panel1.Controls.Add(this.cbGia);
            this.panel1.Controls.Add(this.cbSoLuong);
            this.panel1.Controls.Add(this.CBTopping);
            this.panel1.Controls.Add(this.cbTenSP);
            this.panel1.Controls.Add(this.cbHoaDon);
            this.panel1.Controls.Add(this.lblSapXep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datimeNgayMua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.cbxTopping);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtHinhThuc);
            this.panel1.Controls.Add(this.btnLuuFile);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHoaDon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(1107, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 655);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = global::DoAnTH.Properties.Resources.window_close;
            this.btnThoat.Location = new System.Drawing.Point(178, 596);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 52);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblGiamDan
            // 
            this.lblGiamDan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblGiamDan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamDan.Image = global::DoAnTH.Properties.Resources.sort_descending;
            this.lblGiamDan.Location = new System.Drawing.Point(316, 49);
            this.lblGiamDan.Name = "lblGiamDan";
            this.lblGiamDan.Size = new System.Drawing.Size(142, 44);
            this.lblGiamDan.TabIndex = 2;
            this.lblGiamDan.Text = "Sắp Giảm";
            this.lblGiamDan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGiamDan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblGiamDan.UseVisualStyleBackColor = false;
            this.lblGiamDan.Click += new System.EventHandler(this.lblGiamDan_Click);
            // 
            // btnsapxep
            // 
            this.btnsapxep.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsapxep.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsapxep.Image = global::DoAnTH.Properties.Resources.sort_ascending;
            this.btnsapxep.Location = new System.Drawing.Point(316, 0);
            this.btnsapxep.Name = "btnsapxep";
            this.btnsapxep.Size = new System.Drawing.Size(142, 44);
            this.btnsapxep.TabIndex = 1;
            this.btnsapxep.Text = "Sắp Tăng";
            this.btnsapxep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsapxep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsapxep.UseVisualStyleBackColor = false;
            this.btnsapxep.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbSapXep
            // 
            this.cbbSapXep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSapXep.FormattingEnabled = true;
            this.cbbSapXep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbSapXep.Items.AddRange(new object[] {
            "ID Hóa Đơn",
            "Tên Sản Phẩm",
            "Topping",
            "Số Lượng",
            "Giá Bán",
            "Hình Thức",
            "Trạng Thái",
            "Ngày Mua",
            "Người Bán"});
            this.cbbSapXep.Location = new System.Drawing.Point(141, 36);
            this.cbbSapXep.Name = "cbbSapXep";
            this.cbbSapXep.Size = new System.Drawing.Size(169, 26);
            this.cbbSapXep.TabIndex = 0;
            // 
            // lblSapXep
            // 
            this.lblSapXep.AutoSize = true;
            this.lblSapXep.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSapXep.Location = new System.Drawing.Point(25, 41);
            this.lblSapXep.Name = "lblSapXep";
            this.lblSapXep.Size = new System.Drawing.Size(70, 21);
            this.lblSapXep.TabIndex = 0;
            this.lblSapXep.Text = "Sắp Xếp";
            this.lblSapXep.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::DoAnTH.Properties.Resources.Button_Add_icon__1_;
            this.btnThem.Location = new System.Drawing.Point(60, 468);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(143, 52);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::DoAnTH.Properties.Resources.Repair_icon;
            this.btnSua.Location = new System.Drawing.Point(293, 468);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 52);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::DoAnTH.Properties.Resources.Button_Close_icon;
            this.btnXoa.Location = new System.Drawing.Point(60, 538);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 52);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.BackColor = System.Drawing.Color.Aqua;
            this.btnLuuFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuFile.Image = global::DoAnTH.Properties.Resources.Save_icon;
            this.btnLuuFile.Location = new System.Drawing.Point(293, 538);
            this.btnLuuFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(143, 52);
            this.btnLuuFile.TabIndex = 15;
            this.btnLuuFile.Text = "Lưu File";
            this.btnLuuFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuFile.UseVisualStyleBackColor = false;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1584, 752);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThanhToan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.QLHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.TextBox txtHinhThuc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbxTopping;
        private System.Windows.Forms.DateTimePicker datimeNgayMua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHoaDon;
        private System.Windows.Forms.CheckBox cbTenSP;
        private System.Windows.Forms.CheckBox CBTopping;
        private System.Windows.Forms.CheckBox cbSoLuong;
        private System.Windows.Forms.CheckBox cbGia;
        private System.Windows.Forms.CheckBox cbHinhThuc;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.CheckBox cbngay;
        private System.Windows.Forms.TextBox txtNguoiBan;
        private System.Windows.Forms.CheckBox cbnguoiban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topping;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsapxep;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.Button lblGiamDan;
        private System.Windows.Forms.Button btnThoat;
    }
}