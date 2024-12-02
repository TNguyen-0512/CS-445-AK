using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DoAnTH
{
    public partial class QLSanPham : Form
    {
        Dictionary<string, CQLNuoc> dtNuoc;
        public QLSanPham()
        {
            dtNuoc = new Dictionary<string, CQLNuoc>();
            InitializeComponent();
        }
        CQLNuoc f = new CQLNuoc();
        private void hienthi()
        {
            dataGridQLNuoc.DataSource = dtNuoc.Values.ToList();
        }
        //private void btnThemNU_Click_1(object sender, EventArgs e)
        //{
        //    if (checkData())
        //    {
        //        CQLNuoc temp = new CQLNuoc();
        //        temp.TenSP = txtTen.Text;
        //        temp.SoLuong = txtSLuong.Text;
        //        temp.GiaTien = txtgiatien.Text;
        //        temp.Ngay = txtngay.Text;
        //        temp.ChucVu = txtChucVu.Text;
        //        dtNuoc.Add(temp.TenSP, temp);
        //        hienthi();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Trùng Tên Sản Phẩm");
        //    }
        //}
       
        private void btnSuaNU_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                int index = dataGridQLNuoc.CurrentRow.Index;

                dataGridQLNuoc.Rows[index].Cells[0].Value = txtTen.Text.ToString();
                dataGridQLNuoc.Rows[index].Cells[1].Value = txtSLuong.Text.ToString();
                dataGridQLNuoc.Rows[index].Cells[2].Value = txtgiatien.Text.ToString();
                dataGridQLNuoc.Rows[index].Cells[3].Value = txtngay.Text.ToString();
                dataGridQLNuoc.Rows[index].Cells[4].Value = txtChucVu.Text.ToString();
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (cbNU.Text == "Coffee")
            {

                using (TextWriter tw = new StreamWriter("csdlCapNhatCF.txt"))
                {
                    for (int i = 0; i < dataGridQLNuoc.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridQLNuoc.Columns.Count; j++)
                        {
                            tw.Write($"{dataGridQLNuoc.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridQLNuoc.Columns.Count - 1)
                            {
                                tw.Write("-");
                            }
                        }
                        tw.WriteLine();
                    }
                }
                MessageBox.Show("Lưu Vào Coffee Thành Công");
            }
            else if (cbNU.Text == "Trà Sữa")
            {
                using (TextWriter tw = new StreamWriter("csdlCapNhatTS.txt"))
                {
                    for (int i = 0; i < dataGridQLNuoc.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridQLNuoc.Columns.Count; j++)
                        {
                            tw.Write($"{dataGridQLNuoc.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridQLNuoc.Columns.Count - 1)
                            {
                                tw.Write("-");
                            }
                        }
                        tw.WriteLine(); 
                      
                    }
                }
                MessageBox.Show("Lưu Vào Trà Sữa Thành Công");
            }
            else
            {
                MessageBox.Show("Chọn Danh mục cần Lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên Món ", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số Lượng", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtgiatien.Text))
            {
                MessageBox.Show("Bạn chưa nhập Giá Tiền", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiatien.Focus(); 
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtngay.Text))
            {
                MessageBox.Show("Bạn chưa nhập Ngày", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngay.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtChucVu.Text))
            {
                MessageBox.Show("Bạn chưa nhập Chức Vụ", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngay.Focus();
                return false;
            }
            return true;
        }

        private void btnDoc_Click_1(object sender, EventArgs e)
        {
            if (cbNU.Text == "Coffee")
            {
                dataGridQLNuoc.Rows.Clear();
                dataGridQLNuoc.Refresh();

                var lines = File.ReadAllLines("csdlCapNhatCF.txt");
                if (lines.Count() > 0)
                {
                    foreach (var cellValues in lines.Skip(0))
                    {
                        var cellArray = cellValues.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cellArray.Length == dataGridQLNuoc.Columns.Count)
                            dataGridQLNuoc.Rows.Add(cellArray);

                    }
                }
               
            }
            else if (cbNU.Text == "Trà Sữa")
            {
                dataGridQLNuoc.Rows.Clear();
                dataGridQLNuoc.Refresh();
                var lines = File.ReadAllLines("csdlCapNhatTS.txt");
                if (lines.Count() > 0)
                {
                    foreach (var cellValues in lines.Skip(0))
                    {
                        var cellArray = cellValues.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cellArray.Length == dataGridQLNuoc.Columns.Count)
                            dataGridQLNuoc.Rows.Add(cellArray);

                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn Danh mục cần đọc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btnXoaNU_Click_1(object sender, EventArgs e)
        {

        }

        private void QLNuoc_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridQLNuoc_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridQLNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridQLNuoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridQLNuoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTen.Text = dataGridQLNuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSLuong.Text = dataGridQLNuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtgiatien.Text = dataGridQLNuoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtngay.Text = dataGridQLNuoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtChucVu.Text = dataGridQLNuoc.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            Close();
            ChuongTrinh f = new ChuongTrinh();
            f.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
