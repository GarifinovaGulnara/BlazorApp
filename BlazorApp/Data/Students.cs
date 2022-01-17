using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Students
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Group { get; set; }

        public static List<string> titles = new List<string>() { "Имя", "Фамилия", "Группа" };

        public Students(string name, string surname, int group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }

        public static List<Students> GetStudentInfo()
        {
            List<Students> student = new List<Students>();
            student.Add(new Students("Alina", "Al", 321));
            student.Add(new Students("Adel", "Adelinova", 322));
            student.Add(new Students("Masha", "Sergy", 322));
            student.Add(new Students("Pasha", "Blinov", 321));
            student.Add(new Students("Kety", "Pavlova", 321));
            return student;
        }
    }
}
