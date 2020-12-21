using System;
using System.Collections.Generic;
using System.Text;
using ProductCatalog.Repositories;
using System.Runtime.Serialization.Json;
using ProductCatalog.Models;
using System.IO;
namespace ProductCatalog.Managers
{
    public class CatalogManager
    {
        public Catalog catalog { get; set; } = new Catalog();
        string path = @"..\..\..\DataStorage\catalog.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Catalog));
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, catalog);
            }
        }
        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                catalog = (Catalog)serializer.ReadObject(fs);
            }
        }


    }
}
