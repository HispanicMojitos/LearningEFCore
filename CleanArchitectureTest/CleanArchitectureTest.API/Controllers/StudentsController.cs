

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitectureTest.API.Controllers
{
    using System.Collections.Generic;

    using AutoMapper;

    using CleanArchitectureTest.API.ViewModels;
    using CleanArchitectureTest.Business.Interfaces;
    using CleanArchitectureTest.Core.Models;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]/[action]")]
    [ApiController]
    [Produces("application/json")]
    public class StudentsController : Controller
    {

        private readonly IStudentService studentService;
        private readonly IMapper mapper;

        public StudentsController(IStudentService service, IMapper mapper)
        {
            this.studentService = service;
            this.mapper = mapper;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<StudentViewModel> GetAll()
        {
            var students = studentService.GetStudents();
            return this.mapper.Map<IEnumerable<StudentViewModel>>(students);
        }

        [HttpGet]
        public IEnumerable<StudentViewModelListItem> GetAllListItems()
        {
            return this.mapper.Map<IEnumerable<StudentViewModelListItem>>(studentService.GetStudents());
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public StudentViewModel GetById(int id)
        {
            return this.mapper.Map<StudentViewModel>(studentService.GetStudentById(id));
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Create(StudentViewModelCreate studentCreate)
        {
            var student = this.mapper.Map<Student>(studentCreate);
            studentService.InsertStudent(student);
        }

        // PUT api/<StudentsController>/5
        [HttpPut]
        public void Update(StudentUpdate studentUpdate)
        {
            studentService.UpdateStudent(studentUpdate);
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            studentService.DeleteStudent(id);
        }
    }
}
