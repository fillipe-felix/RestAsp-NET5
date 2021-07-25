using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestAspNET5.Model;
using RestAspNET5.Services;

namespace RestAspNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBooksService _booksService;

        public BooksController(ILogger<BooksController> logger, IBooksService booksService)
        {
            _logger = logger;
            _booksService = booksService;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_booksService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _booksService.FindById(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Books books)
        {
            if (books == null)
            {
                return BadRequest();
            }

            return Ok(_booksService.Create(books));
        }

        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Books books)
        {
            if (books == null)
            {
                return BadRequest();
            }

            return Ok(_booksService.Update(id, books));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var book = _booksService.FindById(id);

            if (book == null)
            {
                return NotFound();
            }

            _booksService.Delete(id);
            return NoContent();
        }
    }
}