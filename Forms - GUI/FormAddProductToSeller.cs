using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShop
{
    public partial class FormAddProductToSeller : Form
    {
        private Management M1;
        public FormAddProductToSeller(Management M1)
        {
            InitializeComponent();
            this.M1 = M1;
        }
        private bool IsValidate()
        {
            if(string.IsNullOrEmpty(txtSellerName.Text))
            {
                MessageBox.Show("Name can't be empty.");
                return false;
            }
            if(M1.SearchSellerName(txtSellerName.Text) == -1)
            {
                MessageBox.Show("Name doesn't exist. Please try another.");
                return false;
            }
            if (string.IsNullOrEmpty(txtProduct.Text))
            {
                MessageBox.Show("Name of product can't be empty.");
                return false;
            }
            if (string.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Price can't be empty.");
                return false;
            }
            double num;
            if(!double.TryParse(txtprice.Text,out num))
            {
                MessageBox.Show("Price contains omly numbers. Please try again.");
                return false;
            }
            if (RBclothes.Checked == false && RBkids.Checked == false && RBoffice.Checked == false && RBElectricity.Checked == false)
            {
                MessageBox.Show("Please select a category");
                return false;
            }
            return true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SpecialProductBox_Click(object sender, EventArgs e)
        {

        }

        private void FormAddProductToSeller_Load(object sender, EventArgs e)
        {

        }

        private void Electricity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBut_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                DialogResult dr = MessageBox.Show("Please confirm all the details are correct.", "are you sure?", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    int index = M1.SearchSellerName(txtSellerName.Text);
                    double price;
                    double.TryParse(Text, out price);
                    eCategory category = Category();
                    Product p = new Product(txtProduct.Text,price,category);
                    if (CheckBoxSpecial.Checked)
                    {
                        SpecialProduct sp = new SpecialProduct(p);
                        M1.GetSeller(index).Cart.Add(sp);
                        MessageBox.Show("Product added successfuly.");
                        Close();
                    }
                    else
                    {
                        M1.GetSeller(index).Cart.Add(p);
                        MessageBox.Show("Product added successfuly.");
                        Close();
                    }
                }
            }
        }
        private eCategory Category()
        {
            if(RBclothes.Checked)
            {
                return eCategory.Clothes;
            }
            if(RBElectricity.Checked)
            {
                return eCategory.Electricity;
            }
            if(RBkids.Checked)
            {
                return eCategory.Kids;
            }
            if (RBoffice.Checked)
            {
                return eCategory.Office;
            }
            else 
            {
                throw new InvalidOperationException("No category selected.");
            }
        }
    }
}
