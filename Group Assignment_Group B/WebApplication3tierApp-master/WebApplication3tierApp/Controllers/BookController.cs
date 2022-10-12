using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BookController : ControllerBase
    {

        private readonly IBookService _BookService;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService BookService, ILogger<BookController> logger)
        {
            _BookService = BookService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAlls")]
        public async Task<List<BookDto>> GetAll()
        {
            var result = await _BookService.GetAll();
            return result.Select(x => x.ToBookDto()).ToList();
        }

        [HttpGet("{BookId}", Name = "GetBook")]
        public async Task<BookDto?> Get(int BookId)
        {
            var result = await _BookService.GetById(BookId);
            return result?.ToBookDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] BookDto requestDto)
        {
            var BookModel = requestDto.ToBookModel();
            return await _BookService.CreateBook(BookModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] BookDto requestDto)
        {
            await _BookService.UpdateBook(requestDto.ToBookModel());
            return Ok();
        }

        [HttpDelete, Route("{BookId}")]
        public async Task<IActionResult> Delete(int BookId)
        {
            await _BookService.DeleteBook(BookId);
            return Ok();
        }
    }
}
