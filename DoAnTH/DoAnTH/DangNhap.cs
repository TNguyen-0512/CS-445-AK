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
    public partial class btnDangNhap : Form
    {
        public btnDangNhap()
        {
            InitializeComponent();
        }

        public void btnDN_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            string maTK = "user1";
           // tk mk mặc định ADMIN  
            if (user.Equals(txbTaiKhoan.Text) && pass.Equals(txbMatKhau.Text)) //so sánh chuỗi nếu đúng     
            {
                MessageBox.Show("Đăng Nhập Thành Công","Thông Báo"); // xuất đăng nhập thành công và vào trong chương trình chính 
                ChuongTrinh f=new ChuongTrinh();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi chương trình?","Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}
