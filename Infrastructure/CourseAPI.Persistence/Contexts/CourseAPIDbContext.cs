using CourseAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseAPI.Persistence.Contexts;

public class CourseAPIDbContext : DbContext
{
    public CourseAPIDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Member> Members { get; set; }
    
}