// <copyright file="StudentCourse.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Core.Models
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentCourse"/>.
    /// </summary>
    public class StudentCourse
    {
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
