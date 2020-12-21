using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Repositories;
namespace ProductCatalog.Managers
{
    class EmployeesManager
    {
        public Employees emp { get; set; } = new Employees();
        public void DisplayEmployees()
        {
            emp.Display();        
        }

    }
}
