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
    public class MajorDal : IMajorDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public MajorDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<MajorModel> GetAll()
        {
            var result = _db.Majors.ToList();

            var returnObject = new List<MajorModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToMajorModel());
            }

            return returnObject;
        }

        public MajorModel? GetById(int MajorId)
        {
            var result = _db.Majors.SingleOrDefault(x => x.MajorId == MajorId);
            return result?.ToMajorModel();
        }


        public int CreateMajor(MajorModel Major)
        {
            var newMajor = Major.ToMajor();
            _db.Majors.Add(newMajor);
            _db.SaveChanges();
            return newMajor.MajorId;
        }


        public void UpdateMajor(MajorModel Major)
        {
            var existingMajor = _db.Majors
                .SingleOrDefault(x => x.MajorId == Major.MajorId);

            if (existingMajor == null)
            {
                throw new ApplicationException($"Major {Major.MajorId} does not exist.");
            }
            Major.ToMajor(existingMajor);

            _db.Update(existingMajor);
            _db.SaveChanges();
        }

        public void DeleteMajor(int MajorId)
        {
            var efModel = _db.Majors.Find(MajorId);
            _db.Majors.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
