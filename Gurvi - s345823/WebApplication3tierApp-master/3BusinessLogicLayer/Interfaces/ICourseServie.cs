using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ICourseService
    {
        Task<CourseModel?> GetById(int CourseId);
        Task<List<CourseModel>> GetAll();

        Task<int> CreateCourse(CourseModel Course);
        Task UpdateCourse(CourseModel Course);
        Task DeleteCourse(int CourseId);
    }
}
