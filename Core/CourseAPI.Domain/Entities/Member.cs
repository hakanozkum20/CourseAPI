using CourseAPI.Domain.Entities.Common;

namespace CourseAPI.Domain.Entities;

public class Member : BaseEntity
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public long TC { get; set; }
    public long PhoneNumber { get; set; }
    
}