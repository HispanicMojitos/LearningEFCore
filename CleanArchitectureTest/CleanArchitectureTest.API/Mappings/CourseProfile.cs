using AutoMapper;
using CleanArchitectureTest.API.ViewModels;
using CleanArchitectureTest.API.ViewModels.Course;
using CleanArchitectureTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureTest.API.Mappings
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            this.CreateMap<Course, CourseViewModelListItem>();

            this.CreateMap<CourseViewModelCreate, Course>();
        }
    }
}
