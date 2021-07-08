using System;
using System.Collections.Generic;
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
    }
}
