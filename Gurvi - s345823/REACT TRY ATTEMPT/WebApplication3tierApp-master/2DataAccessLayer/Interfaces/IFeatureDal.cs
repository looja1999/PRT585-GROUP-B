using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IFeatureDal
    {
        // Getters
        FeatureModel? GetById(int FeatureId);
        List<FeatureModel> GetAll();

        // Actions
        int CreateFeature(FeatureModel Feature);
        void UpdateFeature(FeatureModel Feature);
        void DeleteFeature(int FeatureId);
    }
}
