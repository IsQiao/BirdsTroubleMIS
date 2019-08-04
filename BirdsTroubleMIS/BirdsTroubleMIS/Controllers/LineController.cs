using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Models;
using BirdsTroubleMIS.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

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
        public async Task<ActionResult<ListViewModel<Line>>> Get([FromQuery] ListRequest request)
        {
            Expression<Func<Line, bool>> filter = (x) => true;

            if (request.FilterString != null)
            {
                filter = (x) => x.Name.Contains(request.FilterString);
            }

            var response = await _service.GetAsync(request.PageIndex, request.PageSize, filter);
            return response;
        }


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
