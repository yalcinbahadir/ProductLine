using ProductLine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Models
{
    public class ProductEditModel
    {
        public int Id { get; set; }
        [Required]
        public string RefNumber { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CretaedAt { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string AssemblyNr { get; set; }
        [Required]
        public string CategoryId { get; set; }
        public bool IsControlled { get; set; }
        [Required]
        public Target? Target { get; set; }
        [Required]
        public Land? Land { get; set; }
        [Required]
        public Market? Market { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
