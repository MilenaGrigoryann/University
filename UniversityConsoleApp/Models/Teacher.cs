using System;
using System.Collections.Generic;
namespace UniversityConsoleApp.Models
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }
        public Group Group { get; set; }
        public Group[] Groups { get; set; }
        public Teacher()
        {

        }
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public Teacher(string firstName, string lastName, int age, List<Student> students) : base(firstName, lastName, age)
        {

            Students = students;

        }
        public Teacher(string firstName, string lastName, int age, List<Student> students, Group group) : base(firstName, lastName, age)
        {

            Students = students;

            Group = group;

        }

    }
}