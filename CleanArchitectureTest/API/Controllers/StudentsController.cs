using CleanArchitectureTest.Business.Interfaces;
using CleanArchitectureTest.Business.Services;
using CleanArchitectureTest.Business.ViewModels;
using CleanArchitectureTest.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitectureTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class StudentsController : Controller
    {

        private readonly IStudentService studentService;
        public StudentsController(IStudentService service)
        {
            this.studentService = service;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public StudentViewModel Get()
        {
            return studentService.GetStudents();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return studentService.GetStudentById(id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post(Student student)
        {
            studentService.InsertStudent(student);
            studentService.Save();
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, Student student)
        {
            studentService.UpdateStudent(student);
            studentService.Save();
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            studentService.DeleteStudent(id);
            studentService.Save();
        }
    }
}
