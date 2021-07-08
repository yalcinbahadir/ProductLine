using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Infrastructure
{
    public class PageManager<T> where T:class
    {
        public  double TotalItems => Collection.Count()>0 ?Collection.Count():0;
        public  int ItemPerPage { get; set; } = 4;
        public  int TotalPages => (int)Math.Ceiling(TotalItems/ItemPerPage);
        public  IEnumerable<T> Collection { get; set; }
        public  IEnumerable<T> PageCollection(int index)
        {
            var result= Collection.Skip((index - 1) * ItemPerPage).Take(ItemPerPage).ToList();

            return result; 
        }
    }
}
