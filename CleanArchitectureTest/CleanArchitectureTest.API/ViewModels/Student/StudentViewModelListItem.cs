// <copyright file="StudentViewModel.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using System.Collections.Generic;

namespace CleanArchitectureTest.API.ViewModels
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentViewModel"/>.
    /// </summary>
    public class StudentViewModelListItem
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
