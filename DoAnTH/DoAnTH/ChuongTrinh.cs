using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace DoAnTH
{
    public partial class ChuongTrinh : Form
    {
      private List<COrder> order;
        public ChuongTrinh()
        {
            InitializeComponent();
        }
        

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            this.Hide();
            btnDangNhap f = new btnDangNhap();
            f.ShowDialog();
        }


        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }



        void PhanQuyen()
        {
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.NhanVien:
                    adminToolStripMenuItem.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.NhanVien1:
                    break;
                case TaiKhoan.LoaiTK.Quanli:
                    break;
                case TaiKhoan.LoaiTK.Quanli1:
                    break;
            }

            txtLoaiTK.Text = Const.TaiKhoan.TenHienThi;

        }
        Button[] tbtnIDBan;
        TextBox[] txtTrangThai;
        private void ChuongTrinh_Load(object sender, EventArgs e)
        {
              PhanQuyen();

            dgvThanhToan.Rows.Clear();
            dgvThanhToan.Refresh();

            var lines2 = File.ReadAllLines("HoaDonOrDer.txt");
            if (lines2.Count() > 0)
            {
                foreach (var cellValues2 in lines2.Skip(0))
                {
                    var cellArray2 = cellValues2.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cellArray2.Length == dgvThanhToan.Columns.Count)
                        dgvThanhToan.Rows.Add(cellArray2);
                }
            }

            string filePathban = @"csdlCapNhatBan.txt";
            if (!File.Exists(filePathban))
            {
                Console.WriteLine("File does not exist :{0} ", filePathban);
                return;
            }
            string[] textFromFileban = File.ReadAllLines(filePathban);
            tbtnIDBan = new Button[] { btnBan11, btnBan12, btnBan13, btnBan21, btnBan22, btnBan23, btnBan31, btnBan32, btnBan33 };
            txtTrangThai = new TextBox[] { txt11, txt12, txt13, txt21, txt22, txt23, txt31, txt32, txt33 };

            for (int i = 0; i < textFromFileban.ToArray().Length; i++)
            {
                string[] arrRes1 = textFromFileban[i].Split('-');
                tbtnIDBan[i].Text = arrRes1[0];
                txtTrangThai[i].Text = arrRes1[1];
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nmSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            if (btnBan11.Visible || btnBan12.Visible || btnBan13.Visible || btnBan21.Visible
                || btnBan22.Visible || btnBan23.Visible || btnBan31.Visible || btnBan32.Visible || btnBan33.Visible
                || btntra11.Visible || btntra12.Visible || btntra13.Visible
                || btntra21.Visible || btntra22.Visible || btntra23.Visible || btntra31.Visible || btntra32.Visible || btntra33.Visible)
            {
                using (StreamWriter w = new StreamWriter("csdlCapNhatBan.txt"))
                {
                    //true = ghi tiep vao file, false = ghi de le du lieu cu,
                    ////neu file chua ton tai se dc tao ra, file csdlCapNhat.txt cung cấp thư mục,
                    /////nếu ko phai chi rõ duong dẫn
                    w.WriteLine(btnBan11.Text + "-" + txt11.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan12.Text + "-" + txt12.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan13.Text + "-" + txt13.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan21.Text + "-" + txt21.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan22.Text + "-" + txt22.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan23.Text + "-" + txt23.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan31.Text + "-" + txt31.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan32.Text + "-" + txt32.Text + "-"+ datetimeNM.Value);
                    w.WriteLine(btnBan33.Text + "-" + txt33.Text + "-"+ datetimeNM.Value);
                }
                using (TextWriter tw = new StreamWriter("HoaDonOrDer.txt"))
                {
                    for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvThanhToan.Columns.Count; j++)
                        {
                            tw.Write($"{dgvThanhToan.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dgvThanhToan.Columns.Count - 1)
                            {
                                tw.Write("-");
                            }
                        }
                        tw.WriteLine();
                    }
                }
            }

        }

        private void thôngTinTaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


        private void CoffeeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //   this.Hide();
            Coffee f = new Coffee(this);
            f.Show();
            // dgvThanhToan.Rows/*[].Cells[1]*/.Add(f.laysanpham());

        }

        private void tràSữaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            TraSua f = new TraSua(this);
            f.Show();
        }

        private void listDatMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.ShowDialog();
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt11.Text = a;
            txtSoBan.Text = btnBan11.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt11.Text = a;

        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt12.Text = a;
            txtSoBan.Text = btnBan12.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt12.Text = a;

        }

        private void btnBan13_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt13.Text = a;
            txtSoBan.Text = btnBan13.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt13.Text = a;
        }

        private void btnBan21_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt21.Text = a;
            txtSoBan.Text = btnBan21.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt21.Text = a;
        }

        private void btnBan22_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt22.Text = a;
            txtSoBan.Text = btnBan22.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }
        private void btntra22_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt22.Text = a;
        }

        private void btnBan23_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt23.Text = a;
            txtSoBan.Text = btnBan23.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }

        private void btntra23_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt23.Text = a;

        }

        private void btnBan31_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt31.Text = a;
            txtSoBan.Text = btnBan31.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }
        private void btntra31_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt31.Text = a;
        }


        private void btnBan32_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt32.Text = a;
            txtSoBan.Text = btnBan32.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }
        private void btntra32_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt32.Text = a;
        }

        private void btnBan33_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt33.Text = a;
            txtSoBan.Text = btnBan33.Text;
            int index = dgvThanhToan.CurrentRow.Index;
            foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text + " " + txtSoBan.Text;
                    }
                }
            }
        }

        private void btntra33_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt33.Text = a;
        }

        private void quảnLýNướcUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
          QLBan f = new QLBan();
          f.ShowDialog();

        }

        private void dataGridQLCNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridQLCNuoc_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông Báo",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            this.Hide();
            // Close();
            //btnDangNhap f = new btnDangNhap();
            //f.ShowDialog();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text == "0")
            {
                MessageBox.Show("Không đơn thanh toán", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                //MessageBox.Show("Xác Nhận Thanh Toán", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                txttiencf.Text = "0";
                txttients.Text = "0";
                txtTongTien.Text = "0";

                int index = dgvThanhToan.CurrentRow.Index;
                foreach (char ma in dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                {
                    for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvThanhToan.Columns.Count; j++)
                        {
                            if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() == dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                            {
                                dgvThanhToan.Rows[i].Cells[6].Value = "Đã thanh toán";
                            }
                            else if (dgvThanhToan.Rows[i].Cells[0].Value.ToString() != dgvThanhToan.Rows[index].Cells[0].Value.ToString())
                            {
                                dgvThanhToan.Rows[i].Cells[6].Value = "Đã thanh toán";
                            }
                        }
                    }
                }
                using (TextWriter tw = new StreamWriter("HoaDonOrDer.txt"))
                {
                    for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvThanhToan.Columns.Count; j++)
                        {
                            tw.Write($"{dgvThanhToan.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dgvThanhToan.Columns.Count - 1)
                            {
                                tw.Write("-");
                            }
                        }
                        tw.WriteLine();
                    }
                }

                MessageBox.Show("Thanh Toán Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void coffeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coffee f = new Coffee(this);
            f.ShowDialog();
        }

        private void tràSữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSua f = new TraSua(this);
            f.ShowDialog();
        }

        private void oder()
        {
            order.Count();
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuCapnhat_Click(object sender, EventArgs e)
        {

        }



        private void rdoTaiCho_CheckedChanged(object sender, EventArgs e)
        {
            pelBan.Enabled = true;
        }

        private void rdoHuy_CheckedChanged(object sender, EventArgs e)
        {
            pelBan.Enabled = true;
        }

        private void coffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatCF f = new capnhatCF();
            f.ShowDialog();
        }

        private void tràSữaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            capnhatTS f = new capnhatTS();
            f.ShowDialog();
        }

        private void dgvThanhToan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grpHinhTHuc_Enter(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttiencf_TextChanged(object sender, EventArgs e)
        {
          
            double a = Convert.ToDouble(txttiencf.Text);
            double b = Convert.ToDouble(txttients.Text);
            
            if (a != 0 || b != 0)
            {
                double tong = a + b;
                txtTongTien.Text = tong.ToString();
            } else if ((a == 0 || b == 0))
            {
                double c = 0;
                txttiencf.Text = c.ToString();
                txttients.Text = c.ToString();
                txtTongTien.Text = c.ToString();
            }
        }

        private void txttients_TextChanged(object sender, EventArgs e)
        {
            
            double a = Convert.ToDouble(txttiencf.Text);
            double b = Convert.ToDouble(txttients.Text);
            if (a != 0 || b != 0)
            {
                double tong = a + b;
                txtTongTien.Text = tong.ToString();
            }
            else if ((a == 0 || b == 0))
            {
                double c = 0;
                txttiencf.Text = c.ToString();
                txttients.Text = c.ToString();
                txtTongTien.Text = c.ToString();
            }
        }

        private void chbMangVe_CheckedChanged(object sender, EventArgs e)
        {

            if (chbMangVe.Checked)
            {
                //  txtMangVe.Text = "Mang Về";
                chbTaiCho.Enabled = pelBan.Enabled = false;
                string hinhthuc = "Mang Về";
                txtHinhThuc.Text = hinhthuc;
                int index = dgvThanhToan.CurrentRow.Index;
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvThanhToan.Columns.Count; j++)
                    {
                        dgvThanhToan.Rows[index].Cells[5].Value = "Mang Về";
                    }
                }
            }
            else if (!chbMangVe.Checked)
            {
                chbTaiCho.Enabled = pelBan.Enabled = true;
                string hinhthuc = "";
                txtHinhThuc.Text = hinhthuc;
            }
        }

        private void chbTaiCho_CheckedChanged(object sender, EventArgs e)
        {

            if (chbTaiCho.Checked)
            {
                chbMangVe.Enabled = false;
                string hinhthuc = "Tại Chỗ";
                txtHinhThuc.Text = hinhthuc;
                
            }
            else if (!chbTaiCho.Checked)
            {
                chbMangVe.Enabled = true;
                string hinhthuc = "";
                txtHinhThuc.Text = hinhthuc;

              
            }
        }
        private void grpHinhTHuc_Enter_1(object sender, EventArgs e)
        {
            if(chbTaiCho.Visible||chbMangVe.Visible||chbMangVe.Checked)
            {
                using (TextWriter tw = new StreamWriter("HoaDonOrDer.txt"))
                {
                    for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvThanhToan.Columns.Count; j++)
                        {
                            tw.Write($"{dgvThanhToan.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dgvThanhToan.Columns.Count - 1)
                            {
                                tw.Write("-");
                            }
                        }
                        tw.WriteLine();
                    }
                }
            }    
        }
        
        private void dgvThanhToan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvThanhToan.CurrentRow.Index;
            if (e.RowIndex >= 0)
            {
                for (int i = 0; i < dgvThanhToan.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvThanhToan.Columns.Count; j++)
                    {
                        if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Mang Về ")
                        {
                            chbTaiCho.Checked = false;
                            chbMangVe.Checked = true;
                            txtHinhThuc.Text = "Mang Vê";
                            txtSoBan.Text = " ";
                            break;

                        }
                        else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Mang Về")
                        {
                            chbTaiCho.Checked = true;
                            chbMangVe.Checked = false;
                            txtHinhThuc.Text = "Tại Chỗ";

                            break;
                        }
                        else if (
                                 dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 1.1"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 1.2"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 1.3"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 2.1"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 2.2"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 2.3"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 3.1"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 3.2"
                                 || dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 3.3"
                                 )
                        {
                            chbTaiCho.Checked = true;
                            chbMangVe.Checked = false;
                            txtHinhThuc.Text = "Tại Chỗ" + txtSoBan.Text;
                            break;
                        }

                        else if (
                            dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 1.1"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 1.2"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 1.3"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 2.1"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 2.2"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 2.3"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 3.1"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 3.2"
                            || dgvThanhToan.Rows[index].Cells[5].Value.ToString() != "Tại Chỗ Bàn 3.3"
                            )
                        {
                            chbMangVe.Checked = true;
                            chbTaiCho.Checked = false;
                            txtSoBan.Text = " ";
                            txtHinhThuc.Text = "Mang Về";
                            break;
                        }

                    }
                }
                if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 1.1")
                {
                    txtSoBan.Text = "Bàn 1.1";
                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 1.2")
                {
                    txtSoBan.Text = "Bàn 1.2";
                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 1.3")
                {
                    txtSoBan.Text = "Bàn 1.3";
                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 2.1")
                {
                    txtSoBan.Text = "Bàn 2.1";

                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 2.2")
                {
                    txtSoBan.Text = "Bàn 2.2";

                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 2.3")
                {
                    txtSoBan.Text = "Bàn 2.3";
                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 3.1")
                {
                    txtSoBan.Text = "Bàn 3.1";
                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 3.2")
                {
                    txtSoBan.Text = "Bàn 3.2";
                }
                else if (dgvThanhToan.Rows[index].Cells[5].Value.ToString() == "Tại Chỗ Bàn 3.3")
                {
                    txtSoBan.Text = "Bàn 3.3";
                }
            }
        }

        private void QLHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Close();
            //QLHoaDon f = new QLHoaDon();
            //f.ShowDialog();

            this.Hide();
            this.Close();
            QLHoaDon f = new QLHoaDon();
            f.ShowDialog();
        }

        private void quảnLýNướcUốngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QLSanPham f = new QLSanPham();
            f.ShowDialog();
        }

        private void quảnLýToppingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPTopping f = new SPTopping();
            f.ShowDialog();
        }
    }
}
