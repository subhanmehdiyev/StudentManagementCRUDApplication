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
        public Image Image { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Nationality { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }

        public byte[] imageInByteArray;
    }
}
