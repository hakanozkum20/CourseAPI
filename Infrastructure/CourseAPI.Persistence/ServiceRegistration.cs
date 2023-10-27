using CourseAPI.Application.Abstractions;
using CourseAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace CourseAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<IMemberService, MemberService>();
    }
}