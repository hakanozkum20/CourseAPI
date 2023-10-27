using CourseAPI.Application.Abstractions;
using CourseAPI.Persistence.Concretes;
using CourseAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CourseAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<IMemberService, MemberService>();

        services.AddDbContext<CourseAPIDbContext>(options => options.UseMySql(Configuration.ConnectionString,ServerVersion.AutoDetect(Configuration.ConnectionString)));
    }
}