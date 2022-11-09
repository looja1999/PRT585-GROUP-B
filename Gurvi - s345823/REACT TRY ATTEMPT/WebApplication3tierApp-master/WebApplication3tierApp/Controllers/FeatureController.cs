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
    public class FeatureController : ControllerBase
    {

        private readonly IFeatureService _FeatureService;
        private readonly ILogger<FeatureController> _logger;

        public FeatureController(IFeatureService FeatureService, ILogger<FeatureController> logger)
        {
            _FeatureService = FeatureService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllFeatures")]
        public async Task<List<FeatureDto>> GetAll()
        {
            var result = await _FeatureService.GetAll();
            return result.Select(x => x.ToFeatureDto()).ToList();
        }

        [HttpGet("{FeatureId}", Name = "GetFeature")]
        public async Task<FeatureDto?> Get(int FeatureId)
        {
            var result = await _FeatureService.GetById(FeatureId);
            return result?.ToFeatureDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] FeatureDto requestDto)
        {
            var FeatureModel = requestDto.ToFeatureModel();
            return await _FeatureService.CreateFeature(FeatureModel);
        }

        [HttpPut, Route("{id}")]

        public async Task<IActionResult> Update([FromBody] FeatureDto requestDto)
        {
            await _FeatureService.UpdateFeature(requestDto.ToFeatureModel());
            return Ok();
        }

        [HttpDelete, Route("{FeatureId}")]
        public async Task<IActionResult> Delete(int FeatureId)
        {
            await _FeatureService.DeleteFeature(FeatureId);
            return Ok();
        }
    }
}
