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
    public static class MajorMapExtensions
    {
        public static MajorModel ToMajorModel(this Major src)
        {
            var dst = new MajorModel();

            dst.MajorId = src.MajorId;
            dst.MajorCode = src.MajorCode;
            dst.MajorName = src.MajorName;

            return dst;
        }

        public static Major ToMajor(this MajorModel src, Major dst = null)
        {
            if (dst == null)
            {
                dst = new Major();
            }

            dst.MajorId = src.MajorId;
            dst.MajorCode = src.MajorCode;
            dst.MajorName = src.MajorName;

            return dst;
        }
    }
}
