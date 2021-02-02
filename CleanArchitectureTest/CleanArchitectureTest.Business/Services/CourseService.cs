// <copyright file="CourseService.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Business.Interfaces;
using CleanArchitectureTest.Core.Models;
using CleanArchitectureTest.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Business.Services
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="CourseService"/>.
    /// </summary>
    public class CourseService : ICourseService
    {
        private ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public void DeleteCourse(int courseId)
        {
            courseRepository.DeleteCourse(courseId);
        }

        public Course GetCourseById(int courseId)
        {
            return courseRepository.GetCourseById(courseId);
        }

        public IEnumerable<Course> GetCourses()
        {
            return courseRepository.GetCourses();
        }

        public void InsertCourse(Course course)
        {
            courseRepository.InsertCourse(course);
        }

        public void UpdateCourse(CourseUpdate courseUpdate)
        {
            courseRepository.UpdateCourse(courseUpdate);
        }
    }
}
