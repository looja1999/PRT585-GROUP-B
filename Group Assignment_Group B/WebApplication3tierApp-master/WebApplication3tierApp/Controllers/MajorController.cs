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
    public class MajorController : ControllerBase
    {

        private readonly IMajorService _MajorService;
        private readonly ILogger<MajorController> _logger;

        public MajorController(IMajorService MajorService, ILogger<MajorController> logger)
        {
            _MajorService = MajorService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllMajors")]
        public async Task<List<MajorDto>> GetAll()
        {
            var result = await _MajorService.GetAll();
            return result.Select(x => x.ToMajorDto()).ToList();
        }

        [HttpGet("{MajorId}", Name = "GetMajor")]
        public async Task<MajorDto?> Get(int MajorId)
        {
            var result = await _MajorService.GetById(MajorId);
            return result?.ToMajorDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] MajorDto requestDto)
        {
            var MajorModel = requestDto.ToMajorModel();
            return await _MajorService.CreateMajor(MajorModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] MajorDto requestDto)
        {
            await _MajorService.UpdateMajor(requestDto.ToMajorModel());
            return Ok();
        }

        [HttpDelete, Route("{MajorId}")]
        public async Task<IActionResult> Delete(int MajorId)
        {
            await _MajorService.DeleteMajor(MajorId);
            return Ok();
        }
    }
}
