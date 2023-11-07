using AspNetExampleDomain.Entities;
using AspNetExampleDomain.Models.Course;
using AspNetExampleDomain.Repositories;
using AspNetExampleDomain.Services;

namespace AspNetExampleBusinesLayer.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task CreateCourseAsync(CreateCourseModel createCourseModel)
        {
            var course = new Course
            {
                Id = Guid.NewGuid(),
                Name = createCourseModel.Name,
                Capacity = createCourseModel.Capacity,
            };

            await _courseRepository.CreateCourseAsync(course);
        }
    }
}
