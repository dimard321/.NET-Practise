using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Student;

namespace AspNetExampleBusinesLayer.Services.Repositories
{
    public interface IStudentRepository
    {
        Task CreateStudentAsync(Student student);

        Task UpdateStudentAsync(Student student);

        Task<Student> GetStudentAsync(Guid id);

        Task<Student[]> GetStudentsSAsync();
    }
}
