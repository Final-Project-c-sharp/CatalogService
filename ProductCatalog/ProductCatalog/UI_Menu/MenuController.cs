﻿using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Managers;
using ProductCatalog.Models;
using ProductCatalog.Exceptions;
namespace ProductCatalog.UI_Menu
{
    class MenuController
    {
        public EmployeesManager em = new EmployeesManager();
        public CatalogManager cm = new CatalogManager();

        public void AddNewProduct()
        {
            Product p = new Product();
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine(" Input product name: ");
            p.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine(" Input product producer: ");
            p.Producer = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine(" Input product price: ");
            if (!float.TryParse(Console.ReadLine(), out float price))
                throw new BadInputException("Wrong input!");
            else
                p.Price = price;
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine(" Input product count in the storage: ");
            p.Count = Int32.Parse(Console.ReadLine());
            cm.AddNewProduct(p);
        }

        public void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input name: ");
            string name = Console.ReadLine();
            cm.DeleteProduct(name);
        }

        public void ChangeProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input name: ");
            string name = Console.ReadLine();
            cm.ChangeProduct(name);
        }

        public void SellProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input name: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input count: ");
            int count = Int32.Parse(Console.ReadLine());                        
        }

        public void AddCountProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input name: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input count: ");
            int count = Int32.Parse(Console.ReadLine());
            cm.AddCountProduct(name, count);
        }

        public void DisplayEmployees()
        {
            em.DisplayEmployees();
        }

        public void AddEmployee()
        {

            Employee emp = new Employee();

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input name: ");
            emp.Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input Surname: ");
            emp.SurName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input age: ");
            emp.Age = Int32.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input position: ");
            emp.Position = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input phone number: ");
            emp.PhoneNumber = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input salary: ");
            emp.Salary = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input Login (for your account): ");
            emp.Login = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input Password: ");
            emp.Password = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("> Input Security level( 1 - Loader, 2 - Seller, 3 - Manager, 4 - Admin/Boss): ");
            emp.SecurityLvl = Int32.Parse(Console.ReadLine());
            em.AddEmployee(emp);
        }

        public void DelEmployee()
        {
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input name: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input surname: ");
            string surname = Console.ReadLine();
            em.DelEmployee(name, surname);          
        }

        public void ChangeEmployeeInfo()
        {
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input name: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("========================================================================");
            Console.WriteLine("Please input surname: ");
            string surname = Console.ReadLine();
            em.ChangeEmployee(name, surname);
        }

        public void DisplayProducts()
        {
            cm.DisplayProducts();
        }

        public void DisplayUser(AccountManager am, string login)
        {
            Console.Clear();
            am.DisplayUser(login);
            Console.WriteLine("\n> Press enter for continue....");
            Console.ReadKey();
        }        
    }
}
