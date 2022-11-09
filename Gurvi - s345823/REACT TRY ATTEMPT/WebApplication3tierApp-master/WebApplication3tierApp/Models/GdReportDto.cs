using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class GdReportDto
    {
        public int GdReportId { get; set; }
        public string GdReportName { get; set; }

    }

    public static class GdReportDtoMapExtensions
    {
        public static GdReportDto ToGdReportDto(this GdReportModel src)
        {
            var dst = new GdReportDto();
            dst.GdReportId = src.GdReportId;
            dst.GdReportName = src.GdReportName;
            return dst;
        }

        public static GdReportModel ToGdReportModel(this GdReportDto src)
        {
            var dst = new GdReportModel();
            dst.GdReportId = src.GdReportId;
            dst.GdReportName = src.GdReportName;
            return dst;
        }
    }
}
