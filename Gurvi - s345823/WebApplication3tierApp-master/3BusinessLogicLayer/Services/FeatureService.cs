

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class FeatureService :  IFeatureService
    {
        private readonly IFeatureDal _FeatureDal;
        //private readonly IFeatureBalService _FeatureBalService;
        public FeatureService(IFeatureDal FeatureDal
        //ILoggingService loggingService,
        //IFeatureDal FeatureDal,
        //IAuditDal auditDal
       // IFeatureBalanceService balsvc
        ) 
        {
            _FeatureDal = FeatureDal;
            // _FeatureBalService = balsvc;
        }

        public async Task<FeatureModel?> GetById(int FeatureId)
        {           
            return _FeatureDal.GetById(FeatureId);
        }

        public async Task<List<FeatureModel>> GetAll()
        {            
            return _FeatureDal.GetAll();
        }

        public async Task<int> CreateFeature(FeatureModel Feature)
        {
            //write validations here
            var newFeatureId = _FeatureDal.CreateFeature(Feature);
            return newFeatureId;
        }

        public async Task UpdateFeature(FeatureModel Feature)
        {
            //write validations here 
            _FeatureDal.UpdateFeature(Feature);
        }

        public async Task DeleteFeature(int FeatureId)
        {            
            try
            {
                //if(balservice.getBal(FeatureId) = 0)
                _FeatureDal.DeleteFeature(FeatureId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Feature Id:{FeatureId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
