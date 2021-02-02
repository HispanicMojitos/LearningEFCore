// <copyright file="CourseConfiguration.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Data.Providers.Sql.Configurations
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="CourseConfiguration"/>.
    /// </summary>
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.ToTable("Courses");
        }
    }
}
