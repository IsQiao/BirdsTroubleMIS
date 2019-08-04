using System.Collections.Generic;

namespace BirdsTroubleMIS.Models
{
    public class ListViewModel<T>
    {
        public long Total { get; set; }
        public List<T> List { get; set; }
    }
}
