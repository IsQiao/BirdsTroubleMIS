using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Models;

namespace BirdsTroubleMIS.Services
{
    public class LineService : BaseService<Line>
    {
        public override string CollectionName => "Line";

        public LineService(IBirdsTroubleDatabaseSettings settings) : base(settings)
        {
        }
    }
}
