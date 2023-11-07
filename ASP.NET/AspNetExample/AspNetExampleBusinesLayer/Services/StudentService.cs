using AspNetExample.Domain.Models.Student;
using AspNetExampleBusinesLayer.Services.Repositories;
using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Student;
using AspNetExampleDomain.Services;

namespace AspNetExampleBusinesLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task CreateStudentAsync(CreateStudentRequest createStudentRequest)
        {
            var studentEntity = new Student
            {
                Id = Guid.NewGuid(),
                Name = createStudentRequest.Name,
                Surname = createStudentRequest.Surname,
                Age = createStudentRequest.Age,
                Gender = createStudentRequest.Gender
            };

            await _studentRepository.CreateStudentAsync(studentEntity);
        }

        public async Task<Student[]> GetStudentsAsync()
        {
            return await _studentRepository.GetStudentsSAsync();
        }

        public async Task<Student> GetSudentAsync(Guid id)
        {
            return await _studentRepository.GetStudentAsync(id);
        }

        public async Task UpdateStudentAsync(UpdateStudentRequest updateStudentRequest)
        {
            var student = await _studentRepository.GetStudentAsync(updateStudentRequest.Id);

            student.Name = updateStudentRequest.Name;

            student.Surname = updateStudentRequest.Surname;

            student.Age = updateStudentRequest.Age;

            student.Gender = updateStudentRequest.Gender;

            await _studentRepository.UpdateStudentAsync(student);
        }

    }
}
