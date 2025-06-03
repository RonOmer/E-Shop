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
    public partial class FormAddUser : Form
    {
        private string UserType;
        private Management M1;
        public FormAddUser(string UserType, Management M1)
        {
            InitializeComponent();
            this.UserType = UserType;
            this.M1 = M1;
            InitializeForm();
        }
        private void InitializeForm()
        {
            if (UserType == "Seller")
            {
                Text = "Add Seller";
            }
            else if (UserType == "Buyer")
            {
                Text = "Add Buyer";
            }
            else
            {
                throw new ArgumentException("Invalid user type");
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Name cant be empty.");
                return false;
            }
            if (UserType == "Buyer")
            {
                if (M1.SearchBuyerName(txtName.Text) != -1)
                {
                    MessageBox.Show("Name is already exist. Try another.");
                    return false;
                }
            }
            else if(UserType == "Seller")
            {
                if (M1.SearchSellerName(txtName.Text) != -1)
                {
                    MessageBox.Show("Name is already exist. Try another.");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Password can't be empty.");
                return false;
            }
            if (string.IsNullOrEmpty(txtCity.Text.Trim()))
            {
                MessageBox.Show("City can't be empty.");
                return false;
            }
            if (string.IsNullOrEmpty(txtState.Text.Trim()))
            {
                MessageBox.Show("State can't be empty.");
                return false;
            }
            if (string.IsNullOrEmpty(txtStreet.Text.Trim()))
            {
                MessageBox.Show("Street can't be empty.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNumOf.Text.Trim()))
            {
                MessageBox.Show("A Building number can't be empty.");
                return false;
            }
            int num;
            if (!int.TryParse(txtNumOf.Text, out num))
            {
                MessageBox.Show("A building number consists of numbers only.");
                return false;
            }
            return true;
        }
        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateForm() == true)
            {
                DialogResult dr = MessageBox.Show("Please confirm all the details are correct.", "are you sure?", MessageBoxButtons.OKCancel);
                {
                    if (dr == DialogResult.OK)
                    {
                        int num;
                        int.TryParse(txtNumOf.Text, out num);
                        Address ad = new Address(txtStreet.Text, txtCity.Text, txtState.Text, num);
                        User user = new User(txtName.Text, txtPassword.Text, ad);
                        if (UserType == "Buyer")
                        {
                            Buyer buyer = new Buyer(user);
                            M1.Buyers += buyer;
                            MessageBox.Show("Buyer added successfuly.");
                            Close();
                        }
                        else if (UserType == "Seller")
                        {
                            Seller seller = new Seller(user);
                            M1.Sellers += seller;
                            MessageBox.Show("Seller added successfuly.");
                            Close();
                        }
                    }
                }
            }
        }
    }
}
