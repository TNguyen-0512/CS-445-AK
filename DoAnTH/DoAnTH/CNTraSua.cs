﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
namespace DoAnTH
{
    public partial class capnhatTS : Form
    {
        public capnhatTS()
        {
            InitializeComponent();
        }
        void PhanQuyen()
        {
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.NhanVien:
                    //  adminToolStripMenuItem.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.NhanVien1:
                    
                    break;
                case TaiKhoan.LoaiTK.Quanli:

                    break;
                case TaiKhoan.LoaiTK.Quanli1:

                    break;
            }

            //txtLoaiTK.Text = Const.TaiKhoan.TenHienThi;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (chbChon1.Checked || chbChon2.Checked || chbChon3.Checked || chbChon4.Checked || chbChon5.Checked)
            {
                //ẢNH 1
                if (chbChon1.Checked)
                {
                    File.Copy(txtanh1.Text, Path.Combine(Directory.GetCurrentDirectory() + @"\\Resources", Path.GetFileName(txtanh1.Text)), true);
                    string filePath1 = txtanh1.Text;
                    int vitri1 = filePath1.LastIndexOf("\\");
                    string ten = filePath1.Substring(vitri1 + 1);

                    using (StreamWriter w = new StreamWriter("anhTS1.txt"))
                    {

                        w.WriteLine(ten);
                    }
                }
                //ảnh 2
                if (chbChon2.Checked)
                {
                    File.Copy(txtanh2.Text, Path.Combine(Directory.GetCurrentDirectory() + @"\\Resources", Path.GetFileName(txtanh2.Text)), true);
                    string filePath2 = txtanh2.Text;
                    int vitri2 = filePath2.LastIndexOf("\\");
                    string ten2 = filePath2.Substring(vitri2 + 1);

                    using (StreamWriter w2 = new StreamWriter("anhTS2.txt"))
                    {

                        w2.WriteLine(ten2);
                    }
                }
                //ảnh 3
                if (chbChon3.Checked)
                {
                    File.Copy(txtanh3.Text, Path.Combine(Directory.GetCurrentDirectory() + @"\\Resources", Path.GetFileName(txtanh3.Text)), true);
                    string filePath3 = txtanh3.Text;
                    int vitri3 = filePath3.LastIndexOf("\\");
                    string ten3 = filePath3.Substring(vitri3 + 1);

                    using (StreamWriter w = new StreamWriter("anhTS3.txt"))
                    {

                        w.WriteLine(ten3);
                    }
                }
                //ảnh 4
                if (chbChon4.Checked)
                {
                    File.Copy(txtanh4.Text, Path.Combine(Directory.GetCurrentDirectory() + @"\\Resources", Path.GetFileName(txtanh4.Text)), true);
                    string filePath4 = txtanh4.Text;
                    int vitri4 = filePath4.LastIndexOf("\\");
                    string ten4 = filePath4.Substring(vitri4 + 1);

                    using (StreamWriter w = new StreamWriter("anhTS4.txt"))
                    {

                        w.WriteLine(ten4);
                    }
                }
                //ảnh 5
                if (chbChon5.Checked)
                {
                    File.Copy(txtanh5.Text, Path.Combine(Directory.GetCurrentDirectory() + @"\\Resources", Path.GetFileName(txtanh5.Text)), true);
                    string filePath5 = txtanh5.Text;
                    int vitri5 = filePath5.LastIndexOf("\\");
                    string ten5 = filePath5.Substring(vitri5 + 1);

                    using (StreamWriter w = new StreamWriter("anhTS5.txt"))
                    {
                        w.WriteLine(ten5);
                    }

                }
                MessageBox.Show("Lưu ảnh thành Công");
            }
            else
            {
                MessageBox.Show("Không thay đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        TextBox[] txtTents;
        TextBox[] txtGiats;
        TextBox[] txtConLaits;

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

        private void capnhatTS_Load(object sender, EventArgs e)
        {
            btnThoat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnThoat.Width, btnThoat.Height, 20, 20));
            btnCapNhat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCapNhat.Width, btnCapNhat.Height, 20, 20));
            panel3.Region= Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));


            string filePath = @"csdlCapNhatTS.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist :{0} ", filePath);
                return;
            }

            string[] textFromFile = File.ReadAllLines(filePath);
            txtTents = new TextBox[] { txtTS1, txtTS2, txtTS3, txtTS4, txtTS5 };
            txtGiats = new TextBox[] { txtGia1, txtGia2, txtGia3, txtGia4, txtGia5 };
            txtConLaits = new TextBox[] { txtConLai1, txtConLai2, txtConLai3, txtConLai4, txtConLai5 };

            for (int i = 0; i < textFromFile.ToArray().Length; i++)
            {
                string[] arrRes = textFromFile[i].Split('-');
                txtTents[i].Text = arrRes[0];
                txtConLaits[i].Text = arrRes[1];
                txtGiats[i].Text = arrRes[2];
               
            }
            //LOAD ảnh
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            ChuongTrinh f = new ChuongTrinh();
            f.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnanh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh1.Text = f.FileName;
                pictureBox1.Image = new Bitmap(f.FileName);
                txtanh1.Text = f.FileName;
            }
        }

        private void btnanh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh2.Text = f.FileName;
                pictureBox2.Image = new Bitmap(f.FileName);
                txtanh2.Text = f.FileName;
            }
        }

        private void btnanh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh3.Text = f.FileName;
                pictureBox3.Image = new Bitmap(f.FileName);
                txtanh3.Text = f.FileName;
            }
        }

        private void btnanh4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh4.Text = f.FileName;
                pictureBox4.Image = new Bitmap(f.FileName);
                txtanh4.Text = f.FileName;
            }
        }

        private void btnanh5_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All fileS(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtanh5.Text = f.FileName;
                pictureBox5.Image = new Bitmap(f.FileName);
                txtanh5.Text = f.FileName;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}