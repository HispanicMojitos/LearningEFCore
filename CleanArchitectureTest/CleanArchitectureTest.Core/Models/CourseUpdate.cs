// <copyright file="CourseUpdate.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Core.Models
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="CourseUpdate"/>.
    /// </summary>
    public class CourseUpdate
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
