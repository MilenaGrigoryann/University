using System;
using UniversityConsoleApp.Models;
using System.Collections.Generic;

namespace UniversityConsoleApp.Interfaces
{
    public interface IPrint
    {
        void Print(Person person);
        void Print(List<Person> people);
    }
}