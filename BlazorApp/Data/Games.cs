using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Games
    {
        public string Name { get; set; }
        public string Release { get; set; }
        public double Rating { get; set; }

        public static List<string> titlesG = new List<string>() { "Название", "Релиз", "Рейтинг" };

        public Games(string name, string release, double rating)
        {
            Name = name;
            Release = release;
            Rating = rating;
        }

        public static List<Games> GetStudentInfo()
        {
            List<Games> game = new List<Games>();
            game.Add(new Games("GI", "21.05.2019", 4.95));
            game.Add(new Games("T", "04.04.2004", 4.85));
            game.Add(new Games("SR", "7.06.2019", 4.5));
            game.Add(new Games("F", "15.10.2015", 3.4));
            game.Add(new Games("As", "08.09.2010", 4));
            return game;
        }
    }
}
