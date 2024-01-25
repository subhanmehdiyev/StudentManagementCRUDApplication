using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementCRUDApp
{
    internal class Student
    {
        public int ID { get; set; }
        public string ProfilImagePath { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string Gender { get; set; }
        public string? Address { get; set; }
    }
}
