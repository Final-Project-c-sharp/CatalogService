using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Models;
namespace ProductCatalog.Repositories
{
    class Catalog
    {
        List<Product> catalog { get; set; } = new List<Product>();
        public void Display()
        {
            Console.WriteLine("\n\t Product Catalog");
            Console.WriteLine("=================================");
            if (catalog.Count != 0)
            {
                foreach (Product p in catalog)
                    Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine(" Here is any products! ");
            }
        }
    }
}
