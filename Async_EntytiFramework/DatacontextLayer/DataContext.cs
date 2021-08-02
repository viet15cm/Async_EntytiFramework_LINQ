using Async_EntytiFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Async_EntytiFramework.DatacontextLayer
{
      
    public class DataContext : DbContext
      {

            
        public  DbSet<Student> students { get; set; }
        
           
        public  DbSet<Grader> graders { get; set; }
        public object Grader { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {


            optionsBuilder.UseSqlServer(DataSource.Intances().GetDataSourceSever());

            }

            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            
            base.OnModelCreating(modelBuilder);

            //https://www.entityframeworktutorial.net/efcore/configure-one-to-one-relationship-using-fluent-api-in-ef-core.aspx

            
            modelBuilder.Entity<Student>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Grader>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Grader>()
                            .HasMany<Student>(g => g.Students)
                            .WithOne(s => s.Grader)
                            .HasForeignKey(s => s.GraderId);
                          

        }
    }
}
