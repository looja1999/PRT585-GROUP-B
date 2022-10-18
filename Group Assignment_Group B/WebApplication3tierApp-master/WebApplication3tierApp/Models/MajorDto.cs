using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class MajorDto
    {
        public int MajorId { get; set; }
        public string MajorCode { get; set; }
        public string MajorName { get; set; }

    }

    public static class MajorDtoMapExtensions
    {
        public static MajorDto ToMajorDto(this MajorModel src)
        {
            var dst = new MajorDto();
            dst.MajorId = src.MajorId;
            dst.MajorCode = src.MajorCode;
            dst.MajorName = src.MajorName;
            return dst;
        }

        public static MajorModel ToMajorModel(this MajorDto src)
        {
            var dst = new MajorModel();
            dst.MajorId = src.MajorId;
            dst.MajorCode = src.MajorCode;
            dst.MajorName = src.MajorName;
            return dst;
        }
    }
}
