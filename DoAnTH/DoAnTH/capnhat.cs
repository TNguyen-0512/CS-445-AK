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
namespace DoAnTH
{
    public partial class capnhat : Form
    {
        public capnhat()
        {
            InitializeComponent();
        }


        private void btnCapnhat1_Click(object sender, EventArgs e)
        {

        }
        void PhanQuyen()
        {
            //if (Const.LoaiTaiKhoan == false)
            //    btnThem.Enabled = false;
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.NhanVien:
                    //  adminToolStripMenuItem.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.NhaCungCap:
                    // nmSoLuong.Enabled = txtGia.Enabled = txtcfs.Enabled = false;
                    //  adminToolStripMenuItem.Enabled = false;
                    break;
            }

            //txtLoaiTK.Text = Const.TaiKhoan.TenHienThi;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (chbChon1.Checked || chbChon2.Checked || chbChon3.Checked || chbChon4.Checked || chbChon5.Checked)
            {
                using (StreamWriter w = new StreamWriter("csdlCapNhat.txt"))
                {
                    //true = ghi tiep vao file, false = ghi de le du lieu cu,
                    ////neu file chua ton tai se dc tao ra, file test.txt cung cấp thư mục,
                    /////nếu ko phai chi rõ duong dẫn
                    w.WriteLine(txtcf1.Text + " - " + txtConLaicf1.Text + " - "
                        + txtGiacf1.Text + " - " + dateTimecf.Value + " - " + Const.TaiKhoan.TenHienThi);
                    w.WriteLine(txtTencf2.Text + " - " + txtConLaicf2.Text + " - "
                        + txtGiacf2.Text + " - " + dateTimecf.Value + " - " + Const.TaiKhoan.TenHienThi);
                    w.WriteLine(txtTencf3.Text + " - " + txtConLaicf3.Text + " - "
                        + txtGiacf3.Text + " - " + dateTimecf.Value + " - " + Const.TaiKhoan.TenHienThi);
                    w.WriteLine(txtTencf4.Text + " - " + txtConLaicf4.Text + " - "
                        + txtGiacf4.Text + " - " + dateTimecf.Value + " - " + Const.TaiKhoan.TenHienThi);
                    w.WriteLine(txtTencf5.Text + " - " + txtConLaicf5.Text + " - "
                        + txtGiacf5.Text + " - " + dateTimecf.Value + " - " + Const.TaiKhoan.TenHienThi);

                    MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Không thay đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void capnhat_Load(object sender, EventArgs e)
        {
            /*string s = "";
            StreamReader r = new StreamReader("csdlCapNhat.txt");*/
            /*while ((s = r.ReadLine()) != null)
            {
                //StreamReader r = new StreamReader("test.txt");
                string[] arrTeo = s.Split('-');
                txtcf1.Text = arrTeo[0];
                txtConLaicf1.Text = arrTeo[1];
                txtGiacf1.Text = arrTeo[2];
            }*/

            string filePath = @"csdlCapNhat.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist :{0} ", filePath);
                return;
            }

            string[] textFromFile = File.ReadAllLines(filePath);

            var tam = new string[] { txtcf1.Text, txtTencf2.Text };
            foreach (string s in textFromFile)
            {
                string[] arrTeo = s.Split('-');
                // MessageBox.Show(tam[1] = arrTeo[0]);
                txtcf1.Text = arrTeo[0];
                txtConLaicf1.Text = arrTeo[1];
                txtGiacf1.Text = arrTeo[2];
            }
        }
    }
}
