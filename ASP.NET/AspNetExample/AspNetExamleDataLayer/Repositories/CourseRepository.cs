using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Repositories;

namespace AspNetExamleDataLayer.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly EFContext _context;

        public CourseRepository(EFContext context)
        {
            _context = context;
        }

        public async Task CreateCourseAsync(Course course)
        {
            await _context.AddAsync(course);

            await _context.SaveChangesAsync();
        }
    }
}
