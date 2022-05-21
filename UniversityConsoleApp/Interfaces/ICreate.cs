using System;
using UniversityConsoleApp.Models;
using System.Collections.Generic;

namespace UniversityConsoleApp.Interfaces
{
    public interface ICreate
    {
        Person Create(string firstName, string lastName, int age);
        List<Person> Create(int count, int minAge);
    }
}