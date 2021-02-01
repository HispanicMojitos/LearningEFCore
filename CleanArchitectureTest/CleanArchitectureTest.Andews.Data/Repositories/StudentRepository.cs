// <copyright file="StudentRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace CleanArchitectureTest.Data.Sql.Repositories
{
    using System.Collections.Generic;

    using AutoMapper;

    using CleanArchitectureTest.Core.Models;
    using CleanArchitectureTest.Data.Context;

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentRepository"/>.
    /// </summary>
    public class StudentRepository : IStudentRepository
    {
        private StudentContext context;
        private readonly IMapper mapper;

        public StudentRepository(StudentContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void DeleteStudent(int studentId)
        {
            Student tmp = context.Students.Find(studentId);
            context.Students.Remove(tmp);
            context.SaveChanges();
        }

        public Student GetStudentById(int studentId)
        {
            return context.Students.Find(studentId);
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students;
        }

        public void InsertStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void UpdateStudent(StudentUpdate studentUpdate)
        {
            var student = this.GetStudentById(studentUpdate.Id);

            this.mapper.Map(studentUpdate, student);

            context.SaveChanges();
        }
    }
}
