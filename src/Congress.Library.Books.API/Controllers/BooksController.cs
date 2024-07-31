using Congress.Library.Books.Core.Interfaces;
using Congress.Library.Books.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Congress.Library.Books.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _bookService;
        private readonly ILogger<BooksController> _logger;
        private IConfiguration _configuration;
        public BooksController(IBookService bookService, ILogger<BooksController> logger, IConfiguration configuration)
        {
            _bookService = bookService;
            _logger = logger;
            _configuration = configuration;
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] NewBook request)
        {
            try
            {
                var result = await _bookService.AddBook(request);
                _logger.LogInformation("book added successfully");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBook request)
        {
            try
            {
                var result = await _bookService.UpdateBook(request);
                _logger.LogInformation("book updated successfully");
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> RetrieveBook([FromBody] string id)
        {
            try
            {
                var result = await _bookService.RetrieveBook(id);                
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
