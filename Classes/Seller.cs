using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Seller : User, IComparable<Seller>
    {
        public Seller(string name, string password, Address address) : base(name, password, address)
        {
        }
        public Seller() : base() { }
        public Seller(Seller other):base(other)
        {
            Name = other.Name;
            Password = other.Password;
            Address = new Address(other.Address);
            foreach (Product product in other.Cart)
            {
                cart.Add(new Product(product));
            }
        }
        public Seller(User user):base(user)
        {

        }
        public static Seller CreateSeller(Management M1)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                    while (M1.SearchSellerName(name) != -1)
                    {
                        Console.WriteLine("This name is already exist. please try another name.");
                        name = Console.ReadLine().Trim();
                    }
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(password))
                    {
                        throw new ArgumentException("Password cannot be empty");
                    }
                    Address ad = Address.CreateAddress();
                    return new Seller(name, password, ad);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred:" + ex.Message);
                }
            }
        }
        public override string ToString()
        {
            string str = string.Empty;
            if (Cart.Count == 0)
            {
                str = "There are no products for now";
            }
            else
            {
                for (int i = 0; i < Cart.Count; i++)
                {
                    str += string.Join("\n", cart[i].ToString());
                }
            }
            return $"Name:{Name}\nAddress:\n{Address}\nshopping cart:\n{str}\n";
        }
        public override string ToStringToFile()
        {
            string str = string.Empty;
            if (Cart.Count == 0)
            {
                str = "There are no products for now";
            }
            else
            {
                for (int i = 0; i < Cart.Count; i++)
                {
                    str += string.Join("\n", cart[i].ToString());
                }
            }
            return $"Name:{Name}\nPassword:{Password}\nAddress:\n{Address}\nshopping cart:\n{str}\n";
        }
        public string ProductsToString()
        {
            string str = string.Empty;
            if (cart.Count == 0)
            {
                str = "There are no products for now";
            }
            else
            {
                for (int i = 0; i < cart.Count; i++)
                {
                    str += string.Join("\n", Cart[i].ToString());
                }
            }
            return $"Items:\n{str}";
        }
        public int CompareTo(Seller other)
        {
            return other.Cart.Count.CompareTo(Cart.Count);
        }
        public static List<Seller> operator +(List<Seller> sellers, Seller s1)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(nameof(Buyer), "Buyer cannot be null.");
            }
            sellers.Add(s1);
            return sellers;
        }
    }
}
