using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class SpecialProduct : Product
    {
        private const double Packaging_Price = 50;

        public SpecialProduct(string name, double price, eCategory category) : base(name, price, category)
        {
            SpecialPrice = price + Packaging_Price;
        }
        public double SpecialPrice {get;}

        public SpecialProduct(Product product):base(product) 
        {
            SpecialPrice=Packaging_Price + price;
        }
        public static Product CreateSpecialProduct()
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

                    Console.WriteLine("Enter product's category");
                    Console.WriteLine("please enter the type of the product:\nKids(0)\nClothes(1)\nElectricity(2)\nOffice(3)");
                    int category = int.Parse(Console.ReadLine());
                    while (category <= 0 && category >= 3)
                    {
                        Console.WriteLine("Invalid value. please intsert value between 0-3");
                        category = int.Parse(Console.ReadLine());
                    }
                    eCategory Category2 = (eCategory)category;
                    Console.WriteLine("Product was added successfully.");
                    return new SpecialProduct(name, price, Category2);
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
        public override string ToString()
        {
            return $"Name:{Name},ID:{GetId()},Price:{SpecialPrice},(including special packaging),Category:{Category}\n";
        }
    }
}
