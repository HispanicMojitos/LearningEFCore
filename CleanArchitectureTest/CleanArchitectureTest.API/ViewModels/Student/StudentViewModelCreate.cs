// <copyright file="StudentViewModel.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using System;
using System.Collections.Generic;

namespace CleanArchitectureTest.API.ViewModels
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentViewModel"/>.
    /// </summary>
    public class StudentViewModelCreate
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Description { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
