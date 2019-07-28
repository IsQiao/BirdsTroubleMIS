namespace BirdsTroubleMIS.Models
{
    public class BirdsTroubleDatabaseSettings : IBirdsTroubleDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }

    public interface IBirdsTroubleDatabaseSettings
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }
    }
}
