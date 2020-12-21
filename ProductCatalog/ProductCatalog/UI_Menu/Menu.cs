using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Managers;
namespace ProductCatalog.UI_Menu
{
    class Menu
    {
        char choice ='y';
        
        public void DisplayMainMenu()
        { 
            while (choice == 'y')
            {
                Console.WriteLine("\t\t Product Catalog Manager System. Version 1.0");
                Console.WriteLine("\n");
                Console.WriteLine("\n> Please input login: ");
                string login = Console.ReadLine();
                Console.WriteLine("\n> Please input password: ");
                string password = Console.ReadLine();
                AccountManager am = new AccountManager();
                int ver = am.Verify("", "");
                switch (ver)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
