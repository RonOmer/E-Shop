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
    public partial class FormShowAll : Form
    {
        private Management M1;
        public FormShowAll(Management M1)
        {
            InitializeComponent();
            this.M1 = M1;
            DisplayData(M1);
        }
        private void DisplayData(Management management)
        {
            string data = "Buyers:\r\n";
            data += AddBuyersToData(management.Buyers);
            data += "\r\nSellers:\r\n";
            data += AddSellersToData(management.Sellers);

            txtData.Text = data;
        }

        private string AddBuyersToData(List<Buyer> buyers)
        {
            string data = "";
            foreach (Buyer buyer in buyers)
            {
                data += $"Name:{buyer.Name},Street:{buyer.Address.Street},Building number:{buyer.Address.Building_number},City:{buyer.Address.City},State:{buyer.Address.State}\r\n";
                data += $"Cart:\r\n";
                if (buyer.Cart.Count == 0)
                {
                    data += "Cart is empty for now.\r\n";
                }
                else
                {
                    foreach (Product product in buyer.Cart)
                    {
                        data += $"{product.ToString()}\r\n";
                    }
                }
                data += $"Order History:\r\n";
                if(buyer.History.Count == 0)
                {
                    data += "Order history is empty for now.\r\n";
                }
                else
                {
                    foreach (Order order in buyer.History)
                    {
                        data += $"Order: {order.ToStringToForm()}\r\n";
                    }
                    data += "\r\n";
                }
                data += "\r\n";
            }
            return data;
        }


        private string AddSellersToData(List<Seller> sellers)
        {
            string data = "";
            foreach (Seller seller in sellers)
            {
                data += $"Name:{seller.Name},Street:{seller.Address.Street},Building number:{seller.Address.Building_number},City:{seller.Address.City},State:{seller.Address.State}\r\n";
                if(seller.Cart.Count == 0)
                {
                    data += "Cart is empty for now\r\n";
                }
                else
                {
                    foreach (Product product in seller.Cart)
                    {
                        data += $"{product.ToString()}\r\n";
                    }
                }
                data += "\r\n";
            }
            return data;
        }

            private void FormShowAll_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
