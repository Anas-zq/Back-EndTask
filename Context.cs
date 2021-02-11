using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskForSteadyPoint.Entities;
using TaskForSteadyPoint.EntityConfiguration;

namespace TaskForSteadyPoint
{
    public class Context : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
      
     
        public Context(DbContextOptions<Context> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false; // I will explain it to you later
            /*
             * Lazy Loading : multible querie s 
             * Eadger Loading : one query (include) 
             * */
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EmployeeConfiguration(modelBuilder.Entity<Employee>());
         

        }

    }
}
