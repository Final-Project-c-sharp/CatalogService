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
            int res = 0;
            foreach (Employee e in em.company.Employees)
            {
                if (e.Login == login && e.Password == password)
                {
                    res = e.SecurityLvl;
                    break;
                }
            }
            if (res != 0)
            {
                return res;
            }
            else
            {                
                return 0;
            }
        }
    }
}
