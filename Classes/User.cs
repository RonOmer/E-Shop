using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class User
    {
        private string name;
        private string password;
        private Address address;
        protected List<Product> cart;

        public User(string name, string password, Address address)
        {
            this.name = name;
            this.password = password;
            this.address = address;
            cart = new List<Product>();
        }
        public User(User other)
        {
            name = other.name;
            password = other.password;
            address = other.address;
            cart = new List<Product>();
            foreach (Product product in other.Cart)
            {
                cart.Add(product);
            }
        }
        public User()
        {
            cart = new List<Product>();
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Name cannot be empty or Null.");
                }
                name = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Password cannot be empty or Null.");
                }
                password = value;
            }
        }
        public Address Address
        {
            get => address;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                address = value;
            }
        }
        public List<Product> Cart
        {
            get => cart;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                cart = value;
            }
        }
        public virtual string ToString()
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
                    str += string.Join("\n", cart[i].ToString());
                }
            }
            return $"Name:{name}\nAddress:\n{address}\nItems:\n{str}";
        }
        public virtual string ToStringToFile()
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
                    str += string.Join("\n", cart[i].ToString());
                }
            }
            return $"Name:{name}\nPassword:{password}\nAddress:\n{address}\nItems:\n{str}";
        }
        public int Equals(User other)
        {
            if (other == null)
            {
                return -1;
            }
            if (other.Name != Name || other.Password != Password || other.Address.Equals(Address) == -1)
            {
                return -1;
            }
            return 0;
        }
    }
}
