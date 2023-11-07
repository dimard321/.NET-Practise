using AspNetExample.Domain.Models.Student;
using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Student;

namespace AspNetExampleDomain.Services
{
    public interface IStudentService
    {
        Task CreateStudentAsync(CreateStudentRequest createStudentRequest);

        Task UpdateStudentAsync(UpdateStudentRequest updateStudentRequest);

        Task<Student> GetSudentAsync(Guid id);

        Task<Student[]> GetStudentsAsync();
    }
}
