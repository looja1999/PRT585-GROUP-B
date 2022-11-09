

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class RoleService :  IRoleService
    {
        private readonly IRoleDal _RoleDal;
        //private readonly IRoleBalService _RoleBalService;
        public RoleService(IRoleDal RoleDal
        //ILoggingService loggingService,
        //IRoleDal RoleDal,
        //IAuditDal auditDal
       // IRoleBalanceService balsvc
        ) 
        {
            _RoleDal = RoleDal;
            // _RoleBalService = balsvc;
        }

        public async Task<RoleModel?> GetById(int RoleId)
        {           
            return _RoleDal.GetById(RoleId);
        }

        public async Task<List<RoleModel>> GetAll()
        {            
            return _RoleDal.GetAll();
        }

        public async Task<int> CreateRole(RoleModel Role)
        {
            //write validations here
            var newRoleId = _RoleDal.CreateRole(Role);
            return newRoleId;
        }

        public async Task UpdateRole(RoleModel Role)
        {
            //write validations here 
            _RoleDal.UpdateRole(Role);
        }

        public async Task DeleteRole(int RoleId)
        {            
            try
            {
                //if(balservice.getBal(RoleId) = 0)
                _RoleDal.DeleteRole(RoleId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Role Id:{RoleId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
