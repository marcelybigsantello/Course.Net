using System;
using System.Globalization;

namespace Lambda_Delegates_LINQ.Entities
{
    class Product
    {
        public string Name;
        public float Price;

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
