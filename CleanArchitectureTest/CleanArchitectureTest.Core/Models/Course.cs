// <copyright file="Cours.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Core.Models
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="Course"/>.
    /// </summary>
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; } = string.Empty;

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
