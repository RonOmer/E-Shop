using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShop
{
    class ProgramGUI
    {
        [STAThread]
        static void Main(string[] args)
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string BuyersFilePath = Path.Combine(projectDirectory, "Resources", "Buyers.txt");
            string SellersFilePath = Path.Combine(projectDirectory, "Resources", "Sellers.txt");
            Management management = new Management();
            ReadFromFile(SellersFilePath, management);
            ReadFromFile(BuyersFilePath, management);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(management));


            WriteToFileBuyers(BuyersFilePath, management);
            WriteToFileSellers(SellersFilePath, management);
        }

        public static void WriteToFileBuyers(string BuyersFilePath, Management M1)
        {
            StreamWriter SWBuyers = new StreamWriter(BuyersFilePath);
            foreach (Buyer buyer in M1.Buyers)
            {
                SWBuyers.WriteLine(buyer.ToStringToFile());
            }
            SWBuyers.Close();
        }
        public static void WriteToFileSellers(string SellersFilePath, Management M1)
        {
            StreamWriter SWSellers = new StreamWriter(SellersFilePath);
            foreach (Seller seller in M1.Sellers)
            {
                SWSellers.WriteLine(seller.ToStringToFile());
            }
            SWSellers.Close();
        }
        public static void PraseCartItems(string cartItems, List<Product> cart, Management m1)
        {
            string[] items = cartItems.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int id = 0;
            bool found = false;
            string name = null;
            double price = 0;
            eCategory category = default;
            bool isSpecial = false;
            foreach (string item in items)
            {
                foreach (string detail in item.Split(','))
                {
                    if (detail.StartsWith("Name:"))
                    {
                        name = detail.Substring(5);
                    }
                    else if (detail.StartsWith("ID:"))
                    {
                        id = int.Parse(detail.Substring(3));
                        Product p = m1.GetProductFromSellers(id);
                        if (p != null)
                        {
                            cart.Add(p);
                            found = true;
                            break;
                        }
                    }
                    else if (detail.StartsWith("Price:"))
                    {
                        price = double.Parse(detail.Substring(6));
                    }
                    else if (detail.StartsWith("Category:"))
                    {
                        string categorystring = detail.Substring(9);
                        if (Enum.TryParse(categorystring, out eCategory parsedcategory))
                        {
                            category = parsedcategory;
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid category:{categorystring}");
                        }
                    }
                    else if (detail.StartsWith("(including special packaging)"))
                    {
                        isSpecial = true;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (!found)
            {
                if (isSpecial)
                {
                    SpecialProduct SP = new SpecialProduct(name, price, category);
                    cart.Add(SP);
                }
                else
                {
                    Product P = new Product(name, price, category);
                    cart.Add(P);
                }
            }
        }
        public static void ReadOrdersFromFile(string path, Buyer buyer, ref long position, Management m1)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                reader.BaseStream.Seek(position, SeekOrigin.Begin);
                reader.DiscardBufferedData();
                string line;
                List<Product> tempcart = new List<Product>();
                Order CurrentOrder = null;
                while ((line = reader.ReadLine()) != null)
                {
                    position += line.Length + 1;
                    if (string.IsNullOrEmpty(line))
                    {
                        if (CurrentOrder != null)
                        {
                            buyer.History.Add(CurrentOrder);
                            CurrentOrder = null;
                        }
                        continue;
                    }
                    if (line.StartsWith("Order("))
                    {
                        if (CurrentOrder != null)
                        {
                            buyer.History.Add(CurrentOrder);
                        }
                        CurrentOrder = new Order();
                    }
                    else if (line == "items:")
                    {
                        if (CurrentOrder != null)
                            CurrentOrder.Items = new List<Product>();
                    }
                    else if (line.StartsWith("(") && line.Contains("Name:"))
                    {
                        if (CurrentOrder != null)
                        {
                            PraseCartItems(line, tempcart, m1);
                            CurrentOrder.Items = tempcart;
                        }
                    }
                    else if (line.Contains("Total price:"))
                    {
                        break;
                    }
                }
                if (CurrentOrder != null)
                {
                    buyer.History.Add(CurrentOrder);
                }
            }
        }
        public static void ReadFromFile(string FilePath, Management M1)
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                User currentuser = null;
                Buyer tempbuyer = null;
                bool ISbuyer = false;
                long position = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    position += line.Length + Environment.NewLine.Length;
                    if (string.IsNullOrEmpty(line))
                    {
                        if (currentuser != null || tempbuyer != null)
                        {
                            if (ISbuyer)
                            {
                                M1.Buyers.Add(tempbuyer);
                            }
                            else
                            {
                                Seller seller = new Seller(currentuser);
                                M1.Sellers.Add(seller);
                            }
                        }
                        currentuser = null;
                        tempbuyer = null;
                        ISbuyer = false;
                        continue;
                    }
                    else if (line.StartsWith("Name:"))
                    {
                        if (currentuser == null)
                        {
                            currentuser = new User();
                        }
                        currentuser.Name = line.Substring(5);
                    }
                    else if (line.StartsWith("Password:"))
                    {
                        if (currentuser != null)
                        {
                            currentuser.Password = line.Substring(9);
                        }
                    }
                    else if (line.StartsWith("Address:"))
                    {
                        if (currentuser != null)
                        {
                            currentuser.Address = new Address();
                            continue;
                        }
                    }
                    else if (line.StartsWith("city:"))
                    {
                        if (currentuser != null && currentuser.Address != null)
                        {
                            currentuser.Address.City = line.Substring(5);
                        }
                    }
                    else if (line.StartsWith("street:"))
                    {
                        if (currentuser != null && currentuser.Address != null)
                        {
                            currentuser.Address.Street = line.Substring(7);
                        }
                    }
                    else if (line.StartsWith("num of buildings:"))
                    {
                        if (currentuser != null && currentuser.Address != null)
                        {
                            currentuser.Address.Building_number = int.Parse(line.Substring(17));
                        }
                    }
                    else if (line.StartsWith("state:"))
                    {
                        if (currentuser != null && currentuser.Address != null)
                        {
                            currentuser.Address.State = line.Substring(6);
                        }
                    }
                    else if (line.StartsWith("shopping cart:"))
                    {
                        if (currentuser != null)
                        {
                            string nextline = reader.ReadLine();
                            if (nextline == "There are no items in the shopping cart." || nextline == "There are no products for now")
                            {
                                continue;
                            }
                            else
                            {
                                while (!string.IsNullOrEmpty(nextline))
                                {
                                    if (ISbuyer)
                                    {
                                        PraseCartItems(nextline, tempbuyer.Cart, M1);
                                        nextline = reader.ReadLine();
                                    }
                                    else
                                    {
                                        PraseCartItems(nextline, currentuser.Cart, M1);
                                        nextline = reader.ReadLine();
                                    }
                                }
                            }
                        }
                    }
                    else if (line.StartsWith("orders:"))
                    {
                        ISbuyer = true;
                        tempbuyer = new Buyer(currentuser);
                        if (currentuser != null)
                        {
                            string nextline = reader.ReadLine();
                            if (nextline == "There are no paid orders.")
                            {
                                continue;
                            }
                            else
                            {
                                position = position - nextline.Length + 1;
                                while (nextline != "shopping cart:")
                                {
                                    ReadOrdersFromFile(FilePath, tempbuyer, ref position, M1);
                                    reader.BaseStream.Seek(position, SeekOrigin.Begin);
                                    reader.DiscardBufferedData();
                                    nextline = reader.ReadLine();
                                    if (string.IsNullOrEmpty(nextline))
                                        nextline = reader.ReadLine();
                                    if (reader.EndOfStream)
                                    {
                                        break;
                                    }
                                }
                                reader.BaseStream.Seek(position + 1, SeekOrigin.Begin);
                                reader.DiscardBufferedData();
                            }
                        }
                    }
                }
            }
        }
    }
}
