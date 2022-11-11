using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class GReportDto
    {
        public int GReportId { get; set; }
        public string GReportName { get; set; }

    }

    public static class GReportDtoMapExtensions
    {
        public static GReportDto ToGReportDto(this GReportModel src)
        {
            var dst = new GReportDto();
            dst.GReportId = src.GReportId;
            dst.GReportName = src.GReportName;
            return dst;
        }

        public static GReportModel ToGReportModel(this GReportDto src)
        {
            var dst = new GReportModel();
            dst.GReportId = src.GReportId;
            dst.GReportName = src.GReportName;
            return dst;
        }
    }
}
