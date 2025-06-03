using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EShop
{
    public enum eCategory { Kids, Electricity, Office, Clothes };
    public class Product
    {
        protected string name;
        protected double price;
        protected static int serial_num = 0;
        protected readonly int id;
        private eCategory category;

        public Product(string name, double price, eCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            serial_num++;
            id = serial_num;
        }
        public Product(Product other)
        {
            name = other.name;
            price = other.price;
            category = other.category;
            id = serial_num;
        }
        public static Product CreateProduct()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter product's name:");
                    string name = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(name))
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }

                    Console.WriteLine("Enter price:");
                    double price = double.Parse(Console.ReadLine());
                    while(price <= 0)
                    {
                        Console.WriteLine("Price must be bigger than 0");
                        price = double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Enter product's category.");
                    Console.WriteLine("please enter the type of the product:\nKids-(0)\nClothes-(1)\nElectricity-(2)\nOffice-(3)");
                    int category = int.Parse(Console.ReadLine());
                    while (category < 0 || category > 3)
                    {
                        Console.WriteLine("Invalid value. please intsert value between 0-3");
                        category = int.Parse(Console.ReadLine());
                    }
                    eCategory Category2 = (eCategory)category;
                    return new Product(name, price, Category2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. please enter a valid price.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred:" + ex.Message);
                }
            }
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
        public virtual double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be positive");
                }
                price = value;
            }
        }
        public eCategory Category
        {
            get => category;
            set
            {
                if ((int)value >= 0 && (int)value <= 3)
                {
                    category = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Invalid value. Please insert value between 0-3");
                }
            }
        }
        public int GetId()
        {
            return id;
        }
        public override string ToString()
        {
            return $"Name:{name},ID:{id},Price:{price},Category:{category}\n";
        }
        public int Equals(Product other)
        {
            if (other == null) return -1;

            if (name != other.Name || price != other.price || id != other.id || category != other.Category)
            {
                return -1;
            }
            return 0;
        }
    }
}
