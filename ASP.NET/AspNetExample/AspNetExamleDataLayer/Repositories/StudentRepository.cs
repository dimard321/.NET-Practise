using AspNetExampleBusinesLayer.Services.Repositories;
using AspNetExampleDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetExamleDataLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly EFContext _context;

        public StudentRepository(EFContext context)
        {
            _context = context;
        }

        public async Task CreateStudentAsync(Student student)
        {
            await _context.AddAsync(student);

            await _context.SaveChangesAsync();
        }

        public async Task<Student> GetStudentAsync(Guid id)
        {
           return await _context.Students.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Student[]> GetStudentsSAsync()
        {
            return await _context.Students.ToArrayAsync();
        }

        public async Task UpdateStudentAsync(Student student)
        {
            _context.Update(student);

            await _context.SaveChangesAsync();
        }
    }
}
