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
    public partial class QLBan : Form
    {
        private List<CQLBan> qlban;
        public QLBan()
        {
            InitializeComponent();
        }

        private void QLBan_Load(object sender, EventArgs e)
        {

            dtgvBanAn.Rows.Clear();
            dtgvBanAn.Refresh();

            var lines = File.ReadAllLines("csdlCapNhatBan.txt");
            if (lines.Count() > 0)
            {
                foreach (var cellValues in lines.Skip(0))
                {
                    var cellArray = cellValues.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cellArray.Length == dtgvBanAn.Columns.Count)
                        dtgvBanAn.Rows.Add(cellArray);

                }
            }
        }

        private void dtgvBanAn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
/*
            if (e.RowIndex >= 0)
            {
                txtID.Text = dtgvBanAn.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTrangThai.Text = dtgvBanAn.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNgayCN.Text = dtgvBanAn.Rows[e.RowIndex].Cells[2].Value.ToString();
            }*/
        }

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Bạn chưa nhập ID Bàn", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTrangThai.Text))
            {
                MessageBox.Show("Bạn chưa nhập Trang Thái Bàn", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTrangThai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNgayCN.Text))
            {
                MessageBox.Show("Bạn chưa nhập Ngày Cập nhật", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayCN.Focus();
                return false;
            }
            return true;
        }
        private void btnSuaBA_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                int index = dtgvBanAn.CurrentRow.Index;

                dtgvBanAn.Rows[index].Cells[0].Value = txtID.Text.ToString();
                dtgvBanAn.Rows[index].Cells[1].Value = txtTrangThai.Text.ToString();
                dtgvBanAn.Rows[index].Cells[2].Value = txtNgayCN.Text.ToString();
            }
        }

        private void btnLuuBA_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("csdlCapNhatBan.txt"))
            {
                for (int i = 0; i < dtgvBanAn.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgvBanAn.Columns.Count; j++)
                    {
                        tw.Write($"{dtgvBanAn.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dtgvBanAn.Columns.Count - 1)
                        {
                            tw.Write("-");
                        }
                    }
                    tw.WriteLine();
                }
            }
            MessageBox.Show("Lưu Vào Dữ Liệu Bàn Thành Công");

            ChuongTrinh f = new ChuongTrinh();
            f.Refresh();
        }
        private void Ql()
        {
            qlban.Count();
        }
        private void btnThoatBA_Click(object sender, EventArgs e)
        {
            
            this.Close();
            ChuongTrinh f = new ChuongTrinh();
            f.Hide();
        }

        private void QLBan_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            ChuongTrinh f = new ChuongTrinh();
            f.ShowDialog();
        }

        private void dtgvBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtID.Text = dtgvBanAn.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTrangThai.Text = dtgvBanAn.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNgayCN.Text = dtgvBanAn.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
