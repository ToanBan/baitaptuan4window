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
    public partial class Form2 : Form
    {
        private string name;
        private int price;
        private string msnv;

        public Form2()
        {
            InitializeComponent();
        }

        

        public string Msnv { get => msnv; set => msnv = value; }
        public string Name1 { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Msnv = txtMa.Text;
            Name1 = txtName.Text;
            Price = int.Parse(txtPrice.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
