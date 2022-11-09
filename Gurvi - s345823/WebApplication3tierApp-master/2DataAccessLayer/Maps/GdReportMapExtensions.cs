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
    public static class GdReportMapExtensions
    {
        public static GdReportModel ToGdReportModel(this GdReport src)
        {
            var dst = new GdReportModel();

            dst.GdReportId = src.GdReportId;
            dst.GdReportName = src.GdReportName;

            return dst;
        }

        public static GdReport ToGdReport(this GdReportModel src, GdReport dst = null)
        {
            if (dst == null)
            {
                dst = new GdReport();
            }

            dst.GdReportId = src.GdReportId;
            dst.GdReportName = src.GdReportName;

            return dst;
        }
    }
}
