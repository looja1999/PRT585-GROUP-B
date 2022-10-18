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
    public class CourseController : ControllerBase
    {

        private readonly ICourseService _CourseService;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ICourseService CourseService, ILogger<CourseController> logger)
        {
            _CourseService = CourseService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllCourses")]
        public async Task<List<CourseDto>> GetAll()
        {
            var result = await _CourseService.GetAll();
            return result.Select(x => x.ToCourseDto()).ToList();
        }

        [HttpGet("{CourseId}", Name = "GetCourse")]
        public async Task<CourseDto?> Get(int CourseId)
        {
            var result = await _CourseService.GetById(CourseId);
            return result?.ToCourseDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] CourseDto requestDto)
        {
            var CourseModel = requestDto.ToCourseModel();
            return await _CourseService.CreateCourse(CourseModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] CourseDto requestDto)
        {
            await _CourseService.UpdateCourse(requestDto.ToCourseModel());
            return Ok();
        }

        [HttpDelete, Route("{CourseId}")]
        public async Task<IActionResult> Delete(int CourseId)
        {
            await _CourseService.DeleteCourse(CourseId);
            return Ok();
        }
    }
}
