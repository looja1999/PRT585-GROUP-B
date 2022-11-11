using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IRoleService
    {
        Task<RoleModel?> GetById(int RoleId);
        Task<List<RoleModel>> GetAll();

        Task<int> CreateRole(RoleModel Role);
        Task UpdateRole(RoleModel Role);
        Task DeleteRole(int RoleId);
    }
}
