// <copyright file="Student.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitectureTest.Data.Entitites
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="Student"/>.
    /// </summary>
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
    }
}
