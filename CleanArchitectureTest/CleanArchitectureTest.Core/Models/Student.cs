// <copyright file="Student.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Core.Models
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="Student"/>.
    /// </summary>
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
    }
}
