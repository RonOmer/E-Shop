using EShop;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Buyer : User
    {
        private List<Order> history;

        public Buyer(string name, string password, Address address) : base(name, password, address)
        {
            history = new List<Order>();
        }
        public Buyer():base()
        {
            history = new List<Order>();
        }
        public Buyer(Buyer other):base()
        {
            Name = other.Name;
            Password = other.Password;
            Address = new Address(other.Address);
            History = new List<Order>();
            foreach(Order order in other.history)
            {
                History.Add(new Order(order));
            }
        }
        public Buyer(User user): base(user)
        {
            history = new List<Order>();
        }
        public static Buyer CreateBuyer(Management m1)
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
                    while(m1.SearchBuyerName(name) != -1)
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
                    return new Buyer(name, password, ad);
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
        public List<Order> History
        {
            get => history;
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("value");
                }
                history = value;
            }
        }
        public void Pay(Buyer buyer)
        {
            if (Cart.Count == 0 || Cart.Count == 1)
            {
                Console.WriteLine($"There are not enough products in the shopping cart to make a payment.\n Min 2 products to pay.\nYou have {Cart.Count} products.");
                return;
            }
            List<Order> temp = new List<Order>();
            List<Product> temp1 = new List<Product>(cart);
            Order o1 = new Order(temp1, 0, buyer);
            temp.Add(o1);
            Console.WriteLine(temp[0].ToString());
            Console.WriteLine("Do you want to pay?(Y/N)");
            char answer = char.Parse(Console.ReadLine());
            switch (char.ToUpper(answer))
            {
                case 'Y':
                    history.Add(temp[0]);
                    Cart.Clear();
                    break;
                case 'N':
                    Console.WriteLine("OK.");
                    break;
                default:
                    Console.WriteLine("Invalid answer. Please try again.");
                    break;
            }
        }
        public override string ToString()
        {
            string str = string.Empty;
            string str2 = string.Empty;
            if (Cart.Count == 0 || Cart == null)
            {
                str = "There are no items in the shopping cart.";
            }
            else
            {
                for (int i = 0; i < Cart.Count; i++)
                {
                    str += string.Join("\n", Cart[i].ToString());
                }
            }
            if (history.Count == 0)
            {
                str2 = "There are no paid orders.";
            }
            else
            {
                for (int j = 0; j < history.Count; j++)
                {
                    str2 += $"Order({j + 1}):\n";
                    str2 += string.Join("\n", history[j].ToString());
                    if(j != history.Count - 1)
                        str2 += "\n" ;
                }
            }
            return $"Name:{Name}\nAddress:\n{Address}\norders:\n{str2}\nshopping cart:\n{str}\n";
        }
        public override string ToStringToFile()
        {
            string str = string.Empty;
            string str2 = string.Empty;
            if (Cart.Count == 0 || Cart == null)
            {
                str = "There are no items in the shopping cart.";
            }
            else
            {
                for (int i = 0; i < Cart.Count; i++)
                {
                    str += string.Join("\n", Cart[i].ToString());
                }
            }
            if (history.Count == 0)
            {
                str2 = "There are no paid orders.";
            }
            else
            {
                for (int j = 0; j < history.Count; j++)
                {
                    str2 += $"Order({j + 1}):\n";
                    str2 += string.Join("\n", history[j].ToString());
                    if (j != history.Count - 1)
                        str2 += "\n";
                }
            }
            return $"Name:{Name}\nPassword:{Password}\nAddress:\n{Address}\norders:\n{str2}\nshopping cart:\n{str}\n";
        }
        public void DisplayHistory()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Your order history is empty.");
                return;
            }
            for (int i = 0; i < history.Count; i++)
            {
                Console.WriteLine($"({i})" + history[i].ToString());
            }
        }
        public static List<Buyer> operator +(List<Buyer> buyers, Buyer b1)
        {
            if (b1 == null)
            {
                throw new ArgumentNullException(nameof(Buyer), "Buyer cannot be null.");
            }
            buyers.Add(b1);
            return buyers;
        }
        public double CartTotalPrice()
        {
            if(Cart.Count == 0)
            {
                return 0;
            }
            double sum = 0;
            for (int i = 0; i < Cart.Count; i++)
            {
                sum += Cart[i].Price;
            }
            return sum;
        }
        public static bool operator >(Buyer b1, Buyer b2)
        {
            if (b1 == null || b2 == null)
            {
                throw new ArgumentNullException(nameof(Buyer), "Buyer cannot be null.");
            }
            return b1.CartTotalPrice() > b2.CartTotalPrice();
        }
        public static bool operator <(Buyer b1,Buyer b2)
        {
            if (b1 == null || b2 == null)
            {
                throw new ArgumentNullException(nameof(Buyer), "Buyer cannot be null.");
            }
            return b1.CartTotalPrice() < b2.CartTotalPrice();
        }
    }
}
