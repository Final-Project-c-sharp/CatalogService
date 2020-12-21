using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Managers;
namespace ProductCatalog.UI_Menu
{
    class Menu
    {
        char choice ='y';
        MenuController mc = new MenuController();
        public void DisplayMainMenu()
        { 
            while (choice == 'y')
            {
                Console.Clear();
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
                        LoaderMenu();
                        break;
                    case 2:
                        SellerMenu();
                        break;
                    case 3:
                        ManagerMenu();
                        break;
                    case 4:
                        Admin();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n> Do you want continue? (y/n)");
                choice = Char.Parse(Console.ReadLine());
                
            }
        }

        public void ManagerMenu()
        {
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine("\t Manager Menu ");
                Console.WriteLine(" 1. Add new product");
                Console.WriteLine(" 2. Change product ");
                Console.WriteLine(" 3. Delete product ");
                Console.WriteLine(" 4. Display Employees");
                Console.WriteLine(" 5. Add new employee ");
                Console.WriteLine(" 6. Delete employee ");
                Console.WriteLine(" 7. Change employee");
                Console.WriteLine(" 0. Log out");
                switch (GetAnswer())
                {
                    case 0:
                        exit = false;
                        break;
                    case 1:
                        mc.AddNewProduct();
                        break;
                    case 2:
                        mc.ChangeProduct();
                        break;
                    case 3:
                        mc.DeleteProduct();
                        break;
                    case 4:
                        mc.DisplayEmployees();
                        break;
                    case 5:
                        mc.AddEmployee();
                        break;
                    case 6:
                        mc.DelEmployee();
                        break;
                    case 7:
                        mc.ChangeEmployeeInfo();
                        break;
                    default:
                        break;
                }
            }
        }

        public void LoaderMenu()
        {
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine("\t Loader Menu ");
                Console.WriteLine(" 1. Add product to the sklad ");
                Console.WriteLine(" 2. Display products ");
                Console.WriteLine(" 3. Display user info ");
                Console.WriteLine(" 0. Log out");
                switch (GetAnswer())
                {
                    case 0:
                        exit = false;
                        break;
                    case 1:
                        mc.AddCountProduct();
                        break;
                    case 2:
                        mc.DisplayProducts();
                        break;
                    case 3:
                        mc.DisplayUser();
                        break;
                    default:
                        break;
                }
            }
        }

        public void SellerMenu()
        {
            bool exit = true;
                while (exit)
                {
                    Console.Clear();
                    Console.WriteLine("\t Loader Menu ");
                    Console.WriteLine(" 1. Sell product ");
                    Console.WriteLine(" 2. Change product ");
                    Console.WriteLine(" 3. Display user info ");
                    Console.WriteLine(" 0. Log out");
                    switch (GetAnswer())
                    {
                        case 0:
                            exit = false;
                            break;
                        case 1:
                        mc.SellProduct();
                            break;
                        case 2:
                        mc.ChangeProduct();
                            break;
                        case 3:
                        mc.DisplayUser();
                            break;
                        default:
                            break;
                    }
                }
        }

        public void Admin()
        {
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine("\t Manager Menu ");
                Console.WriteLine(" 1. Add new product");
                Console.WriteLine(" 2. Change product ");
                Console.WriteLine(" 3. Delete product ");
                Console.WriteLine(" 4. Display Employees");
                Console.WriteLine(" 5. Add new employee ");
                Console.WriteLine(" 6. Delete employee ");
                Console.WriteLine(" 7. Change employee");
                Console.WriteLine(" 8. Sell product");
                Console.WriteLine(" 9. Add product to the sklad ");
                Console.WriteLine(" 10. Display products ");
                Console.WriteLine(" 0. Log out");
                switch (GetAnswer())
                {
                    case 0:
                        exit = false;
                        break;
                    case 1:
                        mc.AddNewProduct();
                        break;
                    case 2:
                        mc.ChangeProduct();
                        break;
                    case 3:
                        mc.DeleteProduct();
                        break;
                    case 4:
                        mc.DisplayEmployees();
                        break;
                    case 5:
                        mc.AddEmployee();
                        break;
                    case 6:
                        mc.DelEmployee();
                        break;
                    case 7:
                        mc.ChangeEmployeeInfo();
                        break;
                    case 8:
                        mc.SellProduct();
                        break;
                    case 9:
                        mc.AddCountProduct();
                        break;
                    case 10:
                        mc.DisplayProducts();
                        break;
                    default:
                        break;
                }

            }
        }

        private int GetAnswer()
        {
            return Int32.Parse(Console.ReadLine());
        }
    }
}
