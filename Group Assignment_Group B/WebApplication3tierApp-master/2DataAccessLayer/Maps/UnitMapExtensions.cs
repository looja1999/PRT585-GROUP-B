using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class UnitMapExtensions
    {
        public static UnitModel ToUnitModel(this Unit src)
        {
            var dst = new UnitModel();

            dst.UnitId = src.UnitId;
            dst.UnitName = src.UnitName;

            return dst;
        }

        public static Unit ToUnit(this UnitModel src, Unit dst = null)
        {
            if (dst == null)
            {
                dst = new Unit();
            }

            dst.UnitId = src.UnitId;
            dst.UnitName = src.UnitName;

            return dst;
        }
    }
}
