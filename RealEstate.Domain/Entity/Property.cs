using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entity
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public decimal Price { get; private set; }
        public Property(string name, string address, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty", nameof(name));
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero", nameof(price));

            Name = name;
            Address = address ?? "";
            Price = price;
        }

        public void UpdateDetails(string name, string address, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty", nameof(name));
            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero", nameof(price));

            Name = name;
            Address = address ?? "";
            Price = price;
        }
    }
}
