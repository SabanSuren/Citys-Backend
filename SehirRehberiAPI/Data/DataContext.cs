﻿using Microsoft.EntityFrameworkCore;
using SehirRehberiAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberiAPI.Data
{
    public class DataContext:DbContext
    {
        internal object values;

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {


        }
        public DbSet<Value> Values { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
        public object Value { get; internal set; }
    }
}
