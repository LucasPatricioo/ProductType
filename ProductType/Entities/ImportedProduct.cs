using System.Globalization;
using System.Text;

namespace ProductType.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price += CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder text = new StringBuilder();
            text.Append(Name);
            text.Append(" $ ");
            text.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            text.Append(" (Customs fee: $ ");
            text.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            text.AppendLine(")");
            return text.ToString();
        }

    }
}
