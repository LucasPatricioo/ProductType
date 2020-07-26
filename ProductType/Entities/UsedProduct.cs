using System;
using System.Globalization;
using System.Text;

namespace ProductType.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            StringBuilder text = new StringBuilder();
            text.Append(Name);
            text.Append(" (used) $ ");
            text.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            text.Append(" (Manufacture date: ");
            text.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            text.AppendLine(")");
            return text.ToString();
        }
    }
}
