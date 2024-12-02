using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DoAnTH
{
    public partial class btnDangNhap : Form
    {
        public btnDangNhap()
        {
            InitializeComponent();
        }


        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau)
                {
                    Const.TaiKhoan = listTaiKhoan[i];
                    return true;
                }
            }
            return false;
        }

        public void btnDN_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txbTaiKhoan.Text, txbMatKhau.Text))
            {
                this.Hide();
                ChuongTrinh f = new ChuongTrinh();
                f.ShowDialog(); 
                this.Close();
            }
            else 
            {
                for (int i = 0; i < listTaiKhoan.Count; i++)
                {
                    if (txbTaiKhoan.Text != listTaiKhoan[i].TenTaiKhoan && txbMatKhau.Text != listTaiKhoan[i].MatKhau)
                    {
                        MessageBox.Show("Sai Tài Khoản và mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbTaiKhoan.Focus();
                        break;
                    }
                    else if ( txbMatKhau.Text == listTaiKhoan[i].MatKhau && txbTaiKhoan.Text != listTaiKhoan[i].TenTaiKhoan )
                    {
                        MessageBox.Show("Sai Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbTaiKhoan.Focus();
                        break;
                    }
                    
                    else if (txbTaiKhoan.Text == listTaiKhoan[i].TenTaiKhoan && txbMatKhau.Text != listTaiKhoan[i].MatKhau)
                    {
                        MessageBox.Show("Sai mật khẩu", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txbMatKhau.Focus();
                        break;
                    } 
                }  
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            //Application.Exit();
            Close();
        }


        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked)
            {
                txbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txbMatKhau.UseSystemPasswordChar = true;
            }
        }

        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nleft,
            int ntop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int NHeightEllipse
        );

        private void btnDangNhap_Load(object sender, EventArgs e)
        {
            btnDN.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDN.Width, btnDN.Height, 10, 10));
            btnThoat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnThoat.Width, btnThoat.Height, 10, 10));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


//if (cbHienMK.Checked)
//{
// cbHienMK.BringToFront();