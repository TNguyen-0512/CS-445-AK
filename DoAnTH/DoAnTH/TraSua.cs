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
using System.IO;
namespace DoAnTH
{
    public partial class TraSua : Form
    {
        ChuongTrinh chuongtrinhts;
        public TraSua(ChuongTrinh ctrinh)
        {
            InitializeComponent();
            this.chuongtrinhts = ctrinh;

        }
        private int Random()
        {
            Random random = new Random();
            return random.Next(100000, 10000000); // 100 000 <= X <=9 999 999
        }
        private string TrangThai()
        {
            string trangthai = "Chưa Thanh Toán";
            return trangthai;
        }
         void PhanQuyen()
        {
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.NhanVien:
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

        private void btnXong_Click(object sender, EventArgs e)
        {
            if (chbMangVe.Checked || chbTaiCho.Checked && txtSoBan.Text != "")
            {
                if (cbChon.Checked && cbChon1.Checked && cbChon2.Checked && cbChon3.Checked && cbChon4.Checked)//1-2-3-4-5
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text,cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text,cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text,cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();


                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon.Checked && cbChon2.Checked && cbChon3.Checked && cbChon4.Checked) //0-2-3-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text,  cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon.Checked && cbChon1.Checked && cbChon2.Checked && cbChon3.Checked)//0-1-2-3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text,cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();


                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                }
                else if (cbChon.Checked && cbChon1.Checked && cbChon2.Checked && cbChon4.Checked)//0-1-2-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text,cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text,cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();


                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon.Checked && cbChon1.Checked && cbChon3.Checked && cbChon4.Checked) //0-1-3-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text,cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text,cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon1.Checked && cbChon2.Checked && cbChon3.Checked && cbChon4.Checked)//1-2-3-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text,cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text,cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();


                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon1.Checked && cbChon3.Checked && cbChon4.Checked) //1-3-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text,  cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon2.Checked && cbChon3.Checked && cbChon4.Checked) //2-3-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon1.Checked && cbChon2.Checked && cbChon3.Checked) //1-2-3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text,cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();


                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();
                }
                else if (cbChon1.Checked && cbChon2.Checked && cbChon4.Checked) //1-2-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text,cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon.Checked && cbChon3.Checked && cbChon4.Checked) //0-3-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text,cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon.Checked && cbChon2.Checked && cbChon3.Checked) //0-2-3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text,cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();
                }
                else if (cbChon.Checked && cbChon2.Checked && cbChon4.Checked) //0-2-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon.Checked && cbChon1.Checked && cbChon2.Checked) //0-1-2
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text,cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text,  cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();


                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();
                }
                else if (cbChon.Checked && cbChon1.Checked && cbChon3.Checked) //0-1-3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();
                }
                else if (cbChon.Checked && cbChon1.Checked && cbChon4.Checked) //0-1-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value,Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();

                }
                else if (cbChon3.Checked && cbChon4.Checked) //3-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text,cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon2.Checked && cbChon4.Checked) //2-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text,cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text,cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();

                }
                else if (cbChon2.Checked && cbChon3.Checked) //2-3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text,cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();
                }
                else if (cbChon1.Checked && cbChon4.Checked) //1-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text,cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon1.Checked && cbChon3.Checked)//1-3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text,cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();
                }
                else if (cbChon1.Checked && cbChon2.Checked)//1-2
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();
                }
                else if (cbChon.Checked && cbChon4.Checked)//0-4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text, cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a8 = Convert.ToDouble(txtConLai4.Text);
                    double a9 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a8 - a9).ToString();
                }
                else if (cbChon.Checked && cbChon3.Checked)//0-3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text, cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a6 = Convert.ToDouble(txtConLai3.Text);
                    double a7 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a6 - a7).ToString();
                }
                else if (cbChon.Checked && cbChon2.Checked)//0-2
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text, cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);

                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a4 = Convert.ToDouble(txtConLai2.Text);
                    double a5 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a4 - a5).ToString();
                }
                else if (cbChon.Checked && cbChon1.Checked)//0-1
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text,cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text,cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();

                    double a2 = Convert.ToDouble(txtConLai1.Text);
                    double a3 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a2 - a3).ToString();
                }
                else if (cbChon.Checked)//0
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttstt.Text, cb.Text, nmSoLuong.Value, txtGia.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai.Text);
                    double a1 = Convert.ToDouble(nmSoLuong.Text);
                    txtConLai.Text = (a - a1).ToString();
                
                }
                else if (cbChon1.Checked)//1
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttcdd2.Text, cb1.Text, nmSoLuong1.Value, txtGia1.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai1.Text);
                    double a1 = Convert.ToDouble(nmSoLuong1.Text);
                    txtConLai1.Text = (a - a1).ToString();
                }
                else if (cbChon2.Checked)//2
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsd3.Text,cb2.Text, nmSoLuong2.Value, txtGia2.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai2.Text);
                    double a1 = Convert.ToDouble(nmSoLuong2.Text);
                    txtConLai2.Text = (a - a1).ToString();
                }
                else if (cbChon3.Checked)//3
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttsbh5.Text,cb3.Text, nmSoLuong3.Value, txtGia3.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai3.Text);
                    double a1 = Convert.ToDouble(nmSoLuong3.Text);
                    txtConLai3.Text = (a - a1).ToString();
                }
                else if (cbChon4.Checked)//4
                {
                    chuongtrinhts.dgvThanhToan.Rows.Add(Random(), txttssocola.Text,cb4.Text, nmSoLuong4.Value, txtGia4.Text, txtHinhThuc.Text + " " + txtSoBan.Text, TrangThai(), dateTimets.Value, Const.TaiKhoan.TenHienThi);
                    double a = Convert.ToDouble(txtConLai4.Text);
                    double a1 = Convert.ToDouble(nmSoLuong4.Text);
                    txtConLai4.Text = (a - a1).ToString();
                }
            }
            if (!chbMangVe.Checked && !chbTaiCho.Checked)
            {
                if (cbChon.Checked)
                {
                    double c = 0;
                    txtThanhTien.Text = c.ToString();
                    MessageBox.Show("Thoát - Chọn Lại Hình Thức1", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!cbChon.Checked && !cbChon1.Checked && !cbChon2.Checked && !cbChon3.Checked && !cbChon4.Checked)
                {
                    double c = 0;
                    txtThanhTien.Text = c.ToString();

                    //  MessageBox.Show("Thoát - Chọn Lại Hình Thức", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else if (!cbChon.Checked && !cbChon1.Checked && !cbChon2.Checked && !cbChon3.Checked && !cbChon4.Checked && chbTaiCho.Checked || chbMangVe.Checked)
            {
                double c = 0;
                txtThanhTien.Text = c.ToString();

                //  MessageBox.Show("Thoát - Chọn Lại Hình Thức", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                double c = 0;
                txtThanhTien.Text = c.ToString();
               // MessageBox.Show("Thoát - Chọn Lại Hình Thức2", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //else if (cbChon.Checked || cbChon1.Checked || cbChon2.Checked || cbChon3.Checked || cbChon4.Checked && !chbTaiCho.Checked && !chbMangVe.Checked)
            //{
            //    double c = 0;
            //    txtThanhTien.Text = c.ToString();
            //    MessageBox.Show("Thoát - Chọn Lại Hình Thức", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //else if (!chbTaiCho.Checked && !chbMangVe.Checked)
            //{
            //    double c = 0;
            //    txtThanhTien.Text = c.ToString();

            //    MessageBox.Show("Thoát - Chọn Lại Hình Thức", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            chuongtrinhts.txttients.Text = txtThanhTien.Text;
            chuongtrinhts.txt11.Text = txt11.Text;
            chuongtrinhts.txt12.Text = txt12.Text;
            chuongtrinhts.txt13.Text = txt13.Text;
            chuongtrinhts.txt21.Text = txt21.Text;
            chuongtrinhts.txt22.Text = txt22.Text;
            chuongtrinhts.txt23.Text = txt23.Text;
            chuongtrinhts.txt31.Text = txt31.Text;
            chuongtrinhts.txt32.Text = txt32.Text;
            chuongtrinhts.txt33.Text = txt33.Text;

            using (StreamWriter w = new StreamWriter("csdlCapNhatTS.txt"))
            {
                //true = ghi tiep vao file, false = ghi de le du lieu cu,
                ////neu file chua ton tai se dc tao ra, file csdlCapNhat.txt cung cấp thư mục,
                /////nếu ko phai chi rõ duong dẫn
                w.WriteLine(txttstt.Text + "-" + txtConLai.Text + "-"
                    + txtGia.Text + "-" + dateTimets.Value + "-" + Const.TaiKhoan.TenHienThi);
                w.WriteLine(txttcdd2.Text + "-" + txtConLai1.Text + "-"
                    + txtGia1.Text + "-" + dateTimets.Value + "-" + Const.TaiKhoan.TenHienThi);
                w.WriteLine(txttsd3.Text + "-" + txtConLai2.Text + "-"
                    + txtGia2.Text + "-" + dateTimets.Value + "-" + Const.TaiKhoan.TenHienThi);
                w.WriteLine(txttsbh5.Text + "-" + txtConLai3.Text + "-"
                    + txtGia3.Text + "-" + dateTimets.Value + "-" + Const.TaiKhoan.TenHienThi);
                w.WriteLine(txttssocola.Text + "-" + txtConLai4.Text + "-"
                    + txtGia4.Text + "-" + dateTimets.Value + "-" + Const.TaiKhoan.TenHienThi);
            }
                Close();
            ChuongTrinh f = new ChuongTrinh();
            f.Hide();
        }
        TextBox[] txtTents;
        TextBox[] txtGiats;
        TextBox[] txtConLaits;
        Button[] tbtnIDBan;
        TextBox[] txtTrangThai;
        TextBox[] txttenanh;

        TextBox[] txttenanh1;
        TextBox[] txttenanh2;
        TextBox[] txttenanh3;
        TextBox[] txttenanh4;
        TextBox[] txttenanh5;
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


        private void TraSua_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            // text tròn
            btnThoat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnThoat.Width, btnThoat.Height, 20, 20));
            btnXong.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnXong.Width, btnXong.Height, 20, 20));


            //load sản phẩm
            string filePath = @"csdlCapNhatTS.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist :{0} ", filePath);
                return;
            }

            string[] textFromFile = File.ReadAllLines(filePath);
            txtTents = new TextBox[] { txttstt, txttcdd2, txttsd3, txttsbh5, txttssocola };
            txtGiats = new TextBox[] { txtGia, txtGia1, txtGia2, txtGia3, txtGia4 };
            txtConLaits = new TextBox[] { txtConLai, txtConLai1, txtConLai2, txtConLai3, txtConLai4 };

            for (int i = 0; i < textFromFile.ToArray().Length; i++)
            {
                string[] arrRes = textFromFile[i].Split('-');
                txtTents[i].Text = arrRes[0];
                txtConLaits[i].Text = arrRes[1];
                txtGiats[i].Text = arrRes[2];

            }
            //load bàn

            string filePathban = @"csdlCapNhatBan.txt";
            if (!File.Exists(filePathban))
            {
                Console.WriteLine("File does not exist :{0} ", filePathban);
                return;
            }

            string[] textFromFileban = File.ReadAllLines(filePathban);
            tbtnIDBan = new Button[] { btnBan11, btnBan12, btnBan13, btnBan21, btnBan22, btnBan23, btnBan31, btnBan32, btnBan33 };
            txtTrangThai = new TextBox[] { txt11, txt12, txt13,txt21, txt22, txt23, txt31, txt32, txt33 };
           

            for (int i = 0; i < textFromFileban.ToArray().Length; i++)
            {
                string[] arrRes1 = textFromFileban[i].Split('-');
                tbtnIDBan[i].Text = arrRes1[0];
                txtTrangThai[i].Text = arrRes1[1];
               

            }

            //load topping 
            string filePathtopping = @"TOPPING.txt";
            if (!File.Exists(filePathtopping))
            {
                Console.WriteLine("File does not exist :{0} ", filePathtopping);
                return;
            }

            string[] textFromFiletopping = File.ReadAllLines(filePathtopping);


            for (int i = 0; i < textFromFiletopping.ToArray().Length; i++)
            {
                string[] arrRes1 = textFromFiletopping[i].Split('-');

                cb.Items.AddRange(arrRes1);
                cb1.Items.AddRange(arrRes1);
                cb2.Items.AddRange(arrRes1);
                cb3.Items.AddRange(arrRes1);
                cb4.Items.AddRange(arrRes1);
               
            }


            //load ảnh1 
            string filePathanh1 = @"anhTS1.txt";
            if (!File.Exists(filePathanh1))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh1);
                return;
            }

            string[] textFromFileanh1 = File.ReadAllLines(filePathanh1);
            txttenanh1 = new TextBox[] { txtanh1 };
            for (int i = 0; i < textFromFileanh1.ToArray().Length; i++)
            {
                string[] arrRes11 = textFromFileanh1[i].Split('/');
                txttenanh1[i].Text = arrRes11[0];
            }
            string filePath1 = txtanh1.Text;
            pictureBox1.Image = Image.FromFile(@"resources\\" + filePath1);

            // Load anh 2
            string filePathanh22 = @"anhTS2.txt";
            if (!File.Exists(filePathanh22))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh22);
                return;
            }

            string[] textFromFileanh22 = File.ReadAllLines(filePathanh22);
            txttenanh2 = new TextBox[] { txtanh2 };
            for (int i = 0; i < textFromFileanh22.ToArray().Length; i++)
            {
                string[] arrRes22 = textFromFileanh22[i].Split('/');
                txttenanh2[i].Text = arrRes22[0];
            }
            string filePath22 = txtanh2.Text;
            pictureBox2.Image = Image.FromFile(@"resources\\" + filePath22);

            // Load anh 3
            string filePathanh33 = @"anhTS3.txt";
            if (!File.Exists(filePathanh33))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh33);
                return;
            }

            string[] textFromFileanh33 = File.ReadAllLines(filePathanh33);
            txttenanh3 = new TextBox[] { txtanh3 };
            for (int i = 0; i < textFromFileanh33.ToArray().Length; i++)
            {
                string[] arrRes33 = textFromFileanh33[i].Split('/');
                txttenanh3[i].Text = arrRes33[0];
            }
            string filePath33 = txtanh3.Text;
            pictureBox3.Image = Image.FromFile(@"resources\\" + filePath33);


            // Load anh 4
            string filePathanh44 = @"anhTS4.txt";
            if (!File.Exists(filePathanh44))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh44);
                return;
            }

            string[] textFromFileanh44 = File.ReadAllLines(filePathanh44);
            txttenanh4 = new TextBox[] { txtanh4 };
            for (int i = 0; i < textFromFileanh44.ToArray().Length; i++)
            {
                string[] arrRes44 = textFromFileanh44[i].Split('/');
                txttenanh4[i].Text = arrRes44[0];
            }
            string filePath44 = txtanh4.Text;
            pictureBox4.Image = Image.FromFile(@"resources\\" + filePath44);

            // Load anh 5
            string filePathanh55 = @"anhTS5.txt";
            if (!File.Exists(filePathanh55))
            {
                Console.WriteLine("File does not exist :{0} ", filePathanh55);
                return;
            }

            string[] textFromFileanh55 = File.ReadAllLines(filePathanh55);
            txttenanh5 = new TextBox[] { txtanh5 };
            for (int i = 0; i < textFromFileanh55.ToArray().Length; i++)
            {
                string[] arrRes55 = textFromFileanh55[i].Split('/');
                txttenanh5[i].Text = arrRes55[0];
            }
            string filePath55 = txtanh5.Text;
            pictureBox5.Image = Image.FromFile(@"resources\\" + filePath55);
        }

      


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbChon_CheckedChanged(object sender, EventArgs e)
        {
            double tong = 0;

            if (cbChon.Checked)
            {
                double a = Convert.ToDouble(txtGia.Text);
                double b = Convert.ToDouble(nmSoLuong.Value);
                double d = Convert.ToDouble(txtConLai.Text);
                if (b <= d)
                {
                    double c = a * b;
                    tong = c;
                }
                else
                {
                    MessageBox.Show("Chọn Lại TS Truyền Thống", "Thông Báo");
                }
                Console.WriteLine(tong);
                txtThanhTien0.Text = tong.ToString();
                txtThanhTien.Text = txtThanhTien0.Text;
            }
            else if (!cbChon.Checked)
            {
                txtThanhTien.Text = "0";
            }
            double aa = 0;
            txtThanhTien.Text = aa.ToString();
            
        }

        private void txtThanhTien0_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblThanhTien0_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        

        private void cbChon2_CheckedChanged(object sender, EventArgs e)
        {
            double tong = 0;

            if (cbChon1.Checked)
            {
                double a = Convert.ToDouble(txtGia1.Text);
                double b = Convert.ToDouble(nmSoLuong1.Value);
                double d = Convert.ToDouble(txtConLai1.Text);
                if (b <= d)
                {
                    double c = a * b;
                    tong = c;
                }
                else
                {
                    MessageBox.Show("Chọn Lại TS Đường Đen", "Thông Báo");
                }
                Console.WriteLine(tong);
                txtThanhTien1.Text = tong.ToString();
                txtThanhTien.Text = txtThanhTien1.Text;

            }
            else if (!cbChon1.Checked)
            {
                txtThanhTien1.Text = "0";
            }
            double aa=0;
            txtThanhTien.Text = aa.ToString();
        }

        private void cbChon3_CheckedChanged(object sender, EventArgs e)
        {
            double tong = 0;

            if (cbChon4.Checked)
            {
                double a = Convert.ToDouble(txtGia4.Text);
                double b = Convert.ToDouble(nmSoLuong4.Value);
                double d = Convert.ToDouble(txtConLai4.Text);
                if (b <= d)
                {
                    double c = a * b;
                    tong = c;
                }
                else
                {
                    MessageBox.Show("Chọn Lại Trà sữa thái xanh", "Thông Báo");
                }
                Console.WriteLine(tong);
                txtThanhTien4.Text = tong.ToString();
                txtThanhTien.Text = txtThanhTien4.Text;
            }
            else if (!cbChon4.Checked)
            {
                txtThanhTien4.Text = "0";
            }
            double aa = 0;
            txtThanhTien.Text = aa.ToString();
        }

        private void cbChon4_CheckedChanged(object sender, EventArgs e)
        {
            double tong = 0;

            if (cbChon2.Checked)
            {
                double a = Convert.ToDouble(txtGia2.Text);
                double b = Convert.ToDouble(nmSoLuong2.Value);
                double d = Convert.ToDouble(txtConLai2.Text);
                if (b <= d)
                {
                    double c = a * b;
                    tong = c;
                }
                else
                {
                    MessageBox.Show("Chọn Lại TS Đào", "Thông Báo");
                }
                Console.WriteLine(tong);
                txtThanhTien2.Text = tong.ToString();
                txtThanhTien.Text = txtThanhTien2.Text;
            }
            else if (!cbChon2.Checked)
            {
                txtThanhTien2.Text = "0";
            }
            double aa = 0;
            txtThanhTien.Text = aa.ToString();
        }

        private void cbChon5_CheckedChanged(object sender, EventArgs e)
        {
            double tong = 0;

            if (cbChon3.Checked)
            {
                double a = Convert.ToDouble(txtGia3.Text);
                double b = Convert.ToDouble(nmSoLuong3.Value);
                double d = Convert.ToDouble(txtConLai3.Text);
                if (b <= d)
                {
                    double c = a * b;
                    tong = c;
                }
                else
                {
                    MessageBox.Show("Chọn Lại TS Bạc Hà", "Thông Báo");
                }
                Console.WriteLine(tong);
                txtThanhTien53.Text = tong.ToString();
                txtThanhTien.Text = txtThanhTien53.Text;
            }
            else if (!cbChon3.Checked)
            {
                txtThanhTien53.Text = "0";
            }
            double aa = 0;
            txtThanhTien.Text = aa.ToString();
        }

        //private void txtThanhTien_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        private void txtThanhTien_TextChanged_1(object sender, EventArgs e)
        {
            double aa, a0, a2, a3, a4, a5, a6;
            if (cbChon.Checked || /*cbChon1.Checked  ||*/ cbChon1.Checked || cbChon4.Checked || cbChon2.Checked || cbChon3.Checked)
            {
                a0 = Convert.ToDouble(txtThanhTien0.Text);
                // a1 = Convert.ToDouble(txtThanhTien1.Text);
                a2 = Convert.ToDouble(txtThanhTien1.Text);
                a3 = Convert.ToDouble(txtThanhTien4.Text);
                a4 = Convert.ToDouble(txtThanhTien2.Text);
                a5 = Convert.ToDouble(txtThanhTien53.Text);

                aa = a0 + /*a1*/ +a2 + a3 + a4 + a5;
                txtThanhTien.Text = aa.ToString();
            }
            else if (!cbChon.Checked || /*!cbChon1.Checked  ||*/ !cbChon1.Checked || !cbChon4.Checked || !cbChon2.Checked || !cbChon3.Checked)
            {

                a2 = Convert.ToDouble(txtThanhTien1.Text);
                a3 = Convert.ToDouble(txtThanhTien4.Text);
                a4 = Convert.ToDouble(txtThanhTien2.Text);
                a5 = Convert.ToDouble(txtThanhTien53.Text);
                a6 = Convert.ToDouble(txtThanhTien.Text);
                aa = a6 - a5 - a4 - a3 - a2;
                txtThanhTien.Text = aa.ToString();
            }
        }

        private void nmSoLuong_ValueChanged(object sender, EventArgs e)
        {
            cbChon_CheckedChanged(sender, e);
        }

        private void nmSoLuong2_ValueChanged(object sender, EventArgs e)
        {
            cbChon2_CheckedChanged(sender, e);
        }

        private void nmSoLuong4_ValueChanged(object sender, EventArgs e)
        {
            cbChon4_CheckedChanged(sender, e);
        }

        private void nmSoLuong5_ValueChanged(object sender, EventArgs e)
        {
            cbChon5_CheckedChanged(sender, e);

        }

        private void nmSoLuong3_ValueChanged(object sender, EventArgs e)
        {
            cbChon3_CheckedChanged(sender, e);
        }

      

        private void groupBox6_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtSoBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbMangVe_CheckedChanged(object sender, EventArgs e)
        {

            if (chbMangVe.Checked)
            {
                //  txtMangVe.Text = "Mang Về";
                chbTaiCho.Enabled = pnlhinhThuc.Enabled = false;
                string hinhthuc = "Mang Về";
                txtHinhThuc.Text = hinhthuc;
            }
            else if (!chbMangVe.Checked)
            {
                chbTaiCho.Enabled = pnlhinhThuc.Enabled = true;
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

                txtSoBan.Text = "";
            }
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt11.Text = a;
            txtSoBan.Text = btnBan11.Text;
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt12.Text = a;
            txtSoBan.Text = btnBan12.Text;
        }

        private void btnBan13_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt13.Text = a;
            txtSoBan.Text = btnBan13.Text;

        }

        private void btnBan21_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt21.Text = a;
            txtSoBan.Text = btnBan21.Text;
        }

        private void btnBan22_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt22.Text = a;
            txtSoBan.Text = btnBan22.Text;
        }

        private void btnBan23_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt23.Text = a;
            txtSoBan.Text = btnBan23.Text;
        }

        private void btnBan31_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt31.Text = a;
            txtSoBan.Text = btnBan31.Text;
        }

        private void btnBan32_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt32.Text = a;
            txtSoBan.Text = btnBan32.Text;
        }

        private void btnBan33_Click(object sender, EventArgs e)
        {
            string a = "Có Khách";
            txt33.Text = a;
            txtSoBan.Text = btnBan33.Text;
        }

        private void btntra11_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt11.Text = a;
        }

        private void btntra12_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt12.Text = a;
        }

        private void btntra13_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt13.Text = a;
        }

        private void btntra21_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt21.Text = a;
        }

        private void btntra22_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt22.Text = a;
        }

        private void btntra23_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt23.Text = a;
        }

        private void btntra31_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt31.Text = a;
        }

        private void btntra32_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt32.Text = a;
        }

        private void btntra33_Click(object sender, EventArgs e)
        {
            string a = "Trống";
            txt33.Text = a;
        }

        private void pnlhinhThuc_Paint(object sender, PaintEventArgs e)
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
                    w.WriteLine(btnBan11.Text + "-" + txt11.Text + "-"
                        + dateTimets.Value);
                    w.WriteLine(btnBan12.Text + "-" + txt12.Text + "-"
                        + dateTimets.Value);
                    w.WriteLine(btnBan13.Text + "-" + txt13.Text + "-"
                        + dateTimets.Value);
                    w.WriteLine(btnBan21.Text + "-" + txt21.Text + "-"
                        + dateTimets.Value);
                    w.WriteLine(btnBan22.Text + "-" + txt22.Text + "-"
                        + dateTimets.Value);
                    w.WriteLine(btnBan23.Text + "-" + txt23.Text + "-"
                       + dateTimets.Value);
                    w.WriteLine(btnBan31.Text + "-" + txt31.Text + "-"
                       + dateTimets.Value);
                    w.WriteLine(btnBan32.Text + "-" + txt32.Text + "-"
                       + dateTimets.Value);
                    w.WriteLine(btnBan33.Text + "-" + txt33.Text + "-"
                       + dateTimets.Value);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox5_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
