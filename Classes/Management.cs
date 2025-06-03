using EShop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Management
    {
        private string company_name = "Ruppin Market";
        private List<Seller> sellers;
        private List<Buyer> buyers;

        public string Company_Name
        {
            get => company_name;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Company name cannot be empty or Null.");
                }
                company_name = value;
            }
        }
        public Management()
        {
            sellers = new List<Seller>();
            buyers = new List<Buyer>();
        }
        public List<Seller> Sellers
        {
            get => sellers;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                sellers = value;
            }
        }

        public List<Buyer> Buyers
        {
            get => buyers;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                buyers = value;
            }
        }
        public void DisplaySellers()
        {
            if (sellers.Count == 0)
            {
                Console.WriteLine("There are no sellers for now.\n");
            }
            sellers.Sort();
            foreach (var item in sellers)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        public void DisplayBuyers()
        {
            if (buyers.Count == 0)
            {
                Console.WriteLine("There are no buyers for now.\n");
                return;
            }
            int index = 0;
            Console.WriteLine("Buyers:");
            foreach (var item in buyers)
            {
                Console.WriteLine($"({index})" + item.ToString());
                index++;
                Console.WriteLine();
            }
        }
        public void DisplayBuyersNames()
        {
            if (buyers.Count == 0)
            {
                Console.WriteLine("There are no buyers for now.\n");
                return;
            }
            int index = 0;
            Console.WriteLine("Buyers:");
            foreach (var item in buyers)
            {
                Console.WriteLine($"({index})" + item.Name);
                index++;
            }
        }
        public void DisplayProduct()
        {
            foreach (var item in sellers)
            {
                Console.WriteLine(item.ProductsToString());
            }
        }
        public bool SearchProduct(int serialNum)
        {
            if (sellers.Count == 0)
            {
                return false;
            }
            for (int i = 0; i < sellers.Count; i++)
                for (int j = 0; j < sellers[i].Cart.Count; j++)
                {
                    if (sellers[i].Cart[j] == null)
                    {
                        return false;
                    }
                    if (sellers[i].Cart[j].GetId().Equals(serialNum))
                    {
                        return true;
                    }
                }
            return false;
        }
        public Product GetProductFromSellers(int serialNum)
        {
            if (SearchProduct(serialNum) == false)
            {
                return null;
            }
            for (int i = 0; i < sellers.Count; i++)
                for (int j = 0; j < sellers[i].Cart.Count; j++)
                {
                    if (sellers[i].Cart[j].GetId().Equals(serialNum))
                    {
                        Product temp = sellers[i].Cart[j];
                        return temp;
                    }
                }
            return null;
        }
        public int EqualsSeller(string SellerName, string SellerPassword, Address SellerAddress)
        {
            Seller temp = new Seller(SellerName, SellerPassword, SellerAddress);
            if (sellers.Count == 0)
            {
                return -1;
            }
            for (int i = 0; i < sellers.Count; i++)
            {
                var seller = sellers[i];

                if (seller.Equals(temp) == 0)
                {
                    return i;
                }
            }
            Console.WriteLine("there is no seller by that name.");
            return -1;
        }
        public int EqualsBuyer(string BuyerName, string Buyerpassword, Address Buyeradderss)
        {
            Buyer temp = new Buyer(BuyerName, Buyerpassword, Buyeradderss);
            if (buyers.Count == 0)
            {
                return -1;
            }
            for (int i = 0; i < buyers.Count; i++)
            {
                var buyer = buyers[i];
                if (buyer.Equals(temp) == 0)
                {
                    return i;
                }
            }
            //Console.WriteLine("there is no buyer by that name.");
            return -1;
        }
        public int SearchSellerName(string SellerName)
        {
            if (sellers.Count == 0)
            {
                return -1;
            }
            for (int i = 0; i < sellers.Count; i++)
            {
                if (sellers[i].Name.Equals(SellerName))
                {
                    return i;
                }
            }
            //Console.WriteLine("there is no seller by that name.");
            return -1;
        }
        public int SearchBuyerName(string BuyerName)
        {
            if (buyers.Count == 0)
            {
                return -1;
            }
            for (int i = 0; i < buyers.Count; i++)
            {
                if (buyers[i].Name == BuyerName)
                {
                    return i;
                }
            }
            //Console.WriteLine("There is no buyer by that name.");
            return -1;
        }
        public Buyer GetBuyer(int index)
        {
            return buyers[index];
        }
        public Seller GetSeller(int index)
        {
            return sellers[index];
        }
        public void AddFromHistory(int Buyerindex, int orderindex)
        {
            Order o1 = Buyers[Buyerindex].History[orderindex];
            foreach (Product value in o1.Items)
            {
                buyers[Buyerindex].Cart.Add(value);
            }
            Console.WriteLine("Order added successfully.");
        }
    }
}
