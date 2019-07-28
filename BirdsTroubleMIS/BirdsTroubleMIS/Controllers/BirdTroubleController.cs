using BirdsTroubleMIS.Entities;
using BirdsTroubleMIS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BirdsTroubleMIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdTroubleController : ControllerBase
    {
        private readonly BookService _bookService;

        public BirdTroubleController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<BirdTrouble>> Get() => _bookService.Get();

        [HttpGet("{id:length(24)}", Name = "GetTrouble")]
        public ActionResult<BirdTrouble> Get(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public ActionResult<BirdTrouble> Create(BirdTrouble book)
        {
            _bookService.Create(book);

            return CreatedAtRoute("GetTrouble", new { id = book.Id.ToString() }, book);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, BirdTrouble bookIn)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Update(id, bookIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Remove(book.Id);

            return NoContent();
        }
    }
}
