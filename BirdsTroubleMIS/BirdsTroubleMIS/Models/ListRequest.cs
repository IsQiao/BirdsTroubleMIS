using Microsoft.AspNetCore.Mvc;

namespace BirdsTroubleMIS.Models
{
    public class ListRequest
    {
        [FromQuery(Name = "pi")]
        public int PageIndex { get; set; } = 0;

        [FromQuery(Name = "ps")]
        public int PageSize { get; set; } = 10;

        [FromQuery]
        public string FilterString { get; set; }
    }
}
