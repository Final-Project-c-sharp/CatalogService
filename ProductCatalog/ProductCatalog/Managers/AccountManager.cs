using System;
using System.Collections.Generic;
using System.Text;
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
            //em.company.Employees[0].Login
            return 0;
        }
    }
}
