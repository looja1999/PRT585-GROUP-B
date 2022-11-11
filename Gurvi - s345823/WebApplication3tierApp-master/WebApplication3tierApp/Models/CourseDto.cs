using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

    }

    public static class CourseDtoMapExtensions
    {
        public static CourseDto ToCourseDto(this CourseModel src)
        {
            var dst = new CourseDto();
            dst.CourseId = src.CourseId;
            dst.CourseCode = src.CourseCode;
            dst.CourseName = src.CourseName;
            return dst;
        }

        public static CourseModel ToCourseModel(this CourseDto src)
        {
            var dst = new CourseModel();
            dst.CourseId = src.CourseId;
            dst.CourseCode = src.CourseCode;
            dst.CourseName = src.CourseName;
            return dst;
        }
    }
}
