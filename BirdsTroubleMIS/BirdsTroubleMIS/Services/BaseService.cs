using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BirdsTroubleMIS.Services
{
    public abstract class BaseService<T> where T : IEntity
    {
        private readonly IMongoCollection<T> _rows;

        public abstract string CollectionName { get; }

        public BaseService(IBirdsTroubleDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _rows = database.GetCollection<T>(CollectionName);
        }

        public List<T> Get() => _rows.Find(row => true).ToList();

        public T Get(string id) => _rows.Find<T>(row => row.Id == id).FirstOrDefault();

        public T Create(T row)
        {
            _rows.InsertOne(row);
            return row;
        }

        public void Update(string id, T rowIn) =>
            _rows.ReplaceOne(row => row.Id == id, rowIn);

        public void Remove(T rowIn) =>
            _rows.DeleteOne(row => row.Id == rowIn.Id);

        public void Remove(string id) =>
            _rows.DeleteOne(book => book.Id == id);
    }
}
