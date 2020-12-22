using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Repositories;
using System.Runtime.Serialization.Json;
using ProductCatalog.Models;
using System.IO;
using System.Linq;
namespace ProductCatalog.Managers
{
    class EmployeesManager
    {
        public Company company { get; set; } = new Company();
        string path = @"..\..\..\Data\employees.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Company));
        
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                serializer.WriteObject(fs, company);
            }
        }
        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                company = (Company)serializer.ReadObject(fs);
            }
        }
        
        public EmployeesManager()
        {
            LoadData();
        }

        public void DisplayEmployees()
        {
            Console.Clear();
            company.Display();
            Console.WriteLine("\n> Press any key for continue....");
            Console.ReadKey();
        }

        public void AddEmployee(Employee emp)
        {
            Console.Clear();
            Console.WriteLine(" =======================================================================================================================================================");
            Console.WriteLine(emp);
            Console.WriteLine(" =======================================================================================================================================================");
            Console.WriteLine("> Data Correct? Type 'n' for change date and 'y' for continue.          ");
            Console.WriteLine("========================================================================");
            company.Employees.Add(emp);
            SaveData();

            if(Char.Parse(Console.ReadLine()) == 'n')
            {
                ChangeEmployee(emp.Name, emp.SurName);
            }
        }

        public void DelEmployee(string name, string surname)
        {
            int index = company.Employees.FindIndex(x => x.Name == name && x.SurName == surname);
            company.Employees.RemoveAt(index);
            SaveData();
        }

        public void ChangeEmployee(string name, string surname)
        {
            int index = company.Employees.FindIndex(x => x.Name == name && x.SurName == surname);
            if (index != -1)
            {
                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine(" For skip press Enter. ");
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current name - {company.Employees[index].Name}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                string buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].Name = buff;
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current surname - {company.Employees[index].SurName}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].SurName = buff;
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current Age - {company.Employees[index].Age}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].Age = Int32.Parse(buff);
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current Position - {company.Employees[index].Position}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].Position = buff;
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current Phone Number- {company.Employees[index].PhoneNumber}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].PhoneNumber = buff;
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current Salary - {company.Employees[index].Salary}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].Salary = float.Parse(buff);
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current Login - {company.Employees[index].Login}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].Login = buff;
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current Password - {company.Employees[index].Password}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].Password = buff;
                }

                Console.Clear();
                Console.WriteLine("========================================================================");
                Console.WriteLine($" Current Security Level - {company.Employees[index].SecurityLvl}");
                Console.WriteLine("========================================================================");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    company.Employees[index].SecurityLvl = Int32.Parse(buff);
                }
                Console.Clear();
                Console.WriteLine(" =======================================================================================================================================================");
                Console.WriteLine(company.Employees[index]);
                Console.WriteLine(" =======================================================================================================================================================");
                Console.WriteLine("> Data Correct? Type 'n' for change date and 'y' for continue.          ");
                Console.WriteLine("========================================================================");
                SaveData();
                if (Char.Parse(Console.ReadLine()) == 'n')
                {
                    ChangeEmployee(company.Employees[index].Name, company.Employees[index].SurName);
                }
                else
                {
                    Console.WriteLine("> Press any key for continue...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No matches!");
                Console.WriteLine("> Press any key for continue...");
                Console.ReadKey();
            }
        }
        
    }
}
