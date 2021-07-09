using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Models
{
    public class ProductCreateModel
    {
        [Required]
        public string RefNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CretaedAt { get; set; } = DateTime.Now;
        [Required]
        public string Description { get; set; }
        [Required]
        public string AssemblyNr { get; set; }
        [Required]
        public string CategoryId { get; set; }
        public bool IsControlled { get; set; }
        public string Target { get; set; }
        public Land? Land { get; set; }
        public Market? Market { get; set; }
    }
}
