// <copyright file="IStudentRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Data
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="IStudentRepository"/>.
    /// </summary>
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();

        Student GetStudentById(int studentId);

        void InsertStudent(Student student);

        void DeleteStudent(int studentId);

        void UpdateStudent(StudentUpdate studentUpdate);
    }
}
