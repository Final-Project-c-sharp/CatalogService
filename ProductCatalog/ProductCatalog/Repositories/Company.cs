using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Models;
using System.Runtime.Serialization;
namespace ProductCatalog.Repositories
{
    [DataContract]
    public class Company
    {
        [DataMember]
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void Display()
        {
            Console.WriteLine("\n\t Employees list");
            Console.WriteLine("==================================================================");
            if (Employees.Count != 0)
            {
                foreach(Employee l in Employees)
                    Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine($" Here is any employees yet! ");
            }
            Console.WriteLine("==================================================================");
        }

    }
}
