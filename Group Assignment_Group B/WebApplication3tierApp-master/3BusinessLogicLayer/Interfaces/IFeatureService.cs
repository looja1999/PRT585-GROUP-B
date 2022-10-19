using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IFeatureService
    {
        Task<FeatureModel?> GetById(int FeatureId);
        Task<List<FeatureModel>> GetAll();

        Task<int> CreateFeature(FeatureModel Feature);
        Task UpdateFeature(FeatureModel Feature);
        Task DeleteFeature(int FeatureId);
    }
}
