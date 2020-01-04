using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();
            var studentsWithSameName = context.Students
                                            .Where(s => s.Name == GetName())
                                            .Include(s => s.Grade)
                                            .ToList();

            studentsWithSameName.ForEach(e => Console.WriteLine($"{e.Name} GRADE: {e.Grade.GradeName}"));
        }

        public static string GetName()
        {
            return "Bill";
        }

        static void MainInsert(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Bill"
                };
                //https://www.entityframeworktutorial.net/efcore/saving-data-in-connected-scenario-in-ef-core.aspx
                context.Students.Add(std);
                // or
                // context.Add<Student>(std);
                context.SaveChanges();
            }
        }
    }
}
