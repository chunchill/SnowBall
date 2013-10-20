using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Common.Core.Interfaces
{
    public interface IRepository
    {
    }

    public interface IRepository<T> : IRepository
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll(T entity);
        T GetById (ObjectId id);
    }
}
