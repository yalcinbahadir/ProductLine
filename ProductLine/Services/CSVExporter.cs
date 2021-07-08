using ProductLine.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Services
{
    public static class CSVExporter
    {
        public static List<Product> Products { get; set; }

        public static void Export()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = DateTime.Now.Ticks.ToString();
            path = $"{path}/{fileName}.csv";

            using (StreamWriter writer=new StreamWriter(path))
            {
                foreach (var product in Products)
                {
                    writer.WriteLine($"{product.Id};{product.RefNumber};{product.Name};{product.CretaedAt};{product.Description};{product.AssemblyNr};{product.Category.CategoryName}");
                }
            }

            Products.Clear();
        }
    }
}
