using BookManagementAPI.Models;
using BookManagementAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookService _BookService;

        public BookController(BookService bookService)
        {
            _BookService = bookService;
        }

        [HttpGet("GetBook")]
        public IActionResult GetBook(int Id)
        {
            return Ok(_BookService.GetBook(Id));
        }

        [HttpGet("GetAllBook")]

        public IActionResult GetAllBook()
        {
            return Ok(_BookService.GetAllBook());
        }

        [HttpPost("SaveBook")]

        public IActionResult SaveBook(Book book)
        {
            return Ok(_BookService.SaveBook(book));
        }

        [HttpPut("UpdateBook")]

        public IActionResult UpdateBook(Book book)
        {
            return Ok(_BookService.UpdateBook(book));
        }

        [HttpDelete("DeleteBook")]

        public IActionResult Deletebook(int id)
        {
            return Ok(_BookService.DeleteBook(id));
        }
    }
}
