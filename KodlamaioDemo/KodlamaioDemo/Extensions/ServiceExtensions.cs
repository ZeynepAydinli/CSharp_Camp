using Business.Abstract;
using Business.Concrete;
using DataAccess2.Abstract;
using DataAccess2.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace KodlamaioDemo.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCourseManager(this IServiceCollection services) =>
            services.AddScoped<ICourseManager, CourseManager>();

    public static void ConfigureEfCourseDal(this IServiceCollection services) =>
            services.AddScoped<ICourseDal, EfCourseDal>();

    
}
