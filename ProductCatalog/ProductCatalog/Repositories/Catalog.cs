using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Models;
using System.Runtime.Serialization;
namespace ProductCatalog.Repositories
{
    [DataContract]
    public class Catalog
    {
        [DataMember]
        public List<Product> Products { get; set; } = new List<Product>();
        public void Display()
        {
            Console.WriteLine("\n\t Product Catalog");
            Console.WriteLine("=================================");
            if (Products.Count != 0)
            {
                foreach (Product p in Products)
                    Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine(" Here is any products! ");
            }
        }
    }
}
