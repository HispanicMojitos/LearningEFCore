// <copyright file="IStudentService.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Business.ViewModels;
using CleanArchitectureTest.Core.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Business.Interfaces
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="IStudentService"/>.
    /// </summary>
    public interface IStudentService
    {
        StudentViewModel GetStudents();
        Student GetStudentById(int studentId);
        void InsertStudent(Student student);
        void DeleteStudent(int studentId);
        void UpdateStudent(Student student);
        void Save();
    }
}
