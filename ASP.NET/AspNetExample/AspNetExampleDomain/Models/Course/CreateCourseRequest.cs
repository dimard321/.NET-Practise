using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetExampleDomain.Models.Course
{
    public class CreateCourseRequest
    {
        public string Name { get; set; }

        public int Capacity { get; set; }
    }
}
