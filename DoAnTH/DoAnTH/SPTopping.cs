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
    public partial class SPTopping : Form
    {
        public SPTopping()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
          
            int index = dataGridView1.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            string a = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string b = txtTopping.Text;
            if (a != b)
            {
                row.Cells[0].Value = txtTopping.Text;
                dataGridView1.Rows.Add(row);
                txtTopping.Text = "";
            }
            else MessageBox.Show("Topping " + txtTopping.Text + " Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("TOPPING.txt"))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                        if (j != dataGridView1.Columns.Count - 1)
                        {
                            tw.Write("-");
                        }
                    }
                    tw.WriteLine();
                }
            }
            MessageBox.Show("Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SPTopping_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var lines2 = File.ReadAllLines("TOPPING.txt");
            if (lines2.Count() > 0)
            {
                foreach (var cellValues2 in lines2.Skip(0))
                {
                    var cellArray2 = cellValues2.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cellArray2.Length == dataGridView1.Columns.Count)
                        dataGridView1.Rows.Add(cellArray2);
                }
            }
        }

       

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            string a = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string b = txtTopping.Text;
            if (a != b)
            {

                dataGridView1.Rows[index].Cells[0].Value = txtTopping.Text.ToString();
            }
            else MessageBox.Show("Topping " + txtTopping.Text + " Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string a = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string b = txtTopping.Text;
            if (a == b)
            {
                MessageBox.Show("Đã Xóa Topping: " + dataGridView1.Rows[index].Cells[0].Value,
               "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Remove(dataGridView1.Rows[index]);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Khác Topping Không Xóa Được", "Thông Báo");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           /* txtTopping.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void lblGiamDan_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTopping.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
