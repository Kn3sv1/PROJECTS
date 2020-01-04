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
                                            .ToList();

            studentsWithSameName.ForEach(e => Console.WriteLine(e.Name));
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

                context.Students.Add(std);
                context.SaveChanges();
            }
        }
    }
}
