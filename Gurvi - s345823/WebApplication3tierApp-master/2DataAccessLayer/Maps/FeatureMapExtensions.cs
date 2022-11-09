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
    public static class FeatureMapExtensions
    {
        public static FeatureModel ToFeatureModel(this Feature src)
        {
            var dst = new FeatureModel();

            dst.FeatureId = src.FeatureId;
            dst.FeatureName = src.FeatureName;

            return dst;
        }

        public static Feature ToFeature(this FeatureModel src, Feature dst = null)
        {
            if (dst == null)
            {
                dst = new Feature();
            }

            dst.FeatureId = src.FeatureId;
            dst.FeatureName = src.FeatureName;

            return dst;
        }
    }
}
