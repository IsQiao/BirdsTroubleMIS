using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Models;

namespace BirdsTroubleMIS.Services
{
    public class BirdTroubleService : BaseService<BirdTrouble>
    {
        public override string CollectionName => "BirdsTrouble";

        public BirdTroubleService(IBirdsTroubleDatabaseSettings settings) : base(settings)
        {
        }
    }
}
