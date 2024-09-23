using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 frmInput = new Form2();
            if(frmInput.ShowDialog() == DialogResult.OK)
            {
                string msnv = frmInput.Msnv;
                string name = frmInput.Name1;
                int price = frmInput.Price;
                dataGridView1.Rows.Add(msnv, name, price);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Chọn dòng để xoá.");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Form2 frmInput = new Form2();
                if (frmInput.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["MSNV"].Value = frmInput.Msnv;
                    selectedRow.Cells["NAME"].Value = frmInput.Name1;
                    selectedRow.Cells["PRICE"].Value = frmInput.Price;
                }
            }
            else
            {
                MessageBox.Show("Chọn dòng để sửa.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
