using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    internal class Faculty
    {
        public Faculty(string key)
        {
            Key = key;
            Name = GetFacultyName(key);
        }
        public string? Key { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return Name!;
        }

        private string GetFacultyName(string key)
        {
            return key switch
            {
                "QT" => "Quản trị",
                "KT" => "Kinh tế",
                "CNTT" => "Công nghệ thông tin",
                _ => "------Chọn khoa------"
            };
        }

        public static List<Faculty> GetFaculties()
        {
            return new List<Faculty>
            {
                new Faculty(""),
                new Faculty("CNTT"),
                new Faculty("QT"),
                new Faculty("KT")
            };
        }
    }
}
