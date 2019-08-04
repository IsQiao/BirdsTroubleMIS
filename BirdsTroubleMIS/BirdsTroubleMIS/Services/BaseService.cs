using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

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

        //public List<T> Get() => _rows.Find(row => true).ToList();

        public async Task<ListViewModel<T>> GetAsync(int pageIndex = 0, int pageSize = 10, Expression<Func<T, bool>> filter = default, CancellationToken cancellationToken = default)
        {
            //var queryExpression = _rows.Find(row => true);
            if (filter == null)
            {
                filter = (T) => true;
            }

            var list = await _rows.Find(filter).Sort(new BsonDocument("_id", -1)).Skip(pageIndex * pageIndex).Limit(pageSize).ToListAsync(cancellationToken);
            var total = await _rows.Find(filter).CountDocumentsAsync();
            var response = new ListViewModel<T>()
            {
                List = list,
                Total = total
            };

            return response;
        }


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
