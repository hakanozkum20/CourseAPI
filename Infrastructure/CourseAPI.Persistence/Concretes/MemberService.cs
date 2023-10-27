using CourseAPI.Application.Abstractions;
using CourseAPI.Domain.Entities;

namespace CourseAPI.Persistence.Concretes;

public class MemberService : IMemberService
{
    public List<Member> GetMembers()
        => new ()
        {
            new()
            {
                Id = Guid.NewGuid(), Name = "Hakan", SurName = "Özkum", TC = 12312312312, PhoneNumber = 05388188672
            },new()
            {
                Id = Guid.NewGuid(), Name = "Ahmet", SurName = "Çiçek", TC = 12312312312, PhoneNumber = 05388188672
            },new()
            {
                Id = Guid.NewGuid(), Name = "Fatma", SurName = "Kızıl", TC = 12312312312, PhoneNumber = 05388188672
            },new()
            {
                Id = Guid.NewGuid(), Name = "Gaye", SurName = "Anıl", TC = 12312312312, PhoneNumber = 05388188672
            },new()
            {
                Id = Guid.NewGuid(), Name = "Kaan", SurName = "Korkmaz", TC = 12312312312, PhoneNumber = 05388188672
            },
        };
}