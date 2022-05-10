using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    internal class Student
    {
        public Student(int id, string lastName, string firstName, DateTime dateOfBirth, Faculty faculty)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Faculty = faculty;
        }

        public int? Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Faculty? Faculty { get; set; }

        public static List<Student> GetStudents()
        {
            int i = 0;
            return new List<Student>
            {
                new Student(++i, "Nguyễn", "Xuân Hùng", DateTime.Now, new Faculty("CNTT")),
                new Student(++i, "Đỗ", "Trọng Nhân", DateTime.Now, new Faculty("QT")),
                new Student(++i, "Trần", "Tuấn Kiệt", DateTime.Now, new Faculty("KT"))
            };
        }

        public string GetFacultyName()
        {
            return Faculty!.Name!;
        }
    }
}
