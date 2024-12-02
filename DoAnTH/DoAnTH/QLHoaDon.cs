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
   
    public partial class QLHoaDon : Form
    {
        Dictionary<string, HoaDon> hd;
      
        public QLHoaDon()
        {
              hd = new Dictionary<string, HoaDon>();
            InitializeComponent();
          //  LoadDataGridView();
        }

        private void dgvThanhToan_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtHoaDon.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID Hóa Đơn", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoaDon.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSP.Focus();
                return false;
            }
            //if (string.IsNullOrWhiteSpace(cbxTopping.Text))
            //{
            //    MessageBox.Show("Bạn chưa nhập Topping", "Thông Báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cbxTopping.Focus();
            //    return false;
            //}
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số lượng", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập Giá", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHinhThuc.Text))
            {
                MessageBox.Show("Bạn chưa nhập hình thức", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHinhThuc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTrangThai.Text))
            {
                MessageBox.Show("Bạn chưa nhập trạng thái", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTrangThai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(datimeNgayMua.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày mua", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                datimeNgayMua.Focus();
                return false;
            }
            return true;
        }
        private void QLHoaDon_Load(object sender, EventArgs e)
        {

            //load hóa đơn
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


            //load topping 
            string filePathtopping = @"TOPPING.txt";
            if (!File.Exists(filePathtopping))
            {
                Console.WriteLine("File does not exist:{0} ", filePathtopping);
                return;
            }

            string[] textFromFiletopping = File.ReadAllLines(filePathtopping);

            for (int i = 0; i < textFromFiletopping.ToArray().Length; i++)
            {
                string[] arrRes1 = textFromFiletopping[i].Split('-');
                cbxTopping.Items.AddRange(arrRes1);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = dgvThanhToan.CurrentRow.Index;
            string a = dgvThanhToan.Rows[index].Cells[0].Value.ToString();
            string b = txtHoaDon.Text;
            if (checkData() &&a != b)
            {

                DataGridViewRow row = (DataGridViewRow)dgvThanhToan.Rows[0].Clone();
                row.Cells[0].Value = txtHoaDon.Text;
                row.Cells[1].Value = txtTenSP.Text;
                row.Cells[2].Value = cbxTopping.Text;
                row.Cells[3].Value = txtSoLuong.Text;
                row.Cells[4].Value = txtGia.Text;
                row.Cells[5].Value = txtHinhThuc.Text;
                row.Cells[6].Value = txtTrangThai.Text;
                row.Cells[7].Value = datimeNgayMua.Value;
                row.Cells[8].Value = txtNguoiBan.Text;
                dgvThanhToan.Rows.Add(row);
                txtHoaDon.Text = "";
                txtTenSP.Text = "";
                cbxTopping.Text="";
                txtSoLuong.Text ="";
                txtGia.Text = "";
                txtHinhThuc.Text = "";
                txtTrangThai.Text = "";
                txtNguoiBan.Text="";
            }
            else if( a == b)
                MessageBox.Show("ID Đã Tồn Tại-Nhập ID MỚI","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvThanhToan.CurrentRow.Index;
            string a = dgvThanhToan.Rows[index].Cells[0].Value.ToString();
            string b = txtHoaDon.Text;
            if (a == b)
            {
                MessageBox.Show("Đã Xóa Thông Tin Hóa Đơn Có ID: "+ dgvThanhToan.Rows[index].Cells[0].Value,
                "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dgvThanhToan.Rows.Remove(dgvThanhToan.Rows[index]);
                dgvThanhToan.Refresh();
            }
            else
            MessageBox.Show("Khác ID Không Xóa Được", "Thông Báo");
        }

        private void dgvThanhToan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
/*            if (e.RowIndex >= 0)
            {
                txtHoaDon.Text = dgvThanhToan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvThanhToan.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbxTopping.Text = dgvThanhToan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvThanhToan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGia.Text = dgvThanhToan.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtHinhThuc.Text = dgvThanhToan.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTrangThai.Text = dgvThanhToan.Rows[e.RowIndex].Cells[6].Value.ToString();
                datimeNgayMua.Value = Convert.ToDateTime(dgvThanhToan.Rows[e.RowIndex].Cells[7].Value);
                txtNguoiBan.Text = dgvThanhToan.Rows[e.RowIndex].Cells[8].Value.ToString();
            }*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                int index = dgvThanhToan.CurrentRow.Index;

                dgvThanhToan.Rows[index].Cells[0].Value = txtHoaDon.Text.ToString();
                dgvThanhToan.Rows[index].Cells[1].Value = txtTenSP.Text.ToString();
                dgvThanhToan.Rows[index].Cells[2].Value = cbxTopping.Text.ToString();
                dgvThanhToan.Rows[index].Cells[3].Value = txtSoLuong.Text.ToString();
                dgvThanhToan.Rows[index].Cells[4].Value = txtGia.Text.ToString();
                dgvThanhToan.Rows[index].Cells[5].Value = txtHinhThuc.Text.ToString();
                dgvThanhToan.Rows[index].Cells[6].Value = txtTrangThai.Text.ToString();
                dgvThanhToan.Rows[index].Cells[7].Value = datimeNgayMua.Value.ToString();
                dgvThanhToan.Rows[index].Cells[8].Value = txtNguoiBan.Text.ToString();
                MessageBox.Show("Đã Sửa Thông Tin Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Không Thể Sửa Thông Tin Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        private void btnLuuFile_Click(object sender, EventArgs e)
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
            MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        public void hienthi()
        {
            dgvThanhToan.DataSource = dgvThanhToan.Rows.Count.ToString();
            
            // dgvThanhToan.DataSource=data
        }

        private void cbHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = txtHoaDon.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbHoaDon.Checked == true)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;

                        }
                    }
                }

            }
            catch (Exception exc)
            {
                //MessageBox.Show("Không tìm thấy");
            }

        }

        private void cbTenSP_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = txtTenSP.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbTenSP.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;

                        }
                    }
                }
            }
            catch (Exception exc)
            {
               
            }
        
        }
        private void CBTopping_CheckedChanged(object sender, EventArgs e)
        {

            string searchValue = cbxTopping.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (CBTopping.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[2].Value != null && row.Cells[2].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }  
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void cbSoLuong_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = txtSoLuong.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbSoLuong.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[3].Value != null && row.Cells[3].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exc)
            { }

        }

        private void cbGia_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = txtGia.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbGia.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[4].Value != null && row.Cells[4].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void cbHinhThuc_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = txtHinhThuc.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbHinhThuc.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[5].Value != null && row.Cells[5].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void cbTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = txtTrangThai.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbTrangThai.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[6].Value != null && row.Cells[6].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void cbngay_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = datimeNgayMua.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbngay.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[7].Value != null && row.Cells[7].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void cbnguoiban_CheckedChanged(object sender, EventArgs e)
        {
            string searchValue = txtNguoiBan.Text;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                if (cbnguoiban.Checked)
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            if (row.Cells[8].Value != null && row.Cells[8].Value.ToString().Equals(searchValue))
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = true;
                                valueResult = true;
                            }
                            else
                            {
                                dgvThanhToan.Rows[rowIndex].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgvThanhToan.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            int rowIndex = row.Index;
                            dgvThanhToan.Rows[rowIndex].Visible = true;
                        }
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbSapXep.Text == "ID Hóa Đơn")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[0], ListSortDirection.Ascending);
            }
            else if (cbbSapXep.Text=="Tên Sản Phẩm")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[1], ListSortDirection.Ascending);
            }
            else if (cbbSapXep.Text == "Topping")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[2], ListSortDirection.Ascending);
            }
            else if(cbbSapXep.Text == "Số Lượng")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[3], ListSortDirection.Ascending);
            }
            else if(cbbSapXep.Text == "Giá Bán")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[4], ListSortDirection.Ascending);
            }
            else if(cbbSapXep.Text == "Hình Thức")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[5], ListSortDirection.Ascending);
            }
            else if (cbbSapXep.Text == "Trạng Thái")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[6], ListSortDirection.Ascending);
            }
            else if (cbbSapXep.Text == "Ngày Mua")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[7], ListSortDirection.Ascending);
            }
            else if (cbbSapXep.Text == "Người Bán")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[8], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGiamDan_Click(object sender, EventArgs e)
        {
            if (cbbSapXep.Text == "ID Hóa Đơn")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[0], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Tên Sản Phẩm")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[1], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Topping")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[2], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Số Lượng")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[3], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Giá Bán")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[4], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Hình Thức")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[5], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Trạng Thái")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[6], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Ngày Mua")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[7], ListSortDirection.Descending);
            }
            else if (cbbSapXep.Text == "Người Bán")
            {
                dgvThanhToan.Sort(dgvThanhToan.Columns[8], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            ChuongTrinh f = new ChuongTrinh();
            f.Hide();
        }

        private void QLHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            ChuongTrinh f = new ChuongTrinh();
            f.ShowDialog();
        }

        private void cbxTopping_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBTopping_CheckedChanged(sender, e);
        }

        private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtHoaDon.Text = dgvThanhToan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvThanhToan.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbxTopping.Text = dgvThanhToan.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvThanhToan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGia.Text = dgvThanhToan.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtHinhThuc.Text = dgvThanhToan.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTrangThai.Text = dgvThanhToan.Rows[e.RowIndex].Cells[6].Value.ToString();
                datimeNgayMua.Value = Convert.ToDateTime(dgvThanhToan.Rows[e.RowIndex].Cells[7].Value);
                txtNguoiBan.Text = dgvThanhToan.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }
    }
}
