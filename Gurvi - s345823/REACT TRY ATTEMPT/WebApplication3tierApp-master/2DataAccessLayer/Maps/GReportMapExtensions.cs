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
    public static class GReportMapExtensions
    {
        public static GReportModel ToGReportModel(this GReport src)
        {
            var dst = new GReportModel();

            dst.GReportId = src.GReportId;
            dst.GReportName = src.GReportName;

            return dst;
        }

        public static GReport ToGReport(this GReportModel src, GReport dst = null)
        {
            if (dst == null)
            {
                dst = new GReport();
            }

            dst.GReportId = src.GReportId;
            dst.GReportName = src.GReportName;

            return dst;
        }
    }
}
