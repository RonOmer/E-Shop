using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EShop;

namespace EShop
{
    public partial class MainForm : Form
    {
        private Management m1;
        public MainForm(Management m1)
        {
            InitializeComponent();
            this.m1 = m1;
            RBaddseller.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBshow_CheckedChanged(object sender, EventArgs e)
        {
            if (RBshow.Checked)
            {
                using (FormShowAll show = new FormShowAll(m1))
                {
                    show.ShowDialog();
                }
                RBshow.Checked = false;
            }
        }

        private void RBaddProToBuyer_CheckedChanged(object sender, EventArgs e)
        {
            if(RBaddProToBuyer.Checked)
            {
                FormAddProductToBuyer formAddProductToBuyer = new FormAddProductToBuyer(m1);
                formAddProductToBuyer.ShowDialog();
            }
            RBaddProToBuyer.Checked = false;
        }

        private void RBaddSrotoSeller_CheckedChanged(object sender, EventArgs e)
        {
            if( RBaddSrotoSeller.Checked)
            {
                FormAddProductToSeller formAddProductToSeller = new FormAddProductToSeller(m1);
                formAddProductToSeller.ShowDialog();
            }
            RBaddProToBuyer.Checked = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMarketName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PaddSeller_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RBaddBuyer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBaddBuyer.Checked)
            {
                using (FormAddUser addbuyer = new FormAddUser("Buyer", m1))
                {
                    addbuyer.ShowDialog();
                }
            }
            RBaddBuyer.Checked = false;
        }

        private void RBaddseller_CheckedChanged(object sender, EventArgs e)
        {
            if (RBaddseller.Checked)
            {
                using (FormAddUser addseller = new FormAddUser("Seller",m1))
                {
                    addseller.ShowDialog();
                }
                RBaddseller.Checked = false;
            }
        }
    }
}
