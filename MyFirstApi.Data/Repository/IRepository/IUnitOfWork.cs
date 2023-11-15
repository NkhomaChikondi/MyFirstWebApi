using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApi.Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategory Category { get; }
        
        void Save();
    }
}
