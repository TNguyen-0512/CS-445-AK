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

namespace DoAnTH
{
    public partial class QLNuoc : Form
    {
        string flag;
        DataTable dtNU;
        int index;
        public QLNuoc()
        {
            InitializeComponent();
        }

        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TenMon");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("GiaTien");

            return dt;
        }

        public void khoaControl()
        {
            btnThemNU.Enabled = true;
            btnSuaNU.Enabled = true;
            btnXoaNU.Enabled = true;
            btnLuuNU.Enabled = false;
            btnHuyNU.Enabled = false;

            txtID.ReadOnly = true;
            txtTenMon.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtGia.ReadOnly = true;


            btnThemNU.Focus();
        }
        public void moConTrol()
        {
            btnThemNU.Enabled = false;
            btnSuaNU.Enabled = false;
            btnXoaNU.Enabled = false;
            btnLuuNU.Enabled = true;
            btnHuyNU.Enabled = true;

            txtID.ReadOnly = false;
            txtTenMon.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtGia.ReadOnly = false;
            txtID.Focus();
        }

        // List<Caffee> cafe = new List<Caffee>();
        private void btnThemNU_Click_1(object sender, EventArgs e)
        {
            moConTrol();
            flag = "add";

            txtID.Text = "";
            txtTenMon.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";

        }

        private void btnSuaNU_Click(object sender, EventArgs e)
        {
            moConTrol();
            flag = "edit";
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        { 
            if (cbNU.Text == "Coffee")
            {
                if (flag == "add")
                {
                    if (checkData())
                    {
                        dtNU.Rows.Add(txtID.Text, txtTenMon.Text, txtSoLuong.Text, txtGia.Text);
                        dataGridQLNuoc.DataSource = dtNU;
                        dataGridQLNuoc.RefreshEdit();
                    }

                }
                else if (flag == "edit")
                {
                    if (checkData())
                    {
                        dtNU.Rows[index][0] = txtID.Text;
                        dtNU.Rows[index][1] = txtTenMon.Text;
                        dtNU.Rows[index][2] = txtSoLuong.Text;
                        dtNU.Rows[index][3] = txtGia.Text;
                        dataGridQLNuoc.DataSource = dtNU;
                        dataGridQLNuoc.RefreshEdit();
                    }
                }
                using (TextWriter tw = new StreamWriter("csdlLuuCF.txt"))
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
            }
            else if (cbNU.Text == "Trà Sữa")
            {
                if (flag == "add")
                {
                    if (checkData())
                    {
                        dtNU.Rows.Add(txtID.Text, txtTenMon.Text, txtSoLuong.Text, txtGia.Text);
                        dataGridQLNuoc.DataSource = dtNU;
                        dataGridQLNuoc.RefreshEdit();
                    }

                }
                else if (flag == "edit")
                {
                    if (checkData())
                    {
                        dtNU.Rows[index][0] = txtID.Text;
                        dtNU.Rows[index][1] = txtTenMon.Text;
                        dtNU.Rows[index][2] = txtSoLuong.Text;
                        dtNU.Rows[index][3] = txtGia.Text;
                        dataGridQLNuoc.DataSource = dtNU;
                        dataGridQLNuoc.RefreshEdit();
                    }
                }
                using (TextWriter tw = new StreamWriter("csdlLuuTS.txt"))
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
            }
            else
            {
                MessageBox.Show("Chọn Danh mục cần Lưu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            khoaControl();

        }

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID ", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên Món", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenMon.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập Số Lượng", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập Giá tiền", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
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
                var lines = File.ReadAllLines("csdlLuuCF.txt");
                if (lines.Count() > 0)
                {
                    /*foreach (var columnName in lines.FirstOrDefault()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        dataGridQLNuoc.Columns.Add(columnName, columnName);
                    }*/
                    foreach (var cellValues in lines.Skip(0))
                    {
                        var cellArray = cellValues.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cellArray.Length == dataGridQLNuoc.Columns.Count)
                            dataGridQLNuoc.Rows.Add(cellArray);

                    }
                }
                foreach (DataGridViewRow row in dataGridQLNuoc.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(row.Cells[0].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        break;
                    }
                }
            }
            else if (cbNU.Text == "Trà Sữa")
            {
                dataGridQLNuoc.Rows.Clear();
                dataGridQLNuoc.Refresh();
                var lines = File.ReadAllLines("csdlLuuTS.txt");
                if (lines.Count() > 0)
                {
                    /*foreach (var columnName in lines.FirstOrDefault()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        dataGridQLNuoc.Columns.Add(columnName, columnName);
                    }*/
                    foreach (var cellValues in lines.Skip(0))
                    {
                        var cellArray = cellValues.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cellArray.Length == dataGridQLNuoc.Columns.Count)
                            dataGridQLNuoc.Rows.Add(cellArray);

                    }
                }
                foreach (DataGridViewRow row in dataGridQLNuoc.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(row.Cells[0].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        break;
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
            if (MessageBox.Show("Bạn muốn xóa " + txtTenMon.Text + " ?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtNU.Rows.RemoveAt(index);
                dataGridQLNuoc.DataSource = dtNU;
                dataGridQLNuoc.RefreshEdit();
            }
        }
        
        //private void btnThemNU_Click_1(object sender, EventArgs e)
        //{
        //   moConTrol();
        //    flag = "add";

        //    txtID.Text = "";
        //    txtTenMon.Text = "";
        //    txtSoLuong.Text = "";
        //    txtGia.Text = "";
        //}

        //private void btnSuaNU_Click(object sender, EventArgs e)
        //{
        //    moConTrol();
        //    flag = "edit";
        //}

        private void QLNuoc_Load(object sender, EventArgs e)
        {
            
            khoaControl();
           // FileStream fs = new FileStream("csdlLuuCF.txt", FileMode.Open);
            
            dtNU = createTable();
        }

        private void dataGridQLNuoc_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridQLNuoc.CurrentCell == null ? -1 : dataGridQLNuoc.CurrentCell.RowIndex;
            // kiểm tra CurrentCell hiện tại có khác null ko ? = null cho bằng trừ 1
            //  ngược lại sẽ lấy dòng dữ liệu
            // DataTable dt = (DataTable)dataGridQLNuoc.DataSource;
            if (index != -1)  //kiểm tra
            {
                txtID.Text = dataGridQLNuoc.Rows[index].Cells[0].Value.ToString();
                txtTenMon.Text = dataGridQLNuoc.Rows[index].Cells[1].Value.ToString();
                txtSoLuong.Text = dataGridQLNuoc.Rows[index].Cells[2].Value.ToString();
                txtGia.Text = dataGridQLNuoc.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void dataGridQLNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
