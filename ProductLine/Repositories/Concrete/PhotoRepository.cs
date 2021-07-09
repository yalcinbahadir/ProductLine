using ProductLine.Data;
using ProductLine.Entities;
using ProductLine.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Repositories.Concrete
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly AppDbContext _context;

        public PhotoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Photo Add(Photo entity)
        {
            var result = _context.Photos.Add(entity);
            _context.SaveChanges();
            return result.Entity;

        }

        public async Task<Photo> AddAsync(Photo entity)
        {
            var result = await _context.Photos.AddAsync(entity);
            await _context.SaveChangesAsync();       
            return result.Entity;

        }

        public bool Delete(int id)
        {
            var photo = _context.Photos.FirstOrDefault(p => p.Id == id);
            if(photo != null)
            {
                 _context.Photos.Remove(photo);               
            }

            return _context.SaveChanges() > 0;
        }

        public IEnumerable<Photo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Photo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Photo Update(Photo entity)
        {
            throw new NotImplementedException();
        }
    }
}
