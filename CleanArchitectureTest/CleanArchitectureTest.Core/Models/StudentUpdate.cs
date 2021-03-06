﻿// <copyright file="StudentViewModel.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace CleanArchitectureTest.Core.Models
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentUpdate"/>.
    /// </summary>
    public class StudentUpdate
    {
        public int Id { get; set; }

        public DateTime BirthDate { get; set; }

        public string Description { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
