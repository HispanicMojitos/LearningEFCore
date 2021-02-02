using AutoMapper;
using CleanArchitectureTest.API.ViewModels;
using CleanArchitectureTest.API.ViewModels.Course;
using CleanArchitectureTest.Business.Interfaces;
using CleanArchitectureTest.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitectureTest.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService courseService;
        private readonly IMapper mapper;

        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            this.courseService = courseService;
            this.mapper = mapper;
        }
        // GET: api/<CoursesController>
        [HttpGet]
        public IEnumerable<CourseViewModel> Get()
        {
            return this.mapper.Map<IEnumerable<CourseViewModel>>(courseService.GetCourses());
        }

        [HttpGet]
        public IEnumerable<CourseViewModelListItem> GetAllListItems()
        {
            return this.mapper.Map<IEnumerable<CourseViewModelListItem>>(courseService.GetCourses());
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public CourseViewModel GetById(int id)
        {
            return this.mapper.Map<CourseViewModel>(courseService.GetCourseById(id));
        }

        // POST api/<CoursesController>
        [HttpPost]
        public void Create(CourseViewModelCreate courseCreate)
        {
            var course = this.mapper.Map<Course>(courseCreate);
            courseService.InsertCourse(course);
        }

        // PUT api/<CoursesController>/5
        [HttpPut]
        public void Update(CourseUpdate courseUpdate)
        {
            courseService.UpdateCourse(courseUpdate);
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            courseService.DeleteCourse(id);
        }
    }
}
