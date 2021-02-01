// <copyright file="StudentConfiguration.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureTest.Data.Sql.Configurations
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentConfiguration"/>.
    /// </summary>
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Ignore(prop => prop.IsOld);

            builder.ToTable("Students");
        }
    }
}
