// <copyright file="CourseProfile.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using AutoMapper;
using CleanArchitectureTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Data.Providers.Sql.Mappings
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="CourseProfile"/>.
    /// </summary>
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            this.CreateMap<CourseUpdate, Course>();
        }
    }
}
