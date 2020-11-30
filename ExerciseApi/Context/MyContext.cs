﻿using ExerciseApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExerciseApi.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection") { }

        public DbSet<Employee> Employees { get; set; }
    }
}