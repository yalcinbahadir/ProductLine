using ProductLine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string RefNumber { get; set; }
        public string Name { get; set; }
        public DateTime CretaedAt { get; set; }
        public string Description { get; set; }
        public string AssemblyNr { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
     
        public IEnumerable<Photo> Photos { get; set; }
        public bool IsControlled { get; set; }
        public string Target { get; set; }
        public Land? Land { get; set; }
        public Market? Market { get; set; }      
        public Product()
        {
           // Photos = new List<Photo> { new Photo {Id=Id, Url= "https://via.placeholder.com/150" } };
        }
    }
}
