using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Models;

namespace BirdsTroubleMIS.Services
{
    public class BookService : BaseService<Book>
    {
        public override string CollectionName => "BirdsTrouble";

        public BookService(IBirdsTroubleDatabaseSettings settings) : base(settings)
        {
        }
    }
}
