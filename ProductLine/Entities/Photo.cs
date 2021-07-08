using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
