using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class RoleDal : IRoleDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public RoleDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<RoleModel> GetAll()
        {
            var result = _db.Roles.ToList();

            var returnObject = new List<RoleModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToRoleModel());
            }

            return returnObject;
        }

        public RoleModel? GetById(int RoleId)
        {
            var result = _db.Roles.SingleOrDefault(x => x.RoleId == RoleId);
            return result?.ToRoleModel();
        }


        public int CreateRole(RoleModel Role)
        {
            var newRole = Role.ToRole();
            _db.Roles.Add(newRole);
            _db.SaveChanges();
            return newRole.RoleId;
        }


        public void UpdateRole(RoleModel Role)
        {
            var existingRole = _db.Roles
                .SingleOrDefault(x => x.RoleId == Role.RoleId);

            if (existingRole == null)
            {
                throw new ApplicationException($"Role {Role.RoleId} does not exist.");
            }
            Role.ToRole(existingRole);

            _db.Update(existingRole);
            _db.SaveChanges();
        }

        public void DeleteRole(int RoleId)
        {
            var efModel = _db.Roles.Find(RoleId);
            _db.Roles.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
