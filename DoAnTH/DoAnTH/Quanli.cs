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
    public partial class Quanli : Form
    {
        public Quanli()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemm_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnXemNU_Click(object sender, EventArgs e)
        {

        }


        List<Caffee> cafe = new List<Caffee>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbNU.Text == "Coffee")
            {
                try
                {
                    string parth = Application.StartupPath + "\\csdlLuuCF.txt";
                    bool kt = fileLuuLSMua.FileLuu(cafe, parth);
                    if (kt == true)
                    {
                        MessageBox.Show("Lưu vào Caffee thành Công");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (cbNU.Text == "Trà Sữa")
            {
                try
                {
                    string parth = Application.StartupPath + "\\csdlLuuTS.txt";
                    bool kt = fileLuuLSMua.FileLuu(cafe, parth);
                    if (kt == true)
                    {
                        MessageBox.Show("Lưu vào Trà Sữa thành Công");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chọn Lại Danh Mục !", "Thông Báo");
            }


        }

        private void btnThemNU_Click(object sender, EventArgs e)
        {


            if (txtID.Text != null && txtTenMon != null && txtSoLuong != null && txtGia != null)
            {
                Caffee cf = new Caffee();
                cf.ID = txtID.Text;
                cf.tenMon = txtTenMon.Text;
                cf.soLuong = double.Parse(txtSoLuong.Text);
                cf.Gia = double.Parse(txtGia.Text);
                cafe.Add(cf);
                HienThiDSLenListbox();
            }
            else
                MessageBox.Show("Nhập dữ liệu!", "Thông Báo");


        }


        private void HienThiDSLenListbox()
        {
            listQLNuoc.Items.Clear();
            foreach (Caffee dh in cafe)
            {
                listQLNuoc.Items.Add(dh);
            }
        }


        private void btnDoc_Click(object sender, EventArgs e)
        {
            // string cbnuoc = string.Empty.ToString(cbNU.Text);
            if (cbNU.Text == "Coffee")
            {
                try
                {
                    string parth = Application.StartupPath + "\\csdlLuuCF.txt";
                    cafe = fileLuuLSMua.DocFile(parth);
                    HienThiDSLenListbox();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else if (cbNU.Text == "Trà Sữa")
            {
                try
                {
                    string parth = Application.StartupPath + "\\csdlLuuTS.txt";
                    cafe = fileLuuLSMua.DocFile(parth);
                    HienThiDSLenListbox();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Chọn Lại Danh Mục!", "Thông Báo");
            }

        }

        private void btnXoaNU_Click(object sender, EventArgs e)
        {
           // string s = "";
            for (int i = 0; i < listQLNuoc.Items.Count; i++)
            {
                if (listQLNuoc.GetSelected(i) == true)
                    listQLNuoc.Items.RemoveAt(i);
            }
        }
    }
}
