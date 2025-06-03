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
    public partial class FormAddProductToBuyer : Form
    {
        private Management M1;
        public FormAddProductToBuyer(Management M1)
        {
            InitializeComponent();
            this.M1 = M1;
            txtdata.Text = ProductInfo();
        }
        private bool IsValidate()
        {
            if(string.IsNullOrEmpty(txtBuyerName.Text))
            {
                MessageBox.Show("Name can't be empty.");
                return false;
            }
            if(M1.SearchBuyerName(txtBuyerName.Text) == -1)
            {
                MessageBox.Show("Name doesn't exist. Please try another.");
                return false;
            }
            if(string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("ID can't be empty. Please try again.");
                return false;
            }
            int num;
            if(!int.TryParse(txtID.Text, out num))
            {
                MessageBox.Show("An ID includes only numbers.Please try again.");
                return false;
            }
            if(M1.GetProductFromSellers(num)==null)
            {
                MessageBox.Show("The ID doesn't exist, please try another from the list.");
                return false;
            }
            return true;
        }
        private void lblSellerName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtSellerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromAddProductToBuyer_Load(object sender, EventArgs e)
        {

        }
        private string ProductInfo()
        {
            string data = "";
            foreach (Seller s in M1.Sellers)
            {
                foreach(Product p in s.Cart)
                {
                    if(s.Cart.Count > 0)
                    {
                        data += p.ToString();
                        data += "\r\n";
                    }
                } 
            }
            return data;
        }
        private void SubmitBut_Click(object sender, EventArgs e)
        {
            if (IsValidate() == true)
            {
                DialogResult dr = MessageBox.Show($"Do you want to add to {txtBuyerName.Text} a product whose ID is {txtID.Text}?", "are you sure?", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    int index = M1.SearchBuyerName(txtBuyerName.Text);
                    int NumOfPro;
                    int.TryParse(txtID.Text, out NumOfPro);
                    Product temp = M1.GetProductFromSellers(NumOfPro);
                    M1.GetBuyer(index).Cart.Add(temp);
                    MessageBox.Show("Product added successfuly.");
                    Close();
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
