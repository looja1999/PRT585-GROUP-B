using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IRoleDal
    {
        // Getters
        RoleModel? GetById(int RoleId);
        List<RoleModel> GetAll();

        // Actions
        int CreateRole(RoleModel Role);
        void UpdateRole(RoleModel Role);
        void DeleteRole(int RoleId);
    }
}
