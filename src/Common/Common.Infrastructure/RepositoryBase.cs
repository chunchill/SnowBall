using System.Collections.Generic;
using Common.Core.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Common.Infrastructure
{
    public class RepositoryBase<T> : IRepository<T>
    {
        public void Add(T entity)
        {
            var client = new MongoClient("mongodb://xujihui1985:C8i0s4c8o6@ds029107.mongolab.com:29107/datacenter");
            var collection = client.GetServer().GetDatabase("datacenter").GetCollection<T>("products");
            collection.Insert(entity);
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T GetById(ObjectId id)
        {
            throw new System.NotImplementedException();
        }
    }
}