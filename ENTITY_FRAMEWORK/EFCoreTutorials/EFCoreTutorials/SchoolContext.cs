using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorials
{
    public class SchoolContext : DbContext
    {
        //https://docs.microsoft.com/en-us/ef/core/miscellaneous/logging?tabs=v2
        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder//.UseLoggerFactory(MyLoggerFactory)
                .UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=SchoolDB333;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
