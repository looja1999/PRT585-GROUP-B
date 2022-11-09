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
    public class MovieController : ControllerBase
    {

        private readonly IMovieService _MovieService;
        private readonly ILogger<MovieController> _logger;

        public MovieController(IMovieService MovieService, ILogger<MovieController> logger)
        {
            _MovieService = MovieService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllMovies")]
        public async Task<List<MovieDto>> GetAll()
        {
            var result = await _MovieService.GetAll();
            return result.Select(x => x.ToMovieDto()).ToList();
        }

        [HttpGet("{MovieId}", Name = "GetMovie")]
        public async Task<MovieDto?> Get(int MovieId)
        {
            var result = await _MovieService.GetById(MovieId);
            return result?.ToMovieDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] MovieDto requestDto)
        {
            var MovieModel = requestDto.ToMovieModel();
            return await _MovieService.CreateMovie(MovieModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] MovieDto requestDto)
        {
            await _MovieService.UpdateMovie(requestDto.ToMovieModel());
            return Ok();
        }

        [HttpDelete, Route("{MovieId}")]
        public async Task<IActionResult> Delete(int MovieId)
        {
            await _MovieService.DeleteMovie(MovieId);
            return Ok();
        }
    }
}
