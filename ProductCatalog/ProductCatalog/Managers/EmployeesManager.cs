using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Repositories;
using System.Runtime.Serialization.Json;
using ProductCatalog.Models;
using System.IO;
namespace ProductCatalog.Managers
{
    class EmployeesManager
    {
        public Company company { get; set; } = new Company();
        string path = @"..\..\..\DataStorage\employees.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Company));

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
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

    }
}
