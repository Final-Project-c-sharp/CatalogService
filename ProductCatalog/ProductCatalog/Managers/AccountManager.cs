using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProductCatalog.Models;
namespace ProductCatalog.Managers
{
    public class AccountManager
    {
        EmployeesManager em = new EmployeesManager();
        public AccountManager()
        {
            em.LoadData();
        }
        public int Verify(string login, string password)
        {
            //Employee res = (Employee)em.company.Employees.Where(l => l.Login == login && l.Password == password);

            //if (res != null)
            //{
            //    return res.SecurityLvl;
            //}
            //else
            //{
            //    return 4;
            //}
            return 4;
        }
    }
}
