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
    public class FeatureDal : IFeatureDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public FeatureDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<FeatureModel> GetAll()
        {
            var result = _db.Features.ToList();

            var returnObject = new List<FeatureModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToFeatureModel());
            }

            return returnObject;
        }

        public FeatureModel? GetById(int FeatureId)
        {
            var result = _db.Features.SingleOrDefault(x => x.FeatureId == FeatureId);
            return result?.ToFeatureModel();
        }


        public int CreateFeature(FeatureModel Feature)
        {
            var newFeature = Feature.ToFeature();
            _db.Features.Add(newFeature);
            _db.SaveChanges();
            return newFeature.FeatureId;
        }


        public void UpdateFeature(FeatureModel Feature)
        {
            var existingFeature = _db.Features
                .SingleOrDefault(x => x.FeatureId == Feature.FeatureId);

            if (existingFeature == null)
            {
                throw new ApplicationException($"Feature {Feature.FeatureId} does not exist.");
            }
            Feature.ToFeature(existingFeature);

            _db.Update(existingFeature);
            _db.SaveChanges();
        }

        public void DeleteFeature(int FeatureId)
        {
            var efModel = _db.Features.Find(FeatureId);
            _db.Features.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
