using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class FeatureDto
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        
 
    }

    public static class FeatureDtoMapExtensions
    {
        public static FeatureDto ToFeatureDto(this FeatureModel src)
        {
            var dst = new FeatureDto();
            dst.FeatureId = src.FeatureId;
            dst.FeatureName = src.FeatureName;
           
            return dst;
        }

        public static FeatureModel ToFeatureModel(this FeatureDto src)
        {
            var dst = new FeatureModel();
            dst.FeatureId = src.FeatureId;
            dst.FeatureName = src.FeatureName;            
            return dst;
        }
    }
}
