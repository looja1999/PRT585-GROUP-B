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
    public static class ReportMapExtensions
    {
        public static ReportModel ToReportModel(this Report src)
        {
            var dst = new ReportModel();

            dst.ReportId = src.ReportId;
            dst.ReportName = src.ReportName;

            return dst;
        }

        public static Report ToReport(this ReportModel src, Report dst = null)
        {
            if (dst == null)
            {
                dst = new Report();
            }

            dst.ReportId = src.ReportId;
            dst.ReportName = src.ReportName;

            return dst;
        }
    }
}
