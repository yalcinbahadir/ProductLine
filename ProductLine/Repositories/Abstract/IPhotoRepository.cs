using ProductLine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Repositories.Abstract
{
    public interface IPhotoRepository : IRepository<Photo>
    {
        Task<Photo> AddAsync(Photo entity);
    }
}
