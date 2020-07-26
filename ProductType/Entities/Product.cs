﻿using System.Text;
using System.Globalization;

namespace ProductType.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { 
        }
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {
            StringBuilder text = new StringBuilder();
            text.Append(Name);
            text.AppendLine(" $ " + Price.ToString("F2", CultureInfo.InvariantCulture));
            return text.ToString();
        }
    }
}