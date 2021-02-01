// <copyright file="IStudentService.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System.Collections.Generic;

using CleanArchitectureTest.Core.Models;

namespace CleanArchitectureTest.Business.Interfaces
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="IStudentService"/>.
    /// </summary>
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();

        Student GetStudentById(int studentId);

        void InsertStudent(Student student);

        void DeleteStudent(int studentId);

        void UpdateStudent(StudentUpdate studentUpdate);
    }
}
