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
            if (Employees == null)
            {
                Console.WriteLine(" Here is any employees! ");

            }
            else if (Employees.Count != 0)
            {
                foreach (Employee e in Employees)
                    Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine(" Here is any employees! ");
            }
            Console.WriteLine("==================================================================");
        }

    }
}
