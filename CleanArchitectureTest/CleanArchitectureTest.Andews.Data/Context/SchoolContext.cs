// <copyright file="StudentContext.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using CleanArchitectureTest.Data.Providers.Sql.Configurations;
using CleanArchitectureTest.Data.Sql.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Data.Context
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="SchoolContext"/>.
    /// </summary>
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
