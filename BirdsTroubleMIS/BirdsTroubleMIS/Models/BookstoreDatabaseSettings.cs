namespace BirdsTroubleMIS.Models
{
    public class BirdsTroubleDatabaseSettings : IBirdsTroubleDatabaseSettings
    {
        public string LineCollectionName { get; set; }

        public string BirdsTroubleCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }

    public interface IBirdsTroubleDatabaseSettings
    {
        string BirdsTroubleCollectionName { get; set; }

        string LineCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}
