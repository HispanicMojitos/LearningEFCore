// <copyright file="StudentService.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace CleanArchitectureTest.Business.Services
{
    using System.Collections.Generic;

    using CleanArchitectureTest.Business.Interfaces;
    using CleanArchitectureTest.Core.Models;
    using CleanArchitectureTest.Data;

    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentService"/>.
    /// </summary>
    public class StudentService : IStudentService
    {
        public IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public void DeleteStudent(int studentId)
        {
            studentRepository.DeleteStudent(studentId);
        }

        public Student GetStudentById(int studentId)
        {
            return studentRepository.GetStudentById(studentId);
        }

        public IEnumerable<Student> GetStudents()
        {
            return studentRepository.GetStudents();
        }

        public void InsertStudent(Student student)
        {
            if (student.Description != "Test")
            {
                studentRepository.InsertStudent(student);
            }
        }

        public void UpdateStudent(StudentUpdate studentUpdate)
        {
            studentRepository.UpdateStudent(studentUpdate);
        }
    }
}
