// <copyright file="ICourseService.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Business.Interfaces
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="ICourseService"/>.
    /// </summary>
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses();

        Course GetCourseById(int courseId);

        void InsertCourse(Course course);

        void DeleteCourse(int courseId);

        void UpdateCourse(CourseUpdate courseUpdate);
    }
}
