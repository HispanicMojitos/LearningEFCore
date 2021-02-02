// <copyright file="Student.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

namespace CleanArchitectureTest.Core.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the definition of an object of type <see cref="Student"/>.
    /// </summary>
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Description { get; set; } = string.Empty;

        public bool IsOld => this.BirthDate < new DateTime(1985, 01, 01);

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
