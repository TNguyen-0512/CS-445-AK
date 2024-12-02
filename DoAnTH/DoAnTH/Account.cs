using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTH
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        void PhanQuyen()
        {
            //if (Const.LoaiTaiKhoan == false)
            //    txbTk.Enabled = false;
            //switch (Const.TaiKhoan.LoaiTaiKhoan)
            //{
            //    case TaiKhoan.LoaiTK.NhanVien:
            //       // adminToolStripMenuItem.Enabled = false;
            //        break;
            //    case TaiKhoan.LoaiTK.KhachHang:
            //       // adminToolStripMenuItem.Enabled = false;

            //        break;
            //}
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.NhanVien1:
                    txbTk.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.NhanVien:
                    txbTk.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.Quanli:
                    txbTk.Enabled = false;
                    txbTk.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.Quanli1:
                    txbTk.Enabled = false;
                    break;
            }
            txtTenHienThi.Text = Const.TaiKhoan.TenHienThi;
            txbTk.Text = Const.TaiKhoan.TenTaiKhoan;
            txbMK.Text = Const.TaiKhoan.MatKhau;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            ChuongTrinh f = new ChuongTrinh();
            f.Hide();
        }

       

        private void txtTk_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Account_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            
        }

        //private void btnHienMK_Click(object sender, EventArgs e)
        //{
           
        //}

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txbMK.UseSystemPasswordChar = false;
            }
            else
            {
                txbMK.UseSystemPasswordChar = true;
            }
        }

        private void txbTk_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbHienMK_Click(object sender, EventArgs e)
        {
            //if (cbHienMK.Checked && txbMK.PasswordChar == '*')
            //{
            //    peye.BringToFront =);

            //}
        }

        private void cbHienMK_MouseHover(object sender, EventArgs e)
        {
            if (cbHienMK.Checked && txbMK.PasswordChar != '\0')
            {
                cbHienMK.BringToFront();
                txbMK.PasswordChar = '\0';
            }
        }

        private void Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ChuongTrinh f = new ChuongTrinh();
            //    f.ShowDialog();
        }
    }
}
