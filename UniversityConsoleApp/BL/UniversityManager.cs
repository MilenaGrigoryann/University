using System;
using UniversityConsoleApp.Models;
using System.Collections.Generic;
namespace UniversityConsoleApp.BL
{
    public static class UniversityManager
    {
        public static Student SwapWithTeacher(Student student, Teacher teacher)
        {
            student.Teacher = teacher;
            return student;
        }
        public static List<Person> SwapWithTeachers(List<Person> students, List<Person> teachers)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student student = (Student)students[i];
                Teacher teacher = (Teacher)teachers[i % teachers.Count];
                student.Teacher = teacher;

            }
            return students;
        }
        public static List<Person> SwapWithStudent(List<Person> teachers, List<Person> students)
        {
            int scount = students.Count;
            int tcount = teachers.Count;

            for (int i = 0; i < teachers.Count; i++)
            {
                int perTeacher = scount / tcount;
                Teacher teacher = (Teacher)teachers[i];
                teacher.Students = new List<Student>(perTeacher);
                for (int j = 0; j < perTeacher; j++)
                {
                    teacher.Students.Add((Student)students[j]);
                }

                scount = scount - perTeacher;
                tcount--;

            }

            return teachers;
        }
        public static Teacher SwapWithStudents(Teacher teacher, List<Student> students)
        {
            teacher.Students = students;
            return teacher;
        }
        public static List<Person> SwapWithGroup(List<Person> students, Group group)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student student = (Student)students[i];
                student.Group = group;
            }
            return students;
        }

    }
}