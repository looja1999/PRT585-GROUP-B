﻿using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ReportController : ControllerBase
    {

        private readonly IReportService _ReportService;
        private readonly ILogger<ReportController> _logger;

        public ReportController(IReportService ReportService, ILogger<ReportController> logger)
        {
            _ReportService = ReportService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllReports")]
        public async Task<List<ReportDto>> GetAll()
        {
            var result = await _ReportService.GetAll();
            return result.Select(x => x.ToReportDto()).ToList();
        }

        [HttpGet("{ReportId}", Name = "GetReport")]
        public async Task<ReportDto?> Get(int ReportId)
        {
            var result = await _ReportService.GetById(ReportId);
            return result?.ToReportDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] ReportDto requestDto)
        {
            var ReportModel = requestDto.ToReportModel();
            return await _ReportService.CreateReport(ReportModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] ReportDto requestDto)
        {
            await _ReportService.UpdateReport(requestDto.ToReportModel());
            return Ok();
        }

        [HttpDelete, Route("{ReportId}")]
        public async Task<IActionResult> Delete(int ReportId)
        {
            await _ReportService.DeleteReport(ReportId);
            return Ok();
        }
    }
}
