// <copyright file="StudentConfiguration.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CleanArchitectureTest.Core.Models;
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
            builder.HasKey(s => s.StudentID);

            builder.Property(s => s.FirstName)
                .HasColumnName("FirstName")
                .IsRequired();

            builder.Property(s => s.LastName)
                .HasColumnName("LastName")
                .IsRequired();

            builder.Property(s => s.BirthDate)
                .HasColumnName("BirthDate")
                .HasColumnType("Date")
                .IsRequired();

        }
    }
}
