using MyFirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApi.Data.Repository.IRepository
{
    public interface ICategory : IRepository<Category>
    {
        void Update(Category category);
    }
}
