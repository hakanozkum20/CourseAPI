using CourseAPI.Domain.Entities;

namespace CourseAPI.Application.Abstractions;

public interface IMemberService
{
    List<Member> GetMembers();
}