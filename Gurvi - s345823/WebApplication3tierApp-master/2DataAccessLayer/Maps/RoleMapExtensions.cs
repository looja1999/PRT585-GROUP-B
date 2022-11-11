using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class RoleMapExtensions
    {
        public static RoleModel ToRoleModel(this Role src)
        {
            var dst = new RoleModel();

            dst.RoleId = src.RoleId;
            dst.RoleName = src.RoleName;
            dst.RoleStatus = src.RoleStatus;

            return dst;
        }

        public static Role ToRole(this RoleModel src, Role dst = null)
        {
            if (dst == null)
            {
                dst = new Role();
            }

            dst.RoleId = src.RoleId;
            dst.RoleName = src.RoleName;
            dst.RoleStatus = src.RoleStatus;

            return dst;
        }
    }
}
