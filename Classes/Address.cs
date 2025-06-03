using EShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class Address
    {
        private string street;
        private string city;
        private string state;
        private int building_number;

        public string Street
        {
            get => street;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Street cannot be empty or Null.");
                }
                street = value;
            }
        }
        public string City
        {
            get => city;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("City cannot be empty or Null.");
                }
                city = value;
            }
        }
        public string State
        {
            get => state;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("City cannot be empty or Null.");
                }
                state = value;
            }
        }
        public int Building_number
        {
            get => building_number;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Building number must be positive.");
                }
                building_number = value;
            }
        }
        public Address(string street, string city, string state, int building_number)
        {
            Street = street;
            City = city;
            State = state;
            Building_number = building_number;
        }
        public Address() { }
        public Address  (Address other)
        {
            Street = other.Street;
            City = other.City;
            State = other.State;
            building_number = other.Building_number;
        }
        public static Address CreateAddress()
        {
            string street = string.Empty;
            string city = string.Empty;
            string state = string.Empty;
            int buildingNumber = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter street:");
                    street = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(street))
                    {
                        throw new ArgumentException("Street cannot be empty");
                    }

                    Console.WriteLine("Enter city:");
                    city = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(city))
                    {
                        throw new ArgumentException("City cannot be empty");
                    }

                    Console.WriteLine("Enter state:");
                    state = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(state))
                    {
                        throw new ArgumentException("State cannot be empty");
                    }

                    Console.WriteLine("Enter building number:");
                    buildingNumber = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. please enter a valid building number.");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            return new Address(street, city, state, buildingNumber);
        }
        public override string ToString()
        {
            return $"city:{city}\nstreet:{street}\nnum of buildings:{building_number}\nstate:{state}";
        }

        public int Equals(Address other)
        {
            if( other == null ) return -1;

            if (Street != other.street || City != other.City || State != other.state || Building_number != other.Building_number)
            {
                return -1;
            }
            return 0;
        }
    }
}
