﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoEL0240.Models;

namespace DemoEL0240.Data
{
    public class EmpBootstrapContext : DbContext
    {
        public EmpBootstrapContext (DbContextOptions<EmpBootstrapContext> options)
            : base(options)
        {
        }

        public DbSet<DemoEL0240.Models.EmpBootstrap> EmpBootstrap { get; set; }

        #region 建立種子資料
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpBootstrap>().HasData(
                new EmpBootstrap { Id = 1, Name = "David", Mobile = "0933-152667", Email = "david@gmail.com", Department = "總經理室", Title = "CEO" },
                new EmpBootstrap { Id = 2, Name = "Mary", Mobile = "0938-456889", Email = "mary@gmail.com", Department = "人事部", Title = "管理師" },
                new EmpBootstrap { Id = 3, Name = "Joe", Mobile = "0925-331225", Email = "joe@gmail.com", Department = "財務部", Title = "經理" },
                new EmpBootstrap { Id = 4, Name = "Mark", Mobile = "0935-863991", Email = "mark@gmail.com", Department = "業務部", Title = "業務員" },
                new EmpBootstrap { Id = 5, Name = "Rose", Mobile = "0987-335668", Email = "rose@gmail.com", Department = "資訊部", Title = "工程師" },
                new EmpBootstrap { Id = 6, Name = "May", Mobile = "0955-259885", Email = "may@gmail.com", Department = "資訊部", Title = "工程師" },
                new EmpBootstrap { Id = 7, Name = "John", Mobile = "0921-123456", Email = "john@gmail.com", Department = "業務部", Title = "業務員" }
               );
        }
        #endregion
        #region 建立種子資料
        public DbSet<DemoEL0240.Models.Student> Student { get; set; }
        #endregion
    }
}
