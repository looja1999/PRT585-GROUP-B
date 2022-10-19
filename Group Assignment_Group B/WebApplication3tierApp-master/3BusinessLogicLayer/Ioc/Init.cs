using _3BusinessLogicLayer.Interfaces;
using _3BusinessLogicLayer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3BusinessLogicLayer.Ioc
{
    public static class Init
    {
        public static void InitializeDependencies(IServiceCollection services, IConfiguration configuration)
        {
                      
            // Services
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUnitService, UnitService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IFeatureService, FeatureService>();




            //services.AddScoped<ICategoryService, CategoryService>();

        }
    }
}
