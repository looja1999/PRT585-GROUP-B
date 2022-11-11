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
    public class GReportController : ControllerBase
    {

        private readonly IGReportService _GReportService;
        private readonly ILogger<GReportController> _logger;

        public GReportController(IGReportService GReportService, ILogger<GReportController> logger)
        {
            _GReportService = GReportService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllGReports")]
        public async Task<List<GReportDto>> GetAll()
        {
            var result = await _GReportService.GetAll();
            return result.Select(x => x.ToGReportDto()).ToList();
        }

        [HttpGet("{GReportId}", Name = "GetGReport")]
        public async Task<GReportDto?> Get(int GReportId)
        {
            var result = await _GReportService.GetById(GReportId);
            return result?.ToGReportDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] GReportDto requestDto)
        {
            var GReportModel = requestDto.ToGReportModel();
            return await _GReportService.CreateGReport(GReportModel);
        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromBody] GReportDto requestDto)
        {
            await _GReportService.UpdateGReport(requestDto.ToGReportModel());
            return Ok();
        }

        [HttpDelete, Route("{GReportId}")]
        public async Task<IActionResult> Delete(int GReportId)
        {
            await _GReportService.DeleteGReport(GReportId);
            return Ok();
        }
    }
}
