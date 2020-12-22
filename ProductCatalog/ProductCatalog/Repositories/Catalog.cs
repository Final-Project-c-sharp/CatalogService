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
            Console.WriteLine("==================================================================");
            Console.WriteLine("|                        Product Catalog                         |");
            Console.WriteLine("==================================================================");
            Console.WriteLine($"| {"Name",15} | {"Producer",20} | {"Price",10}$ | {"Count",7} |");
            Console.WriteLine("==================================================================");
            if (Products == null)
            {
                Console.WriteLine(" Here is any products! ");
                
            }
            else if (Products.Count != 0)
            {
                foreach (Product p in Products)
                {
                    Console.WriteLine(p);
                    Console.WriteLine(" -----------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(" Here is any products! ");
            }
        }
    }
}
