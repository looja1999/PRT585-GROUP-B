

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseDal _CourseDal;
        //private readonly ICourseBalService _CourseBalService;
        public CourseService(ICourseDal CourseDal
        //ILoggingService loggingService,
        //ICourseDal CourseDal,
        //IAuditDal auditDal
        // ICourseBalanceService balsvc
        )
        {
            _CourseDal = CourseDal;
            // _CourseBalService = balsvc;
        }

        public async Task<CourseModel?> GetById(int CourseId)
        {
            return _CourseDal.GetById(CourseId);
        }

        public async Task<List<CourseModel>> GetAll()
        {
            return _CourseDal.GetAll();
        }

        public async Task<int> CreateCourse(CourseModel Course)
        {
            //write validations here
            var newCourseId = _CourseDal.CreateCourse(Course);
            return newCourseId;
        }

        public async Task UpdateCourse(CourseModel Course)
        {
            //write validations here 
            _CourseDal.UpdateCourse(Course);
        }

        public async Task DeleteCourse(int CourseId)
        {
            try
            {
                //if(balservice.getBal(CourseId) = 0)
                _CourseDal.DeleteCourse(CourseId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Course Id:{CourseId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
