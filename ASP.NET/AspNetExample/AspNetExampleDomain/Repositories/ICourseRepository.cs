using AspNetExampleDomain.Entities;

namespace AspNetExampleDomain.Repositories
{
    public interface ICourseRepository
    {
        Task CreateCourseAsync(Course course);
    }
}
