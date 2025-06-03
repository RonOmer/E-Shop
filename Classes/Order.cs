using EShop;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EShop
{
    public class Order
    {
        private List<Product>items;
        private double total_price;
        private Buyer buyer;

        public Order(List<Product> items, double total_price, Buyer buyer)
        {
            this.items = items;
            this.total_price = total_price;
            this.buyer = buyer;
        }
        public Order() { }
        public Order(Order other)
        {
            total_price = other.total_price;
            buyer = other.buyer;
            foreach (Product item in other.items)
            {
                items.Add(new Product(item));
            }
        }
        public List<Product> Items
        {
            get => items;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                items = value;
            }
        }
        public double TotalPrice
        {
            get
            {
                total_price = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] != null)
                    {
                        total_price += items[i].Price;
                    }
                }
                return total_price;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Total price must be positive.");
                }
            }
        }
        public Buyer Buyer
        {
            get => buyer;
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("value");
                }
                buyer = value;
            }
        }
        public override string ToString()
        {
            string str = string.Empty;
            if (items.Count == 0)
            {
                str = "There are no items for now.";
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    str += string.Join("\n", $"({i+1})" + items[i].ToString());
                }
            }
            return $"items:\n{str}Total price:{TotalPrice}\n";
        }
        public string ToStringToForm()
        {
            string str = string.Empty;
            if (items.Count == 0)
            {
                str = "There are no items for now.";
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    str += string.Join("\r\n", $"({i + 1})" + items[i].ToString());
                }
            }
            return $"items:\n{str}Total price:{TotalPrice}\r\n";
        }
        public int Equals(Order other)
        {
            if(other == null)
            {
                return -1;
            }
            if(total_price != other.total_price || items != other.items || buyer != other.buyer)
            {
                return 0;
            }
            return -1;
        }
    }
}
