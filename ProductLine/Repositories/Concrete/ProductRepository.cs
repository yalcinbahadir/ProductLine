using Microsoft.EntityFrameworkCore;
using ProductLine.Data;
using ProductLine.Entities;
using ProductLine.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public Product Add(Product entity)
        {
            var result=_context.Products.Add(entity);
            _context.SaveChanges();
            return result.Entity;
        }

        public bool Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p=>p.Id==id);
            if (product ==null)
            {
                 _context.Products.Remove(product);               
            }

            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.Include(p=>p.Category).Include(p=>p.Photos);
        }


        public Product GetById(int id)
        {
            return _context.Products.Include(p => p.Category).Include(p => p.Photos).FirstOrDefault(p=>p.Id==id);
        }


        public Product Update(Product entity)
        {
            var p = GetById(entity.Id);
            p.Name = entity.Name;
            p.CretaedAt = entity.CretaedAt;
            p.AssemblyNr = entity.AssemblyNr;
            p.Description = entity.Description;
            p.CategoryId = entity.CategoryId;
            _context.SaveChanges();
            return p;
        }

        public IEnumerable<Product> GetByName(string name)
        {
            var query = GetAll().AsQueryable();
            return query.Where(p => p.Name.ToUpper().Contains(name.ToUpper()));
        }

        public IEnumerable<Product> GetByRefNumber(string refNumber)
        {
            var query = GetAll().AsQueryable();
            return query.Where(p => p.RefNumber.ToUpper().Contains(refNumber.ToUpper()));
        }

        public IEnumerable<Product> GetByAssemblyNumber(string assemblyNumber)
        {
            var query = GetAll().AsQueryable();
            return query.Where(p => p.AssemblyNr.ToUpper().Contains(assemblyNumber.ToUpper()));
        }

        public IEnumerable<Product> GetByCategory(string category)
        {
            var query = GetAll().AsQueryable();
            return query.Where(p => p.Category.CategoryName.ToUpper().Contains(category.ToUpper()));
        }

        public IEnumerable<Product> GetByDescription(string description)
        {
            var query = GetAll().AsQueryable();
            return query.Where(p => p.Description.ToUpper().Contains(description.ToUpper()));
        }

    }
}
