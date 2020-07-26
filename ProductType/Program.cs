using ProductType.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProductType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Product> Prod = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #{0} data:", i);
                Console.Write("Common, used or imported (c/u/i)? ");
                char tProd = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tProd == 'c')
                {
                    Prod.Add(new Product(name, price));
                }
                else if (tProd == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    Prod.Add(new UsedProduct(name, price, date));
                }
                else if (tProd == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Prod.Add(new ImportedProduct(name, price, customFee));
                }
            }
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product p in Prod)
            {
                Console.Write(p.PriceTag());
            }
        }
    }
}
