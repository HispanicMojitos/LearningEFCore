// <copyright file="StudentViewModel.cs" company="Wavenet">
// Copyright (c) Wavenet. All rights reserved.
// </copyright>

using CleanArchitectureTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureTest.Business.ViewModels
{
    /// <summary>
    /// Contains the definition of an object of type <see cref="StudentViewModel"/>.
    /// </summary>
    public class StudentViewModel
    {
        public IEnumerable<Student> Students { get; set; }
    }
}
