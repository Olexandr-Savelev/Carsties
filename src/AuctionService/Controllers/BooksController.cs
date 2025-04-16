using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet(Name = "books")]
        public IActionResult GetAllBooks()
        {
            return Ok(new[] { "Book1", "Book2" });
        }
    }
}
