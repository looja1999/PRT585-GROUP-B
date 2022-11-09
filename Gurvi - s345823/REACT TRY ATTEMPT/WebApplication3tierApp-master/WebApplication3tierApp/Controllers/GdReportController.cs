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
    public class GdReportController : ControllerBase
    {

        private readonly IGdReportService _GdReportService;
        private readonly ILogger<GdReportController> _logger;

        public GdReportController(IGdReportService GdReportService, ILogger<GdReportController> logger)
        {
            _GdReportService = GdReportService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllGdReports")]
        public async Task<List<GdReportDto>> GetAll()
        {
            var result = await _GdReportService.GetAll();
            return result.Select(x => x.ToGdReportDto()).ToList();
        }

        [HttpGet("{GdReportId}", Name = "GetGdReport")]
        public async Task<GdReportDto?> Get(int GdReportId)
        {
            var result = await _GdReportService.GetById(GdReportId);
            return result?.ToGdReportDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] GdReportDto requestDto)
        {
            var GdReportModel = requestDto.ToGdReportModel();
            return await _GdReportService.CreateGdReport(GdReportModel);
        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromBody] GdReportDto requestDto)
        {
            await _GdReportService.UpdateGdReport(requestDto.ToGdReportModel());
            return Ok();
        }

        [HttpDelete, Route("{GdReportId}")]
        public async Task<IActionResult> Delete(int GdReportId)
        {
            await _GdReportService.DeleteGdReport(GdReportId);
            return Ok();
        }
    }
}
