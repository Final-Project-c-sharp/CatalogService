using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Managers;
using ProductCatalog.Exceptions;
namespace ProductCatalog.UI_Menu
{
    class Menu
    {
        char choice ='y';
        MenuController mc = new MenuController();
        public void DisplayMainMenu()
        {
            bool accessFailed = false;
            while (choice == 'y')
            {                
                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine("|             Product Catalog Manager System. Version 1.0              |");
                Console.WriteLine("========================================================================");
                Console.WriteLine("|             Log in to continue working!                              |");
                if (accessFailed)
                {
                    Console.WriteLine("========================================================================");
                    Console.WriteLine("\n => Login or password is uncorrect! <= \n");
                }
                Console.WriteLine("========================================================================");
                Console.WriteLine("\n> Please input login: ");
                string login = Console.ReadLine();
                Console.WriteLine("========================================================================");
                Console.WriteLine("\n> Please input password: ");
                string password = Console.ReadLine();
                Console.WriteLine("========================================================================");
                AccountManager am = new AccountManager();
                int ver = am.Verify(login, password);
                switch (ver)
                {
                    case 0:
                        accessFailed = true;
                        break;
                    case 1:
                        LoaderMenu(login, am);
                        accessFailed = false;
                        break;
                    case 2:
                        SellerMenu(login, am);
                        accessFailed = false;
                        break;
                    case 3:
                        ManagerMenu(login, am);
                        accessFailed = false;
                        break;
                    case 4:
                        Admin(login, am);
                        accessFailed = false;
                        break;
                    default:
                        break;
                }
                if (!accessFailed)
                {
                    Console.WriteLine("\n> Do you want continue? (y/n)");
                    choice = Char.Parse(Console.ReadLine());                    
                }
            }
        }

        public void ManagerMenu(string login, AccountManager am)
        {
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine(" =======================================================");
                Console.WriteLine(" |                   Manager Menu                      |");
                Console.WriteLine(" =======================================================");
                Console.WriteLine($"    Welcome back, {am.Name(login)}!                ");
                Console.WriteLine(" =======================================================");
                Console.WriteLine(" |   1. Add new product                                |");
                Console.WriteLine(" |   2. Change product                                 |");
                Console.WriteLine(" |   3. Delete product                                 |");
                Console.WriteLine(" |   4. Display Employees                              |");
                Console.WriteLine(" |   5. Add new employee                               |");
                Console.WriteLine(" |   6. Delete employee                                |");
                Console.WriteLine(" |   7. Change employee                                |");
                Console.WriteLine(" |   0. Log out                                        |");
                Console.WriteLine(" =======================================================");
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

        public void LoaderMenu(string login, AccountManager am)
        {
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                Console.WriteLine(" =======================================================");
                Console.WriteLine(" |                   Loader Menu                       |");
                Console.WriteLine(" =======================================================");
                Console.WriteLine($"    Welcome back, {am.Name(login)}!                ");
                Console.WriteLine(" =======================================================");
                Console.WriteLine(" |   1. Add product to the sklad                       |");
                Console.WriteLine(" |   2. Display products                               |");
                Console.WriteLine(" |   3. Display user info                              |");
                Console.WriteLine(" |   0. Log out                                        |");
                Console.WriteLine(" =======================================================");
                Console.Write("\n> ");
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
                        mc.DisplayUser(am, login);
                        break;
                    default:
                        break;
                }
            }
        }

        public void SellerMenu(string login, AccountManager am)
        {
            bool exit = true;
                while (exit)
                {
                    Console.Clear();
                    Console.WriteLine(" =======================================================");
                    Console.WriteLine(" |                   Seller Menu                       |");
                    Console.WriteLine(" =======================================================");
                    Console.WriteLine($"    Welcome back, {am.Name(login)}!                    ");
                    Console.WriteLine(" =======================================================");
                    Console.WriteLine(" |   1. Sell product                                   |");
                    Console.WriteLine(" |   2. Change product                                 |");
                    Console.WriteLine(" |   3. Display user info                              |");
                    Console.WriteLine(" |   4. Display products                              |");
                    Console.WriteLine(" |   0. Log out                                        |");
                    Console.WriteLine(" =======================================================");
                    Console.Write("\n> ");
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
                        mc.DisplayUser(am, login);
                            break;
                        case 4:
                        mc.DisplayProducts();
                            break;
                    default:
                            break;
                    }
                }
        }

        public void Admin(string login, AccountManager am)
        {
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                
                Console.WriteLine(" =======================================================");
                Console.WriteLine(" |                   Admin Menu                        |");
                Console.WriteLine(" =======================================================");
                Console.WriteLine($"    Welcome back, {am.Name(login)}!                    ");
                Console.WriteLine(" =======================================================");
                Console.WriteLine(" |   1. Add new product                                |");
                Console.WriteLine(" |   2. Change product                                 |");
                Console.WriteLine(" |   3. Delete product                                 |");
                Console.WriteLine(" |   4. Display Employees                              |");
                Console.WriteLine(" |   5. Add new employee                               |");
                Console.WriteLine(" |   6. Delete employee                                |");
                Console.WriteLine(" |   7. Change employee                                |");
                Console.WriteLine(" |   8. Sell product                                   |");
                Console.WriteLine(" |   9. Add product to storage                         |");
                Console.WriteLine(" |   10. Display products                              |");
                Console.WriteLine(" |   0. Log out                                        |");
                Console.WriteLine(" =======================================================");
                Console.Write("\n> ");
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
            if (!Int32.TryParse(Console.ReadLine(), out int a))
                throw new BadInputException("Wrong symbol!");
            else
            {
                return a;
            }
        }
        
    }
}