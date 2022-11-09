using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class RoleDto
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string? RoleStatus { get; set; }
 
    }

    public static class RoleDtoMapExtensions
    {
        public static RoleDto ToRoleDto(this RoleModel src)
        {
            var dst = new RoleDto();
            dst.RoleId = src.RoleId;
            dst.RoleName = src.RoleName;
            dst.RoleStatus = src.RoleStatus; 
            return dst;
        }

        public static RoleModel ToRoleModel(this RoleDto src)
        {
            var dst = new RoleModel();
            dst.RoleId = src.RoleId;
            dst.RoleName = src.RoleName;            
            return dst;
        }
    }
}
