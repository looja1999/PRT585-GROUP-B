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
    public class RoleController : ControllerBase
    {

        private readonly IRoleService _RoleService;
        private readonly ILogger<RoleController> _logger;

        public RoleController(IRoleService RoleService, ILogger<RoleController> logger)
        {
            _RoleService = RoleService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllRoles")]
        public async Task<List<RoleDto>> GetAll()
        {
            var result = await _RoleService.GetAll();
            return result.Select(x => x.ToRoleDto()).ToList();
        }

        [HttpGet("{RoleId}", Name = "GetRole")]
        public async Task<RoleDto?> Get(int RoleId)
        {
            var result = await _RoleService.GetById(RoleId);
            return result?.ToRoleDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] RoleDto requestDto)
        {
            var RoleModel = requestDto.ToRoleModel();
            return await _RoleService.CreateRole(RoleModel);
        }

        [HttpPut, Route("{id}")]

        public async Task<IActionResult> Update([FromBody] RoleDto requestDto)
        {
            await _RoleService.UpdateRole(requestDto.ToRoleModel());
            return Ok();
        }

        [HttpDelete, Route("{RoleId}")]
        public async Task<IActionResult> Delete(int RoleId)
        {
            await _RoleService.DeleteRole(RoleId);
            return Ok();
        }
    }
}
