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
            Employee res = em.company.Employees.Single(l => l.Login == login && l.Password == password); //Where(l => l.Login == login && l.Password == password).Take(1);
             // Вот в этой функции
            if (true)
            {
                return res.SecurityLvl;
            }
            else
            {
                return 0;
            }
        }
    }
}
