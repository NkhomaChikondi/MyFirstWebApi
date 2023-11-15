using MyFirstApi.Data.DataAccess;
using MyFirstApi.Data.Repository.IRepository;
using MyFirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApi.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategory
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db) 
        {
             this._db = db;
        }

        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }   
}
