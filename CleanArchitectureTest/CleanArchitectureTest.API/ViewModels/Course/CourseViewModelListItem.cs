using CleanArchitectureTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureTest.API.ViewModels
{
    public class CourseViewModelListItem
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
