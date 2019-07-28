using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BirdsTroubleMIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly LineService _service;

        public LineController(LineService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Line>> Get() => _service.Get();

        [HttpPost]
        public ActionResult<Line> Create(Line row)
        {
            _service.Create(row);

            return CreatedAtRoute("GetLine", new { id = row.Id.ToString() }, row);
        }

        [HttpGet("{id:length(24)}", Name = "GetLine")]
        public ActionResult<Line> Get(string id)
        {
            var row = _service.Get(id);

            if (row == null)
            {
                return NotFound();
            }

            return row;
        }
    }
}
