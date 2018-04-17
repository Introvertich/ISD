using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "49000";
            address.Country = "Ukraine";
            address.City = "Dnipro";
            address.Street = "Shevchenko";
            address.House = "14";
            address.Apartment = "1";

            Console.WriteLine("Index: {0}\nCountry: {1}\nCity: {2}\nStreet: {3}\nHouse: {4}\nApartment: {5}\n",
                address.Index, address.Country, address.City, address.Street, address.House, address.Apartment);

            Console.ReadLine();
        }
    }
}
