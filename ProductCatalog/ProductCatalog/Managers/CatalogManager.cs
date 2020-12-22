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
        string path = @"..\..\..\Data\catalog.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Catalog));
        public CatalogManager()
        {
            LoadData();
        }
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
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


        public void AddNewProduct(Product p)
        {           
            catalog.Products.Add(p);
            SaveData();
        }

        public void DeleteProduct(string name)
        {
            int index = catalog.Products.FindIndex(x => x.Name == name);
            catalog.Products.RemoveAt(index);
            SaveData();
        }

        public void SellProduct(string name, int count)
        {
            int index = catalog.Products.FindIndex(x => x.Name == name);
            catalog.Products[index].Count -= count;
            SaveData();
        }

        public void AddCountProduct(string name, int count)
        {

            int index = catalog.Products.FindIndex(x => x.Name == name);
            catalog.Products[index].Count += count;
            SaveData();
        }

        public void DisplayProducts()
        {            
            Console.Clear();
            catalog.Display();
            Console.WriteLine("\n> Press any key for continue....");
            Console.ReadKey();
        }

        public void ChangeProduct(string name)
        {
            int index = catalog.Products.FindIndex(x => x.Name == name);
            if (index != -1)
            {
                Console.Clear();
                Console.WriteLine(" For skip press Enter. ");
                Console.WriteLine($" Current name - {catalog.Products[index].Name}");
                Console.Write("> New Or skip: ");
                string buff = Console.ReadLine();
                if (buff != "")
                {
                    catalog.Products[index].Name = buff;
                }

                Console.Clear();
                Console.WriteLine($" Current producer - {catalog.Products[index].Producer}");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    catalog.Products[index].Producer = buff;
                }

                Console.Clear();
                Console.WriteLine($" Current price - {catalog.Products[index].Price}");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    catalog.Products[index].Price = float.Parse(buff);
                }

                Console.Clear();
                Console.WriteLine($" Current Position - {catalog.Products[index].Count}");
                Console.Write("> New Or skip: ");
                buff = Console.ReadLine();
                if (buff != "")
                {
                    catalog.Products[index].Count = Int32.Parse(buff);
                }

               

                SaveData();
                Console.WriteLine("> Press any key for continue...");
                Console.ReadKey();
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
