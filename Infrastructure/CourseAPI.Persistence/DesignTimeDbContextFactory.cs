using CourseAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CourseAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CourseAPIDbContext>
{
     
     
    
    public CourseAPIDbContext CreateDbContext(string[] args)
    {
        
        DbContextOptionsBuilder<CourseAPIDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseMySql(Configuration.ConnectionString,ServerVersion.AutoDetect(Configuration.ConnectionString));
        return new(dbContextOptionsBuilder.Options);
    }
}