using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class ReportDto
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }

    }

    public static class ReportDtoMapExtensions
    {
        public static ReportDto ToReportDto(this ReportModel src)
        {
            var dst = new ReportDto();
            dst.ReportId = src.ReportId;
            dst.ReportName = src.ReportName;
            return dst;
        }

        public static ReportModel ToReportModel(this ReportDto src)
        {
            var dst = new ReportModel();
            dst.ReportId = src.ReportId;
            dst.ReportName = src.ReportName;
            return dst;
        }
    }
}
