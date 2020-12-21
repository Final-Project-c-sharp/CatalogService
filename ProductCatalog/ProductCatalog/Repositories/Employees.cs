using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Models;
namespace ProductCatalog.Repositories
{
    class Employees
    {
        public List<Loader> Loaders { get; set; } = new List<Loader>();
        public List<Manager> Managers { get; set; } = new List<Manager>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();
        public void Display()
        {
            Console.WriteLine("\n\t Employees list");
            Console.WriteLine("=================================");
            Console.WriteLine("\n Loaders list:");
            if (Loaders.Count != 0)
            {
                foreach(Loader l in Loaders)
                    Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine($" Here is any loaders yet! ");
            }

            Console.WriteLine("=================================");
            Console.WriteLine("\n Managers list:");
            if (Managers.Count != 0)
            {
                foreach (Manager m in Managers)
                    Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine($" Here is any managers yet! ");
            }

            Console.WriteLine("=================================");
            Console.WriteLine("\n Seller list:");
            if (Sellers.Count != 0)
            {
                foreach (Seller s in Sellers)
                    Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine($" Here is any sellers yet! ");
            }
            Console.WriteLine("=================================");
        }

    }
}
