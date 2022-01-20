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

        static List<Students> student = new List<Students>();
        public static List<string> titles = new List<string>() { "Имя", "Фамилия", "Группа" };

        public Students(string name, string surname, int group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }

        public static void AddToList(Students std)
        {
            student.Add(std);
        }

        public static List<Students> GetStudentInfo()
        {
            return student;
        }
    }
}
