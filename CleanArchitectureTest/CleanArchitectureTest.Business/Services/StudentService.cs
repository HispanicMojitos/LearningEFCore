// <copyright file="StudentService.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Business.Interfaces;
using CleanArchitectureTest.Business.ViewModels;
using CleanArchitectureTest.Core.Models;
using CleanArchitectureTest.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Business.Services
{
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

        public StudentViewModel GetStudents()
        {
            return new StudentViewModel()
            {
                Students = studentRepository.GetStudents()
            };
        }

        public void InsertStudent(Student student)
        {
            studentRepository.InsertStudent(student);
        }

        public void Save()
        {
            studentRepository.Save();
        }

        public void UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
        }
    }
}
