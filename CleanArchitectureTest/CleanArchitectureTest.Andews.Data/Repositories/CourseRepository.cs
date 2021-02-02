// <copyright file="CourseRepository.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using AutoMapper;
using CleanArchitectureTest.Core.Models;
using CleanArchitectureTest.Data.Context;
using CleanArchitectureTest.Data.Interfaces;
using CleanArchitectureTest.Data.Providers.Sql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Data.Providers.Sql.Repositories
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="CourseRepository"/>.
    /// </summary>
    public class CourseRepository : ICourseRepository
    {
        private SchoolContext context;
        private readonly IMapper mapper;

        public CourseRepository(SchoolContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void DeleteCourse(int courseId)
        {
            Course tmp = context.Courses.Find(courseId);
            context.Courses.Remove(tmp);
            context.SaveChanges();
        }

        public Course GetCourseById(int courseId)
        {
            return context.Courses.Find(courseId);
        }

        public IEnumerable<Course> GetCourses()
        {
            return context.Courses;
        }

        public void InsertCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public void UpdateCourse(CourseUpdate courseUpdate)
        {
            var course = this.GetCourseById(courseUpdate.Id);

            this.mapper.Map(courseUpdate, course);

            context.SaveChanges();
        }
    }
}
