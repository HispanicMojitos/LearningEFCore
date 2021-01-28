// <copyright file="StudentContext.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Data.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Data.Context
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentContext"/>.
    /// </summary>
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
