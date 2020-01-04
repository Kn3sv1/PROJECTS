using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorials
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int? GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
