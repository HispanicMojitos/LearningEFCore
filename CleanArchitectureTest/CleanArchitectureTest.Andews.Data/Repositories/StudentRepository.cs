// <copyright file="StudentRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using CleanArchitectureTest.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Data.Sql.Repositories
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentRepository"/>.
    /// </summary>
    public class StudentRepository : IStudentRepository
    {

        private StudentContext context;

        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }

        public void DeleteStudent(int studentId)
        {
            Student tmp = context.Students.Find(studentId);
            context.Students.Remove(tmp);
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
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            context.Entry(student).State = EntityState.Modified;
        }
    }
}
